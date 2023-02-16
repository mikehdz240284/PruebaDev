using System;

namespace SilWMS.Framework.EntityBase
{
    /// <summary>
    /// Campos de Auditoria
    /// </summary>
    public interface IAuditableEntity
    {
        /// <summary>
        /// Fecha de cración
        /// </summary>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Id de usuario que creo el registro
        /// </summary>
        int CreatedBy { get; set; }

        /// <summary>
        /// Fecha de Actualización
        /// </summary>
        DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Id de usuario que modifico
        /// </summary>
        int UpdatedBy { get; set; }
    }
}
