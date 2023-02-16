using Persistence.Config;
using SilWMS.DataAccess.Config.Manager.BLContract;
using SilWMS.Framework.BaseManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilWMS.DataAccess.Config.Manager.BL.Manager
{
    public class EmpleadoManager : GenericRepository<Empleado>, IEmpleadoManager
    {
        public DataSet BuscaEmpleados(int idNumEmpleado, string nombre, string numeroEmpleado, int idNumRol)
        {
            ResetParameters();
            AddParameter("S");

            if (idNumEmpleado > 0)
                AddParameter(idNumEmpleado);
            else
                AddParameter();

            if (!string.IsNullOrEmpty(nombre))
                AddParameter(nombre);
            else
                AddParameter();
            
            if (!string.IsNullOrEmpty(numeroEmpleado))
                AddParameter(numeroEmpleado);
            else
                AddParameter();

            if (idNumRol > 0)
                AddParameter(idNumRol);
            else
                AddParameter();
            return ExecuteWithStoreProcedure("Empleados");
        }

        public void InsertaEmpleado(string nombre, string numeroEmpleado, int idNumRol)
        {
            ResetParameters();
            AddParameter("I");
            AddParameter();
            AddParameter(nombre);
            AddParameter(numeroEmpleado);
            AddParameter(idNumRol);
            ExecuteWithStoreProcedure("Empleados");
        }

        // <summary>
        /// Metodo que modifica a los empleados
        /// </summary>
        /// <returns></returns>
        public void ModificarEmpleados(int idNumEmpleado, string nombre, string numeroEmpleado, int idNumRol)
        {
            ResetParameters();
            AddParameter("U");
            AddParameter(idNumEmpleado);
            AddParameter(nombre);
            AddParameter(numeroEmpleado);
            AddParameter(idNumRol);
            ExecuteWithStoreProcedure("Empleados");
        }

        /// <summary>
        /// Metodo para eliminar registros
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        public void EliminarEmpleados(int idNumEmpleado)
        {
            ResetParameters();
            AddParameter("D");
            AddParameter(idNumEmpleado);
            ExecuteWithStoreProcedure("Empleados");
        }

    }
}
