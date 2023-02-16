using System;
using Microsoft.Practices.Unity;

namespace SilWMS.Framework.IoC
{
    /// <summary>
    /// 
    /// </summary>
    public interface IChildContainerAdapter : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="assemblyNameLoad"></param>
        /// <param name="assemblyPath"></param>
        void PrepareByConvention(string assemblyNameLoad, string assemblyPath);

        /// <summary>
        /// 
        /// </summary>
        void Prepare();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resolveType"></param>
        /// <returns></returns>
        object Resolve(Type resolveType);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Resolve<T>();
    }
}
