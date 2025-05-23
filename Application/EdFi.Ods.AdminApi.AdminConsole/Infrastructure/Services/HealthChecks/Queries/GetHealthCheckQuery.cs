// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using EdFi.Ods.AdminApi.AdminConsole.Infrastructure.DataAccess.Models;
using EdFi.Ods.AdminApi.AdminConsole.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EdFi.Ods.AdminApi.AdminConsole.Infrastructure.Services.HealthChecks.Queries;

public interface IGetHealthCheckQuery
{
    Task<HealthCheck?> Execute(int instanceId);
}

public class GetHealthCheckQuery(IQueriesRepository<HealthCheck> healthCheckQuery) : IGetHealthCheckQuery
{
    private readonly IQueriesRepository<HealthCheck> _healthCheckQuery = healthCheckQuery;

    public async Task<HealthCheck?> Execute(int instanceId)
    {
        var healthCheck = await _healthCheckQuery.Query().SingleOrDefaultAsync(healthCheck => healthCheck.InstanceId == instanceId);
        return healthCheck;
    }
}
