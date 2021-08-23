using GraphQL.Types;
using Funcional.Tech.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funcional.Tech.Api.Graph.Type
{
    public class ContaAddedMessageGType : ObjectGraphType<ContaAddedMensage>
    {
        public ContaAddedMessageGType()
        {
            
            Field(x => x.message, type: typeof(StringGraphType));
            Field(x => x.conta, type: typeof(IntGraphType));
            Field(x => x.saldo, type: typeof(FloatGraphType));
        }
    }
}
