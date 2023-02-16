using System;
using Microsoft.Practices.Unity;

namespace SilWMS.Framework.IoC.Containers
{
    /// <summary>
    /// 
    /// </summary>
    class UnityChildContainerAdapter : IChildContainerAdapter
    {
        private IUnityContainer childContainer;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="childContainer"></param>
        public UnityChildContainerAdapter(IUnityContainer childContainer)
        {
            this.childContainer = childContainer;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Prepare()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            childContainer.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assemblyNameLoad"></param>
        /// <param name="assemblyPath"></param>
        public void PrepareByConvention(string assemblyNameLoad, string assemblyPath)
        {
            childContainer.RegisterAssemblyTypes(assemblyNameLoad, assemblyPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resolveType"></param>
        /// <returns></returns>
        public object Resolve(Type resolveType) => childContainer.Resolve(resolveType);

        /// <summary>
        /// 
        /// </summary>
        public T Resolve<T>() => childContainer.Resolve<T>();
    }
}
