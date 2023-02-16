using SilWMS.Framework.MVVM;

namespace SilWMS.Framework.ModelBase
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Model : BaseModel
    {
        private int _id;
        private string _name;
        private string _code;
        private string _description;
        private bool _activated;
        private bool _deleted;

        /// <summary>
        /// Identificador
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(() => Id);
            }
        }

        /// <summary>
        /// Nombre
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(() => Name);
            }
        }

        /// <summary>
        /// Codigo
        /// </summary>
        public string Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged(() => Code);
            }
        }

        /// <summary>
        /// Descripcion
        /// </summary>
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(() => Description);
            }
        }

        /// <summary>
        /// Determina si esta Activo
        /// </summary>
        public bool Activated
        {
            get { return _activated; }
            set
            {
                _activated = value;
                OnPropertyChanged(() => Activated);
            }
        }

        /// <summary>
        /// Determina si esta Eliminado
        /// </summary>
        public bool Deleted
        {
            get { return _deleted; }
            set
            {
                _deleted = value;
                OnPropertyChanged(() => Deleted);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Model()
        {
            _id = 0;
            _name = string.Empty;
            _code = string.Empty;
            _description = string.Empty;
            _activated = false;
            _deleted = false;
        }
    }
}
