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
    public class MovimientoManager : GenericRepository<Movimiento>, IMovimientoManager
    {
        /// <summary>
        /// Metodo que busca la informacion general del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        public DataSet BuscaInfoEmpleado(int idNumEmpleado)
        {
            ResetParameters();
            AddParameter("S");
            AddParameter(idNumEmpleado);
            return ExecuteWithStoreProcedure("Movimientos");
        }

        /// <summary>
        /// Metodo que guarda la informacion general del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        public DataSet GrabaMovimiento(int idNumEmpleado, int idNumMes, int cantHoras, int cantRepartos)
        {
            ResetParameters();
            AddParameter("I");
            AddParameter(idNumEmpleado);
            AddParameter(idNumMes);
            AddParameter(cantRepartos);
            AddParameter(cantHoras);
            return ExecuteWithStoreProcedure("Movimientos");
        }

        /// <summary>
        /// Metodo que elimina la informacion de movimientos del empleado
        /// </summary>
        /// <param name="idNumEmpleado"></param>
        /// <returns></returns>
        public void EliminaMovimiento(int idNumEmpleado, int idNumMes)
        {
            ResetParameters();
            AddParameter("D");
            AddParameter(idNumEmpleado);
            AddParameter(idNumMes);            
            ExecuteWithStoreProcedure("Movimientos");
        }

        /// <summary>
        /// Metodo que genera el reporte de pago
        /// </summary>
        /// <returns></returns>
        public DataSet Reporte()
        {
            ResetParameters();            
            return ExecuteWithStoreProcedure("CalculoSueldoMensualEmpleado");
        }
    }
}
