using SilWMS.Framework.EntityBase;

namespace Persistence.Config
{
    public class Movimiento : Entity<int>
    {
        /// <summary>
        /// Id del empleado
        /// </summary>
        public int Id_Num_Empleado { get; set; }
        /// <summary>
        /// Id del mes
        /// </summary>
        public int Id_Num_Mes { get; set; }
        /// <summary>
        /// Horas trabajadas
        /// </summary>
        public int Horas_Trabajadas { get; set; }
        /// <summary>
        /// Cantidad de entregas
        /// </summary>
        public int Cant_Entrega { get; set; }
    }
}
