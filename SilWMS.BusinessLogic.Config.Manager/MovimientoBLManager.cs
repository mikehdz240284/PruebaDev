using SilWMS.BusinessLogic.Config.ManagerContract;
using SilWMS.DataAccess.Config.Manager.BLContract;
using SilWMS.Framework.IoCFactoryDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilWMS.BusinessLogic.Config.Manager
{
    public class MovimientoBLManager : IMovimientoBLManager
    {
        /// <summary>
        /// Metodo que busca la informacion general de movimientos del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        public DataTable BuscaInfoEmpleado(int idNumEmpleado)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IMovimientoManager>();
            return manager.BuscaInfoEmpleado(idNumEmpleado).Tables[0];
        }

        /// <summary>
        /// Metodo que guarda la informacion general de movimientos del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        public DataTable GrabaMovimiento(int idNumEmpleado, int idNumMes, int cantHoras, int cantRepartos)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IMovimientoManager>();
            manager.GrabaMovimiento(idNumEmpleado,idNumMes,cantHoras,cantRepartos);
            return BuscaInfoEmpleado(idNumEmpleado);
        }

        /// <summary>
        /// Metodo que elimina la informacion de movimientos del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        public DataTable EliminaMovimiento(int idNumEmpleado, int idNumMes)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IMovimientoManager>();
            manager.EliminaMovimiento(idNumEmpleado, idNumMes);
            return BuscaInfoEmpleado(idNumEmpleado);
        }

        /// <summary>
        /// Metodo que genera el reporte de pago de empleados
        /// </summary>    
        /// <returns></returns>
        public DataTable Reporte()
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IMovimientoManager>();
            return manager.Reporte().Tables[0];
        }
    }
}
