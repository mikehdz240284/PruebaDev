using SilWMS.Framework.EntityBase;

namespace Persistence.Config
{
    public class Mes : Entity<int>
    {
        /// <summary>
        /// Nombre del Mes
        /// </summary>
        public virtual string Nombre { get; set; }

    }
}
