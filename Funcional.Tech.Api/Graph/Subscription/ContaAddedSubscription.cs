using GraphQL.Resolvers;
using GraphQL.Types;
using Funcional.Tech.Api.Dto;
using Funcional.Tech.Api.Graph.Type;
using Funcional.Tech.Api.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Funcional.Tech.Api.Graph.Subscription
{
    public class ContaAddedSubscription : IFieldSubscriptionServiceItem
    {
        public void Activate(ObjectGraphType objectGraph, IWebHostEnvironment env, IServiceProvider sp)
        {
            objectGraph.AddField(new EventStreamFieldType
            {
                Name = "contaAdded",
                Type = typeof(ContaAddedMessageGType),
                Resolver = new FuncFieldResolver<ContaAddedMensage>(context => context.Source as ContaAddedMensage),
                Arguments = new QueryArguments(                   
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "conta" }
                ),
                
            });
        }
    }
}
