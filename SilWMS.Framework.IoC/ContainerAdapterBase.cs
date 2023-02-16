using System;
using System.Linq;
using System.Xml.Linq;

namespace SilWMS.Framework.IoC
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ContainerAdapterBase : IContainerAdapter
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string Name => PackageName;

        /// <summary>
        /// 
        /// </summary>
        public abstract string PackageName { get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Version => XDocument
            .Load("packages.config").Root.Elements()
            .First(x => x.Attribute("id").Value == this.PackageName)
            .Attribute("version").Value;

        /// <summary>
        /// 
        /// </summary>
        public abstract string Url { get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool SupportsInterception => false;

        /// <summary>
        /// 
        /// </summary>
        public virtual bool SupportsPropertyInjection => false;

        /// <summary>
        /// 
        /// </summary>
        public virtual bool SupportsChildContainer => false;

        /// <summary>
        /// 
        /// </summary>
        public virtual bool SupportAspNetCore => false;

        /// <summary>
        /// 
        /// </summary>
        public virtual bool SupportsConditional => false;

        /// <summary>
        /// 
        /// </summary>
        public virtual bool SupportGeneric => false;

        /// <summary>
        /// 
        /// </summary>
        public virtual bool SupportsMultiple => false;

        /// <summary>
        /// 
        /// </summary>
        public virtual bool SupportsBasic
        {
            get { return true; }
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract void PrepareBasic();

        /// <summary>
        /// 
        /// </summary>
        public virtual void Prepare()
        {
            PrepareBasic();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public abstract object Resolve(Type type);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public abstract T Resolve<T>();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IChildContainerAdapter CreateChildContainerAdapter()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract void Dispose();
    }
}
