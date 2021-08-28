using System;

namespace PLM.Website.Controllers.Constants
{
    public static partial class ControllerConstants
    {
        public const string DefaultName = "default";

        public static class Home
        {
            public static readonly string Area = typeof(HomeController).ControllerOfArea();
            public static readonly string Controller = typeof(HomeController).ControllerName();

            public static class Actions
            {
                /// <summary>Route Pattern: <see cref="IndexPattern"/>.</summary>
                public const string Index = nameof(HomeController.Index);
                public const string IndexPattern = "{controller=Home}/{action=Index}";
            }
        }
    }
}
