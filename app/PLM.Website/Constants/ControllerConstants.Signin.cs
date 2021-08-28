using System;

namespace PLM.Website.Controllers.Constants
{
    public static partial class ControllerConstants
    {
        public static class Signin
        {
            public static readonly string Area = typeof(SigninController).ControllerOfArea();
            public static readonly string Controller = typeof(SigninController).ControllerName();

            public static class Actions
            {
                /// <summary>Route Pattern: <see cref="IndexPattern"/>.</summary>
                public const string Index = nameof(SigninController.Index);
                public const string IndexPattern = "Signin/Index";

                /// <summary>Route Pattern: <see cref="ForgotPasswordPattern"/>.</summary>
                public const string ForgotPassword = nameof(SigninController.ForgotPassword);
                public const string ForgotPasswordPattern = "Signin/ForgotPassword";
            }
        }
    }
}
