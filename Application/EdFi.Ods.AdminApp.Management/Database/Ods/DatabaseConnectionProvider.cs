// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

#if !NET48
using System;
using EdFi.Common.Configuration;
using EdFi.Ods.AdminApp.Management.Helpers;
using Microsoft.Extensions.Options;
#endif
using System.Data;
using System.Data.SqlClient;
using EdFi.Ods.AdminApp.Management.Services;
using Npgsql;
using ApiMode = EdFi.Ods.AdminApp.Management.Instances.ApiMode;

namespace EdFi.Ods.AdminApp.Management.Database.Ods
{
    public interface IDatabaseConnectionProvider
    {
        IDbConnection CreateNewConnection(int odsInstanceNumericSuffix, ApiMode apiMode);
        IDbConnection CreateNewConnection(string odsInstanceName, ApiMode apiMode);
    }

    public class DatabaseConnectionProvider : IDatabaseConnectionProvider
    {
        private readonly IConnectionStringService _connectionStringService;

        #if !NET48
            private readonly IOptions<AppSettings> _appSettings;
        #endif

        public DatabaseConnectionProvider(IConnectionStringService connectionStringService
        #if !NET48
            , IOptions<AppSettings> appSettings
        #endif
            )
        {
            _connectionStringService = connectionStringService;
        #if !NET48
            _appSettings = appSettings;
        #endif
        }

        public IDbConnection CreateNewConnection(int odsInstanceNumericSuffix, ApiMode apiMode)
        {
            return CreateNewConnection(odsInstanceNumericSuffix.ToString(), apiMode);
        }

        public IDbConnection CreateNewConnection(string odsInstanceName, ApiMode apiMode)
        {
            var connectionString = _connectionStringService.GetConnectionString(odsInstanceName, apiMode);

            #if NET48
                var isPostgreSql = DatabaseProviderHelper.PgSqlProvider;
            #else
                var isPostgreSql = ApiConfigurationConstants.PostgreSQL.Equals(_appSettings.Value.DatabaseEngine, StringComparison.InvariantCultureIgnoreCase);
            #endif

            if (isPostgreSql)
            {
                return new NpgsqlConnection(connectionString);
            }

            return new SqlConnection(connectionString);
        }
    }
}
