using Modelos.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SilWMS.Service.Config
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRolContract" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRolContract
    {
        /// <summary>
        /// Guardar permisos configurados del rol de usuario
        /// </summary>
        /// <param name="Id_Rol">Identificador del Rol</param>
        /// <param name="xmlOpciones">Configuracion de las Opciones</param>
        /// <param name="UserId">Identificador del Usuario</param>
        [OperationContract]
        void GuardarPermisos(int Id_Rol, string xmlOpciones, int UserId);

        /// <summary>
        /// Insert Masivos
        /// </summary>
        /// <param name="rolModels"></param>
        [OperationContract]
        void BulkInsertRol(List<RolModel> rolModels);
    }
}
