using Grand.Infrastructure.Endpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace DiscountRules.Pickup
{
    public class EndpointProvider : IEndpointProvider
    {
        public void RegisterEndpoint(IEndpointRouteBuilder endpointRouteBuilder)
        {
            //Pickup
            endpointRouteBuilder.MapControllerRoute("Plugin.DiscountRules.Pickup.Configure",
                 "Admin/PickupDiscount/Configure",
                 new { controller = "PickupDiscount", action = "Configure" }
            );
        }

        public int Priority => 0;
    }
}
