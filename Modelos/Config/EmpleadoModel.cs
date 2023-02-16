using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Config
{
    public class EmpleadoModel
    {
        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Numero de Empleado
        /// </summary>
        public string NumeroEmpleado { get; set; }
        /// <summary>
        /// Id del Rol
        /// </summary>
        public int Id_Num_Rol { get; set; }
        /// <summary>
        /// Nombre del rol
        /// </summary>
        public string NombreRol { get; set; }
    }
}
