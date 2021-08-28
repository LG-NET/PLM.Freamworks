using Microsoft.AspNetCore.Builder;
using PLM.Website.Controllers.Constants;

namespace Microsoft.AspNetCore.Routing
{
    public static partial class EndpointExtensions
    {
        public static void AddHomeRoute(this IEndpointRouteBuilder routes)
        {
            routes.MapControllerRoute(
                name: ControllerConstants.DefaultName,
                pattern: ControllerConstants.Home.Actions.IndexPattern,
                defaults: new { controller = ControllerConstants.Home.Controller, action = ControllerConstants.Home.Actions.Index }
            );
        }
    }
}
