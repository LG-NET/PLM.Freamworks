using System;

namespace PLM.Website.Controllers.Constants
{
    public static partial class ControllerConstants
    {
        public static class Merchandise
        {
            public static readonly string Area = typeof(MerchandiseController).ControllerOfArea();
            public static readonly string Controller = typeof(MerchandiseController).ControllerName();

            public static class Actions
            {
                /// <summary>Route Pattern: <see cref="IndexPattern"/>.</summary>
                public const string Index = nameof(MerchandiseController.Index);
                public const string IndexPattern = "Merchandise/index";
                
                /// <summary>Route Pattern: <see cref="EditorPattern"/>.</summary>
                public const string Editor = nameof(MerchandiseController.Editor);
                public const string EditorPattern = "Merchandise/Editor";

                /// <summary>Route Pattern: <see cref="AddMerchandisePattern"/>.</summary>
                public const string AddMerchandise = nameof(MerchandiseController.AddMerchandise);
                public const string AddMerchandisePattern = "Merchandise/AddMerchandise";

            }
        }
    }
}
