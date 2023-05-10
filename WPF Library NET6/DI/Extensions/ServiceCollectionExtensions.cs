using System.Reflection;
using System;
using System.Linq;
using WPFLibrary.DI.Attributes;

namespace WPFLibrary.DI.Extensions;

public static class ServiceCollectionExtensions
{
    private static Type[] GetTypes ()
    {
        return Assembly.GetExecutingAssembly()
                       .GetTypes();
    }

    private static Type GetBaseType (Type type)
    {
        var interfaces = type.GetInterfaces();

        foreach (var i in interfaces) {
            var attributes = i.GetCustomAttributes();

            if (attributes.Any(a => a is BaseTypeAttribute)) {
                return i;
            }
        }

        throw new InvalidOperationException($"Can not get base type for {type.FullName}");
    }

    private static Lifetime DetermineLifetime (Type service, bool inheritAttributes)
    {
        var attribute = service.GetCustomAttributes(inheritAttributes)
                               .FirstOrDefault(s => s is LifetimeAttribute);

        if (attribute is not LifetimeAttribute lifetimeAttribute) {
            throw new InvalidOperationException($"Cannot determine lifetime of the service {service.FullName}");
        }

        return lifetimeAttribute.Lifetime;
    }
}