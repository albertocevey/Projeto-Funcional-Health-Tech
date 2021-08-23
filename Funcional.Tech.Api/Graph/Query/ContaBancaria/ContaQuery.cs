using GraphQL.Types;
using Funcional.Tech.Api.Graph.Type;
using Funcional.Tech.Api.Interfaces;
using Funcional.Tech.Api.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Linq;
using GraphQL;

namespace Funcional.Tech.Api.Graph.Query.ContaBancaria
{
    public class ContaQuery : IFieldQueryServiceItem
    {
        public void Activate(ObjectGraphType objectGraph, IWebHostEnvironment env, IServiceProvider sp)
        {
            objectGraph.Field<ListGraphType<ContaGType>>("saldo",
               arguments: new QueryArguments(
                 new QueryArgument<IntGraphType> { Name = "conta" }
               ),
               resolve: context =>
               {            
                   var contaRepository = (IGenericRepository<Conta>)sp.GetService(typeof(IGenericRepository<Conta>));
                   var baseQuery = contaRepository.GetAll();
                   int conta = context.GetArgument<int>("conta");
                   var foundConta = contaRepository.GetByConta(conta);

                   if (conta != default)
                   {
                       if (foundConta == null)
                       {
                           throw new ExecutionError("Não existe esta conta");
                       }
                       return baseQuery.Where(w => w.conta.Equals(conta));
                   }
                   else
                   {
                       return baseQuery.ToList();
                   }
               });
        }
    }
}
