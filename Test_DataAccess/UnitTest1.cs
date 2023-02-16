using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence.Config;
using SilWMS.BusinessLogic.Config.ManagerContract;
using SilWMS.Framework.IoCFactoryDataAccess;

namespace Test_DataAccess
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Insert()
        {
            //var entity = new Plaza
            //{
            //    Id = 2,
            //    Nom_Plaza = "prueba2",
            //    Abrev_Plaza = "prueba2",
            //    UserId = 1,
            //    Date_Mov = DateTime.Now
            //};

            //var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IPlazaManager>();

            //manager.Insert(entity);
        }

        [TestMethod]
        public void GetRoles()
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IRolBLManager>();
            //
            var result = manager.ObtieneLista();
        }

        [TestMethod]
        public void ExecuteSPSinParametros()
        {
            //var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IPlazaManager>();

            //var result = manager.ExecuteWithStoreProcedure("GetPlazas");
        }

        [TestMethod]
        public void ExecuteSPConParametros()
        {
        //    var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IPlazaManager>();

        //    manager.AddParameter(2);
        //    var result = manager.ExecuteWithStoreProcedure("GetPlazas");
        }
    }
}
