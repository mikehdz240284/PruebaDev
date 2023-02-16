using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace SilWMS.Framework.EntityBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [DataContract]
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        /// <summary>
        /// Id de la entidad
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataMember]
        public virtual T Id { get; set; }
    }
}
