using System;

namespace SilWMS.Framework.IoC
{
    /// <summary>
    /// 
    /// </summary>
    public interface IContainerAdapter : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        string Version { get; }

        /// <summary>
        /// 
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        string PackageName { get; }

        /// <summary>
        /// 
        /// </summary>
        string Url { get; }

        /// <summary>
        /// 
        /// </summary>
        bool SupportsConditional { get; }

        /// <summary>
        /// 
        /// </summary>
        bool SupportGeneric { get; }

        /// <summary>
        /// 
        /// </summary>
        bool SupportsMultiple { get; }

        /// <summary>
        /// 
        /// </summary>
        bool SupportsInterception { get; }

        /// <summary>
        /// 
        /// </summary>
        bool SupportsPropertyInjection { get; }

        /// <summary>
        /// 
        /// </summary>
        bool SupportsChildContainer { get; }

        /// <summary>
        /// 
        /// </summary>
        bool SupportAspNetCore { get; }

        /// <summary>
        /// 
        /// </summary>
        void PrepareBasic();

        /// <summary>
        /// 
        /// </summary>
        void Prepare();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        object Resolve(Type type);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Resolve<T>();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IChildContainerAdapter CreateChildContainerAdapter();
    }
}
