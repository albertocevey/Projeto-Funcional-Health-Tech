using Funcional.Tech.Api.Interfaces;

namespace Funcional.Tech.Api.Services
{
    public class SubscriptionServices : ISubscriptionServices
    {
        public SubscriptionServices()
        {
            this.ContaAddedService = new ContaAddedService();
        }
        public ContaAddedService ContaAddedService { get; }
    }
}
