using System;

namespace SilWMS.Framework.EntityBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UpdatedBy { get; set; }
    }
}
