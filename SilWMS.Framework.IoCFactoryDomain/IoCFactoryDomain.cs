using SilWMS.Framework.IoC;
using SilWMS.Framework.IoC.Containers;
using System;

namespace SilWMS.Framework.IoCFactoryDomain
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class IoCFactoryDomain
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly Lazy<IoCFactoryDomain> lazy = new Lazy<IoCFactoryDomain>(() => new IoCFactoryDomain());

        /// <summary>
        /// 
        /// </summary>
        public static IoCFactoryDomain Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private IoCFactoryDomain()
        {

        }

        object containerLock = new object();
        object childContainerLock = new object();
        IContainerAdapter _domainContainer;
        IChildContainerAdapter _childDomainContainer;

        /// <summary>
        /// 
        /// </summary>
        public IContainerAdapter DomainContainer
        {
            get
            {
                if (_domainContainer == null)
                {
                    lock (containerLock)
                    {
                        _domainContainer = new UnityContainerAdapter();
                        _domainContainer.Prepare();
                    }
                }
                return _domainContainer;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public IChildContainerAdapter ChildDomainContainer
        {
            get
            {
                if (_childDomainContainer == null)
                {
                    lock (childContainerLock)
                    {
                        _childDomainContainer = DomainContainer.CreateChildContainerAdapter();
                        _childDomainContainer.PrepareByConvention("ERP.Domain", AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
                    }
                }
                return _childDomainContainer;
            }
        }
    }
}
