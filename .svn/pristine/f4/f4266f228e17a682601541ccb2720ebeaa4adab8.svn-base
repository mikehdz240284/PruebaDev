using SilWMS.Framework.IoC;
using SilWMS.Framework.IoC.Containers;
using System;

namespace SilWMS.Framework.IoCFactoryDataAccess
{
    /// <summary>
    /// Inyector de Dependencias para las librerias DataAccess 
    /// </summary>
    public sealed class IoCFactoryDataAccess
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly Lazy<IoCFactoryDataAccess> lazy = new Lazy<IoCFactoryDataAccess>(() => new IoCFactoryDataAccess());

        /// <summary>
        /// 
        /// </summary>
        public static IoCFactoryDataAccess Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private IoCFactoryDataAccess()
        {

        }

        object containerLock = new object();
        object childContainerLock = new object();
        IContainerAdapter _datAccessContainer;
        IChildContainerAdapter _childDataAccessContainer;


        /// <summary>
        /// 
        /// </summary>
        public IContainerAdapter DatAccessContainer
        {
            get
            {
                if (_datAccessContainer == null)
                {
                    lock (containerLock)
                    {

                        _datAccessContainer = new UnityContainerAdapter();
                        _datAccessContainer.Prepare();
                    }
                }
                return _datAccessContainer;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public IChildContainerAdapter ChildDataAccessContainer
        {
            get
            {
                if (_childDataAccessContainer == null)
                {
                    lock (childContainerLock)
                    {
                        _childDataAccessContainer = DatAccessContainer.CreateChildContainerAdapter();
                        _childDataAccessContainer.PrepareByConvention("SilWMS.", AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
                    }
                }
                return _childDataAccessContainer;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public IChildContainerAdapter DataAccessContainerWeb
        {
            get
            {
                if (_childDataAccessContainer == null)
                {
                    lock (childContainerLock)
                    {
                        _childDataAccessContainer = DatAccessContainer.CreateChildContainerAdapter();
                        _childDataAccessContainer.PrepareByConvention("SilWMS.DataAccess", AppDomain.CurrentDomain.SetupInformation.ShadowCopyDirectories);
                        _childDataAccessContainer.PrepareByConvention("SilWMS.BusinessLogic", AppDomain.CurrentDomain.SetupInformation.ShadowCopyDirectories);
                    }
                }
                return _childDataAccessContainer;
            }
        }
    }
}
