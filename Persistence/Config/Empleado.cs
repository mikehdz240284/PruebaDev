using SilWMS.Framework.EntityBase;

namespace Persistence.Config
{
    public class Empleado : Entity<int>
    {
        /// <summary>
        /// Nombre del empleado
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Numero del empleado
        /// </summary>
        public string NumeroEmpleado { get; set; }
        /// <summary>
        /// Id del rol del empleado
        /// </summary>
        public int Id_Num_Rol { get; set; }
        /// <summary>
        /// Nombre del rol del empleado
        /// </summary>
        public string NombreRol { get; set; }
    }
}
