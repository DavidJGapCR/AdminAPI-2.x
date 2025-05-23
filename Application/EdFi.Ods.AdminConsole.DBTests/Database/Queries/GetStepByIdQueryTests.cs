// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Threading.Tasks;
using EdFi.Ods.AdminApi.AdminConsole.Infrastructure.DataAccess.Models;
using EdFi.Ods.AdminApi.AdminConsole.Infrastructure.Repositories;
using EdFi.Ods.AdminApi.AdminConsole.Infrastructure.Services;
using EdFi.Ods.AdminApi.AdminConsole.Infrastructure.Services.Steps.Commands;
using EdFi.Ods.AdminApi.AdminConsole.Infrastructure.Services.Steps.Queries;
using EdFi.Ods.AdminApi.Common.Settings;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using Shouldly;

namespace EdFi.Ods.AdminConsole.DBTests.Database.CommandTests;

[TestFixture]
public class GetStepByIdQueryTests : PlatformUsersContextTestBase
{
    private IOptions<AppSettings> _options { get; set; }

    [OneTimeSetUp]
    public virtual async Task FixtureSetup()
    {
        AdminConsoleSettings appSettings = new AdminConsoleSettings();
        await Task.Yield();
    }

    [Test]
    public async Task ShouldExecuteAsync()
    {
        var stepDocument = "[{\"number\":1,\"description\":\"Step1\",\"startedAt\":\"2022-01-01T09:00:00\",\"completedAt\":\"2022-01-01T09:30:00\",\"status\":\"Completed\"},{\"number\":2,\"description\":\"Step2\",\"startedAt\":\"2022-01-01T09:30:00\",\"completedAt\":\"2022-01-01T09:45:00\",\"status\":\"Completed\"},{\"number\":3,\"description\":\"Step3\",\"startedAt\":\"2022-01-01T09:45:00\",\"completedAt\":\"2022-01-01T10:00:00\",\"status\":\"Completed\"}]";
        Step result = null;

        var newStep = new TestStep
        {
            InstanceId = 1,
            TenantId = 1,
            EdOrgId = 1,
            Document = stepDocument
        };

        await TransactionAsync(async dbContext =>
        {
            var repository = new CommandRepository<Step>(dbContext);
            var command = new AddStepCommand(repository);

            result = await command.Execute(newStep);

            var queryRepository = new QueriesRepository<Step>(dbContext);
            var query = new GetStepsByIdQuery(queryRepository);
            var step = await query.Execute(result.TenantId, result.DocId.Value);

            step.DocId.ShouldBe(result.DocId);
            step.TenantId.ShouldBe(newStep.TenantId);
            step.InstanceId.ShouldBe(newStep.InstanceId);
            step.EdOrgId.ShouldBe(newStep.EdOrgId);
            step.Document.ShouldBe(newStep.Document);
        });
    }

    private class TestStep : IAddStepModel
    {
        public int DocId { get; }
        public int TenantId { get; set; }
        public int InstanceId { get; set; }
        public int? EdOrgId { get; set; }
        public string Document { get; set; }
    }
}
