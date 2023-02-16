using Modelos.Config;
using SilWMS.DataAccess.Config.Manager.BLContract;
using SilWMS.Framework.IoCFactoryDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SilWMS.ServiceContract.Config
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RolContract" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RolContract.svc o RolContract.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RolContract : IRolContract
    {
        
        /// <summary>
        /// Guardar permisos configurados del rol de usuario
        /// </summary>
        /// <param name="Id_Rol">Identificador del Rol</param>
        /// <param name="xmlOpciones">Configuracion de las Opciones</param>
        /// <param name="UserId">Identificador del Usuario</param>
        public void GuardarPermisos(int Id_Rol, string xmlOpciones, int UserId)
        {
            var manager = IoCFactoryDataAccess.Instance.DataAccessContainerWeb.Resolve<IRolManager>();
            manager.GuardarPermisos(Id_Rol, xmlOpciones, UserId);
        }

        /// <summary>
        /// Insert Masivos
        /// </summary>
        /// <param name="rolModels"></param>
        public void BulkInsertRol(List<RolModel> rolModels)
        {
            var manager = IoCFactoryDataAccess.Instance.DataAccessContainerWeb.Resolve<IRolManager>();
            manager.BulkInsert(rolModels);
        }
    }
}
