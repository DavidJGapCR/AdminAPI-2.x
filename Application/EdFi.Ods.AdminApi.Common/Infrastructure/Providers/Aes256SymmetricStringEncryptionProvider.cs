// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Security.Cryptography;
using EdFi.Ods.AdminApi.Common.Infrastructure.Providers.Interfaces;
using log4net;

namespace EdFi.Ods.AdminApi.Common.Infrastructure.Providers;

/// <summary>
/// Implements AES 256 bit symmetric key encryption of string values.
/// </summary>
/// <remarks>
/// This class is used to facilitate the encryption of string values using the AES 256 bit
/// encryption algorithm. HMAC signing of the encrypted value is used to mitigate potential
/// timing-based padding oracle attacks on AES in CBC mode (as discussed here
/// https://learn.microsoft.com/en-us/dotnet/standard/security/vulnerabilities-cbc-mode)
/// by providing a means of verifying the authenticity of the encrypted content before decryption is attempted.</remarks>
public class Aes256SymmetricStringEncryptionProvider : ISymmetricStringEncryptionProvider
{

    private readonly ILog _logger;

    public Aes256SymmetricStringEncryptionProvider()
    {
        _logger = LogManager.GetLogger(typeof(Aes256SymmetricStringEncryptionProvider));
    }

    /// <summary>
    /// Encrypt the specified string value using the specified key.
    /// </summary>
    /// <para name="value">The string value to be encrypted.</para>
    /// <para name="key">The 256 bit private key to be used for encryption.</para>
    /// <returns>A string representing the input in encrypted form along with the other information
    /// necessary to decrypt it (aside from the private key). The output is three strings concatenated in
    /// the format "IV|EncryptedMessage|HMACSignature"</returns>
    public string Encrypt(string? value, byte[]? key)
    {
        // Incorporates code from https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-6.0
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Input value cannot be null or whitespace.", nameof(value));
        }

        if (key == null || key.Length != 32)
        {
            throw new ArgumentException("Key must be 256 bits (32 bytes) in length.", nameof(key));
        }

        using Aes aesInstance = Aes.Create();

        aesInstance.Key = key;
        aesInstance.GenerateIV();
        byte[] encryptedBytes;

        ICryptoTransform encryptor = aesInstance.CreateEncryptor(aesInstance.Key, aesInstance.IV);

        using (MemoryStream msEncrypt = new())
        {
            using CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write);
            using (StreamWriter swEncrypt = new(csEncrypt))
            {
                swEncrypt.Write(value);
            }

            encryptedBytes = msEncrypt.ToArray();
        }

        byte[] hmacSignatureValue = GenerateHmacSignature();

        return
            $"{Convert.ToBase64String(aesInstance.IV)}|{Convert.ToBase64String(encryptedBytes)}|{Convert.ToBase64String(hmacSignatureValue)}";

        byte[] GenerateHmacSignature()
        {
            byte[] hmacSignature;

            using (HMACSHA256 hmac = new(key))
            {
                hmacSignature = hmac.ComputeHash(encryptedBytes);
            }

            return hmacSignature;
        }
    }

    /// <summary>
    /// Decrypt a string value using the specified key.
    /// </summary>
    /// <para name="value">The data to be decrypted and related information as three base64
    /// encoded segments concatenated in the format "IV|EncryptedMessage|HMACSignature"</para>
    /// <para name="key">The 256 bit private key to be used for decryption.</para>
    /// <para name="output">If decryption is successful, then the plaintext output, otherwise null</para>
    /// <returns>A boolean value indicating if decryption was successful.</returns>
    public bool TryDecrypt(string value, byte[] key, out string? output)
    {
        // Includes code from https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-6.0
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Input value cannot be null or whitespace.", nameof(value));
        }

        if (key == null || key.Length != 32)
        {
            throw new ArgumentException("Key must be 256 bits (32 bytes) in length.", nameof(key));
        }

        string[] inputParts = value.Split('|');

        if (inputParts.Length != 3)
        {
            output = null;
            return false;
        }

        string base64Iv = inputParts[0];
        string base64EncryptedBytes = inputParts[1];
        string base64HashValue = inputParts[2];
        byte[] iv;
        byte[] encryptedBytes;
        byte[] hashValue;

        try
        {
            iv = Convert.FromBase64String(base64Iv);
            encryptedBytes = Convert.FromBase64String(base64EncryptedBytes);
            hashValue = Convert.FromBase64String(base64HashValue);
        }
        catch (Exception e)
        {
            _logger.Error("Unable to convert encryption key from Base 64 String.", e);
            throw new ArgumentException("Unable to convert key from Base 64 String.", nameof(key));
        }

        bool signatureIsValid = IsHmacSignatureValid();

        if (!signatureIsValid)
        {
            output = null;
            return false;
        }

        using Aes aesInstance = Aes.Create();

        aesInstance.Key = key;
        aesInstance.IV = iv;

        ICryptoTransform decryptor = aesInstance.CreateDecryptor(aesInstance.Key, aesInstance.IV);

        using MemoryStream msDecrypt = new(encryptedBytes);
        using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
        using StreamReader srDecrypt = new(csDecrypt);
        output = srDecrypt.ReadToEnd();

        return true;

        bool IsHmacSignatureValid()
        {
            bool signatureCheckResult;

            using (HMACSHA256 hmac = new(key))
            {
                byte[] computedHashValue = hmac.ComputeHash(encryptedBytes);
                signatureCheckResult = hashValue.SequenceEqual(computedHashValue);
            }

            return signatureCheckResult;
        }
    }
}
