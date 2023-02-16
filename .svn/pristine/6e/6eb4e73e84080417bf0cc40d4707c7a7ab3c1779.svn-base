using System;
using Microsoft.Practices.Unity;

namespace SilWMS.Framework.IoC.Containers
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class UnityContainerAdapter : ContainerAdapterBase
    {
        private UnityContainer container;

        /// <summary>
        /// 
        /// </summary>
        public override string PackageName => "Unity";

        /// <summary>
        /// 
        /// </summary>
        public override string Url => "http://msdn.microsoft.com/unity";

        /// <summary>
        /// 
        /// </summary>
        public override bool SupportsInterception => true;

        /// <summary>
        /// 
        /// </summary>
        public override bool SupportsMultiple => true;

        /// <summary>
        /// 
        /// </summary>
        public override bool SupportsPropertyInjection => true;

        /// <summary>
        /// 
        /// </summary>
        public override bool SupportsChildContainer => true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public override object Resolve(Type type) => container.Resolve(type);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public override T Resolve<T>() => container.Resolve<T>();

        /// <summary>
        /// 
        /// </summary>
        public override void Dispose()
        {
            if (container == null)
            {
                return;
            }
            container.Dispose();
            container = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IChildContainerAdapter CreateChildContainerAdapter() => new UnityChildContainerAdapter(container.CreateChildContainer());

        /// <summary>
        /// 
        /// </summary>
        public override void Prepare()
        {
            container = new UnityContainer();
        }

        /// <summary>
        /// 
        /// </summary>
        public override void PrepareBasic()
        {
            container = new UnityContainer();
        }
    }
}
