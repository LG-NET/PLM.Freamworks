using Microsoft.AspNetCore.Builder;
using PLM.Website.Controllers.Constants;

namespace Microsoft.AspNetCore.Routing
{
    public static partial class EndpointExtensions
    {
        public static void AddMerchandiseRoute(this IEndpointRouteBuilder routes)
        {
            routes.MapControllerRoute(
                name: ControllerConstants.Merchandise.Controller + ControllerConstants.Merchandise.Actions.Index,
                pattern: ControllerConstants.Merchandise.Actions.IndexPattern,
                defaults: new { controller = ControllerConstants.Merchandise.Controller, action = ControllerConstants.Merchandise.Actions.Index }
            );

            routes.MapControllerRoute(
                name: ControllerConstants.Merchandise.Controller + ControllerConstants.Merchandise.Actions.Editor,
                pattern: ControllerConstants.Merchandise.Actions.EditorPattern,
                defaults: new { controller = ControllerConstants.Merchandise.Controller, action = ControllerConstants.Merchandise.Actions.Editor }
            );

            routes.MapControllerRoute(
               name: ControllerConstants.Merchandise.Controller + ControllerConstants.Merchandise.Actions.AddMerchandise,
               pattern: ControllerConstants.Merchandise.Actions.AddMerchandisePattern,
               defaults: new { controller = ControllerConstants.Merchandise.Controller, action = ControllerConstants.Merchandise.Actions.AddMerchandise }
           );
        }
    }
}
