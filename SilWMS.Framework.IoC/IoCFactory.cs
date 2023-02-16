using System;
using SilWMS.Framework.IoC.Containers;

namespace SilWMS.Framework.IoC
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class IoCFactory
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //private static readonly Lazy<IoCFactory> lazy = new Lazy<IoCFactory>(() => new IoCFactory());

        ///// <summary>
        ///// 
        ///// </summary>
        //public static IoCFactory Instance
        //{
        //    get
        //    {
        //        return lazy.Value;
        //    }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //private IoCFactory()
        //{

        //}

        //object containerLock = new object();
        //object childContainerLock = new object();
        //IContainerAdapter _datAccessContainer;
        //IContainerAdapter _domainContainer;
        //IChildContainerAdapter _childDataAccessContainer;
        //IChildContainerAdapter _childDomainContainer;

        ///// <summary>
        ///// 
        ///// </summary>
        //public IContainerAdapter DatAccessContainer
        //{
        //    get
        //    {
        //        if(_datAccessContainer == null)
        //        {
        //            lock(containerLock)
        //            {
        //                _datAccessContainer = new UnityContainerAdapter();
        //                _datAccessContainer.Prepare();
        //            }
        //        }
        //        return _datAccessContainer;
        //    }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public IContainerAdapter DomainContainer
        //{
        //    get
        //    {
        //        if (_domainContainer == null)
        //        {
        //            lock (containerLock)
        //            {
        //                _domainContainer = new UnityContainerAdapter();
        //                _domainContainer.Prepare();
        //            }
        //        }
        //        return _domainContainer;
        //    }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public IChildContainerAdapter ChildDataAccessContainer
        //{
        //    get
        //    {
        //        if (_childDataAccessContainer == null)
        //        {
        //            lock (childContainerLock)
        //            {
        //                _childDataAccessContainer = DatAccessContainer.CreateChildContainerAdapter();
        //                _childDataAccessContainer.PrepareByConvention("ERP.DataAccess", AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
        //            }
        //        }
        //        return _childDataAccessContainer;
        //    }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public IChildContainerAdapter ChildDomainContainer
        //{
        //    get
        //    {
        //        if (_childDomainContainer == null)
        //        {
        //            lock (childContainerLock)
        //            {
        //                _childDomainContainer = DomainContainer.CreateChildContainerAdapter();
        //                _childDomainContainer.PrepareByConvention("ERP.Domain", AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
        //            }
        //        }
        //        return _childDomainContainer;
        //    }
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        //public IChildContainerAdapter DataAccessContainerWeb
        //{
        //    get
        //    {
        //        if (_childDataAccessContainer == null)
        //        {
        //            lock (childContainerLock)
        //            {
        //                _childDataAccessContainer = DatAccessContainer.CreateChildContainerAdapter();
        //                _childDataAccessContainer.PrepareByConvention("ERP.DataAccess", AppDomain.CurrentDomain.SetupInformation.ShadowCopyDirectories);
        //            }
        //        }
        //        return _childDataAccessContainer;
        //    }
        //}
    }
}
