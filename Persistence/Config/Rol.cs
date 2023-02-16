using SilWMS.Framework.EntityBase;

namespace Persistence.Config
{
    /// <summary>
    /// Entidad Rol
    /// </summary>
    public class Rol : Entity<int>
    {
        /// <summary>
        /// Nombre del Rol
        /// </summary>
        public virtual string Nombre { get; set; }

    }
}
