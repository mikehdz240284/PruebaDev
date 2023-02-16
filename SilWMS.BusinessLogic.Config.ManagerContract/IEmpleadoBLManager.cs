using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilWMS.BusinessLogic.Config.ManagerContract
{
    public interface IEmpleadoBLManager
    {
        /// <summary>
        /// Metodo que busca los empleados
        /// </summary>
        /// <returns></returns>
        DataTable BuscaEmpleados(int idNumEmpleado, string nombre, string numeroEmpleado, int idNumRol);

        /// <summary>
        /// Metodo que registra el empleado
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="numeroEmpleado">Numero de Empleado</param>
        /// <param name="idNumRol">Id del rol</param>
        void InsertaEmpleado(string nombre, string numeroEmpleado, int idNumRol);

        // <summary>
        /// Metodo que modifica a los empleados
        /// </summary>
        /// <returns></returns>
        void ModificarEmpleados(int idNumEmpleado, string nombre, string numeroEmpleado, int idNumRol);

        /// <summary>
        /// Metodo para eliminar registros
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        void EliminarEmpleados(int idNumEmpleado);
    }
}
