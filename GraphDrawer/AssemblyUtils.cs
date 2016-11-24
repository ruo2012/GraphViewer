using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GraphDrawer
{
    class AssemblyUtils
    {
        public static IEnumerable<Type> FindDerivedTypes(Assembly assembly, Type baseType)
        {
            return assembly.GetTypes().Where(t => baseType.IsAssignableFrom(t));
        }
    }
}
