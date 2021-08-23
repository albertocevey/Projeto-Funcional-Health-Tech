using Funcional.Tech.Api.Graph.Mutation;
using Funcional.Tech.Api.Graph.Query;
using Funcional.Tech.Api.Graph.Subscription;
using Funcional.Tech.Api.Interfaces;
using GraphQL;

namespace Funcional.Tech.Api.Graph.Schema
{
    public class GraphQLSchema : GraphQL.Types.Schema
    {
        public GraphQLSchema(IDependencyResolver resolver) : base(resolver)
        {
            var fieldService = resolver.Resolve<IFieldService>();
            fieldService.RegisterFields();
            Mutation = resolver.Resolve<MainMutation>();
            Query = resolver.Resolve<MainQuery>();
            Subscription = resolver.Resolve<MainSubscription>();           
        }
    }
}
