using Modelos.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilWMS.BusinessLogic.Config.ManagerContract
{
    public interface IMesBLManager
    {
        /// <summary>
        /// Metodo que trae los Meses configurados
        /// </summary>
        /// <returns></returns>
        List<MesModel> ObtieneLista();
    }
}
