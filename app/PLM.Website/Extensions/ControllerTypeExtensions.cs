using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace System
{
    public static class ControllerTypeExtensions
    {
        public static string ControllerOfArea(this Type controllerType)
        {
            return "PLM." + ControllerName(controllerType);
        }

        public static string ControllerName(this Type controllerType)
        {
            if (!typeof(Controller).IsAssignableFrom(controllerType))
            {
                ThrowArgumentException(controllerType);
            }

            string name = controllerType.Name;
            if (!name.EndsWith("Controller", StringComparison.OrdinalIgnoreCase))
            {
                return name;
            }

            return name.Substring(0, name.Length - "Controller".Length);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void ThrowArgumentException(Type controllerType)
        {
            throw GetArgumentException(controllerType);
        }

        private static ArgumentException GetArgumentException(Type controllerType)
        {
            return new ArgumentException("The specified type must inherit from Controller", "controllerType");
        }
    }
}
