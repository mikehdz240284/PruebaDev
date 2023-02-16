using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace SilWMS.Framework.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class CreateInstance
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly Lazy<CreateInstance> lazy = new Lazy<CreateInstance>(() => new CreateInstance());

        /// <summary>
        /// 
        /// </summary>
        public static CreateInstance Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private CreateInstance()
        {

        }

        /// <summary>
        /// Abre una ventana de las librerias del ERP, 
        /// donde el nombre de la dll comienza con ERP.Windows
        /// </summary>
        /// <param name="namespaceClass">Nombre del espacio de la clase</param>
        /// <param name="windowName">Nombre de la ventana</param>
        public Window ExecuteWindowFromERPWindows(string namespaceClass, string windowName)
        {
            var dir =
           Directory
               .EnumerateFiles(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "*ERP.Windows*")
               .Where(assemblyName => assemblyName.EndsWith("dll"))
               .ToArray();

            var assemblies = (from assemblyName in dir select Assembly.LoadFrom(assemblyName)).ToArray();

            foreach (var currentassembly in assemblies)
            {
                var formtype = currentassembly.GetType(namespaceClass + "." + windowName, false, true);
                if (formtype != null)
                {
                    {
                        Window f = (Window)Activator.CreateInstance(formtype);
                        //f.Show();
                        //break;
                        return f;
                    }
                }
            }
            return null;
        }
    }
}
