using Modelos.Config;
using SilWMS.BusinessLogic.Config.ManagerContract;
using SilWMS.DataAccess.Config.Manager.BLContract;
using SilWMS.Framework.IoCFactoryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilWMS.BusinessLogic.Config.Manager
{
    public class MesBLManager : IMesBLManager
    {
        /// <summary>
        /// Metodo que trae los Meses configurados
        /// </summary>
        /// <returns></returns>
        public List<MesModel> ObtieneLista()
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IMesManager>();
            var meses = manager.GetAll().ToList();

            var mesModel = new List<MesModel>();

            mesModel.Add(new MesModel
            {
                Id_Num_Mes = 0,
                Nombre = "-- SELECCIONE --"
            });

            foreach (var rol in meses)
            {
                mesModel.Add(new MesModel
                {
                    Id_Num_Mes = rol.Id,
                    Nombre = rol.Nombre
                });
            }

            return mesModel;
        }
    }
}
