using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilWMS.BusinessLogic.Config.ManagerContract
{
    public interface IMovimientoBLManager
    {
        /// <summary>
        /// Metodo que busca la informacion general de movimientos del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        DataTable BuscaInfoEmpleado(int idNumEmpleado);

        /// <summary>
        /// Metodo que guarda la informacion general de movimientos del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        DataTable GrabaMovimiento(int idNumEmpleado, int idNumMes, int cantHoras, int cantRepartos);

        /// <summary>
        /// Metodo que elimina la informacion de movimientos del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        DataTable EliminaMovimiento(int idNumEmpleado, int idNumMes);

        /// <summary>
        /// Metodo que genera el reporte de pago de empleados
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        DataTable Reporte();
    }
}
