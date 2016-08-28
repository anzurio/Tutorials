using System.Configuration;
using System.Reflection;
using System;

namespace Inverter
{
    /// <summary>
    /// The Dependency Injector
    /// </summary>
    public class Injector
    {
        /// <summary>
        /// This method uses this application's current settings to know exactly which dependencies to load.
        /// </summary>
        /// <returns>The "right" driver for this application's context.</returns>
        public static IDriver GetDriver()
        {
            string assembly = ConfigurationManager.AppSettings["assembly"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            return GetDriverUsingReflection(assembly, connectionString);
        }

        /// <summary>
        /// This method uses reflection to load a class within a library. Any dependencies of such library
        /// must be reachable as well. I.e., if the library to be loaded depends on another, that other one
        /// must be either in the same folder or in the Global Cache.
        /// </summary>
        /// <param name="assembly">The absolute path of the library to be loaded.</param>
        /// <param name="connectionString">The connection string.</param>
        /// <returns>The Driver that is used to access this application's appropriate data model.</returns>
        private static IDriver GetDriverUsingReflection(string assembly, string connectionString)
        {
            // Please note this is not the best way to load an assembly and use reflection.
            Assembly asm = Assembly.LoadFile(assembly);
            
            Type[] types = asm.GetTypes();
            Type type = null;
            for (int i = 0; i < types.Length; i++)
            {
                if (types[i].Name.Contains("Driver"))
                {
                    type = types[i];
                    break;
                }
            }

            ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });

            return (IDriver)ctor.Invoke(new string[] { connectionString });
        }
    }
}
