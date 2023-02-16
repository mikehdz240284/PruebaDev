using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using Microsoft.Practices.Unity;

namespace SilWMS.Framework.IoC.Containers
{
    static class UnityContainerExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unityContainer"></param>
        /// <param name="assemblyNameLoad"></param>
        /// <param name="directoryContainerApplication"></param>
        public static void RegisterAssemblyTypes(this IUnityContainer unityContainer, string assemblyNameLoad, string directoryContainerApplication)
        {
            if (string.IsNullOrEmpty(assemblyNameLoad))
            {
                return;
            }

            var assemblyNames = Directory            
                .EnumerateFiles(directoryContainerApplication, "*" + assemblyNameLoad + "*")
                .Where(assemblyName => assemblyName.Contains("BusinessLogic.Config.ManagerContract.dll") || assemblyName.Contains("BusinessLogic.Config.Manager.dll") 
                    || assemblyName.Contains("DataAccess.Config.Manager.BL.dll") || assemblyName.Contains("DataAccess.Config.Manager.BLContract.dll"))
                .ToArray();

            var assemblies = (from assemblyName in assemblyNames select Assembly.LoadFrom(assemblyName)).ToArray();

            unityContainer.RegisterTypes(
                AllClasses.FromAssemblies(assemblies),
                WithMappings.FromMatchingInterface,
                WithName.Default,
                WithLifetime.ContainerControlled);
        }
    }
}
