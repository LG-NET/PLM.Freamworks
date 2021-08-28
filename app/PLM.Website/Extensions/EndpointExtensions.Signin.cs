using Microsoft.AspNetCore.Builder;
using PLM.Website.Controllers.Constants;

namespace Microsoft.AspNetCore.Routing
{
    public static partial class EndpointExtensions
    {
        public static void AddSigninRoute(this IEndpointRouteBuilder routes)
        {
            routes.MapControllerRoute(
                name: ControllerConstants.Signin.Controller + ControllerConstants.Signin.Actions.Index,
                pattern: ControllerConstants.Signin.Actions.IndexPattern,
                defaults: new { controller = ControllerConstants.Signin.Controller, action = ControllerConstants.Signin.Actions.Index }
            );

            routes.MapControllerRoute(
                name: ControllerConstants.Signin.Controller + ControllerConstants.Signin.Actions.ForgotPassword,
                pattern: ControllerConstants.Signin.Actions.ForgotPasswordPattern,
                defaults: new { controller = ControllerConstants.Signin.Controller, action = ControllerConstants.Signin.Actions.ForgotPassword }
            );
        }
    }
}
