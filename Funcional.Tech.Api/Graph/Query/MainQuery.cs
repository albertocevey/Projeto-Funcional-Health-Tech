using GraphQL.Types;
using Funcional.Tech.Api.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Funcional.Tech.Api.Graph.Query
{
    public class MainQuery : ObjectGraphType
    {
        public MainQuery(IServiceProvider provider, IWebHostEnvironment env, IFieldService fieldService)
        {
            Name = "MainQuery";
            fieldService.ActivateFields(this, FieldServiceType.Query, env, provider);
        }
    }
}
