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
    public class EmpleadoBLManager : IEmpleadoBLManager
    {
        public DataTable BuscaEmpleados(int idNumEmpleado, string nombre, string numeroEmpleado, int idNumRol)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IEmpleadoManager>();
            return manager.BuscaEmpleados(idNumEmpleado, nombre, numeroEmpleado, idNumRol).Tables[0];
        }

        public void InsertaEmpleado(string nombre, string numeroEmpleado, int idNumRol)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IEmpleadoManager>();
            manager.InsertaEmpleado(nombre, numeroEmpleado, idNumRol);
        }

        // <summary>
        /// Metodo que modifica a los empleados
        /// </summary>
        /// <returns></returns>
        public void ModificarEmpleados(int idNumEmpleado, string nombre, string numeroEmpleado, int idNumRol)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IEmpleadoManager>();
            manager.ModificarEmpleados(idNumEmpleado, nombre, numeroEmpleado, idNumRol);
        }

        /// <summary>
        /// Metodo para eliminar registros
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        public void EliminarEmpleados(int idNumEmpleado)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IEmpleadoManager>();
            manager.EliminarEmpleados(idNumEmpleado);
        }
    }
}
