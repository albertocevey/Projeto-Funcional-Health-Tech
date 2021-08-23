using GraphQL.Types;
using Funcional.Tech.Api.Interfaces;
using Funcional.Tech.Api.Models;
using System;
using System.Linq;

namespace Funcional.Tech.Api.Graph.Type
{
    public class ContaGType : ObjectGraphType<Conta>
    {
        public IServiceProvider Provider { get; set; }
        public ContaGType(IServiceProvider provider)
        {
            Field(x => x.conta, type: typeof(IntGraphType));
            Field(x => x.saldo, type: typeof(FloatGraphType));
            
        }
    }
}
