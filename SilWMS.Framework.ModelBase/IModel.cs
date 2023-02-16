namespace SilWMS.Framework.ModelBase
{
    /// <summary>
    /// 
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// Identificador
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Nombre
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Codigo
        /// </summary>
        string Code { get; set; }

        /// <summary>
        /// Descripcion
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Determina si esta Activo
        /// </summary>
        bool Activated { get; set; }

        /// <summary>
        /// Determina si esta Eliminado
        /// </summary>
        bool Deleted { get; set; }
    }
}
