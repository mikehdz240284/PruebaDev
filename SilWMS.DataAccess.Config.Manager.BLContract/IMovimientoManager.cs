using Persistence.Config;
using SilWMS.Framework.IBaseManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilWMS.DataAccess.Config.Manager.BLContract
{
    public interface IMovimientoManager : IRepository<Movimiento>
    {
        /// <summary>
        /// Metodo que busca la informacion general del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        DataSet BuscaInfoEmpleado(int idNumEmpleado);

        /// <summary>
        /// Metodo que guarda la informacion general del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        DataSet GrabaMovimiento(int idNumEmpleado, int idNumMes, int cantHoras, int cantRepartos);

        /// <summary>
        /// Metodo que elimina la informacion de movimientos del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        void EliminaMovimiento(int idNumEmpleado, int idNumMes);

        /// <summary>
        /// Metodo que genera el reporte de pago
        /// </summary>
        /// <returns></returns>
        DataSet Reporte();
    }
}
