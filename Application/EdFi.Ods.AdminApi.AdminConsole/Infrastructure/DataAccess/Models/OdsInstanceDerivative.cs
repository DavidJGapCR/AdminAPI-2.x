// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

namespace EdFi.Ods.AdminApi.AdminConsole.Infrastructure.DataAccess.Models;

public class OdsInstanceDerivative
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public DerivativeType DerivativeType { get; set; } = DerivativeType.ReadReplica;

    public int InstanceId { get; set; }
    public Instance Instance { get; set; } = null!;
}

public enum DerivativeType
{
    ReadReplica,
    Snapshot
}
