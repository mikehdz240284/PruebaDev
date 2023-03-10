using Modelos.Config;
using Persistence.Config;
using SilWMS.BusinessLogic.Config.ManagerContract;
using SilWMS.DataAccess.Config.Manager.BLContract;
using SilWMS.Framework.IoCFactoryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SilWMS.BusinessLogic.Config.Manager
{
    public class RolBLManager : IRolBLManager
    {
        /// <summary>
        /// Metodo que trae los roles configurados
        /// </summary>
        /// <returns></returns>
        public List<RolModel> ObtieneLista()
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IRolManager>();
            var roles = manager.GetAll().ToList();

            var rolModel = new List<RolModel>();

            rolModel.Add(new RolModel
            {
                Id_Num_Rol = 0,
                Nombre = "-- SELECCIONE --"
            });

            foreach (var rol in roles )
            {
                rolModel.Add(new RolModel
                {
                    Id_Num_Rol = rol.Id,
                    Nombre = rol.Nombre
                });
            }

            return rolModel;
        }
    }
}
