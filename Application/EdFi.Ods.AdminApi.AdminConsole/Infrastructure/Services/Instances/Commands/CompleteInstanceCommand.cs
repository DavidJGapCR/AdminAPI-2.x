// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using EdFi.Ods.AdminApi.AdminConsole.Infrastructure.DataAccess.Models;

namespace EdFi.Ods.AdminApi.AdminConsole.Infrastructure.Services.Instances.Commands;

public interface ICompleteInstanceCommand
{
    Task<Instance> Execute();
}

public class CompleteInstanceCommand : ICompleteInstanceCommand
{
    public CompleteInstanceCommand()
    {

    }

    public async Task<Instance> Execute()
    {
        throw new NotImplementedException();
    }
}
