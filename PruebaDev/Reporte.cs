using SilWMS.BusinessLogic.Config.ManagerContract;
using SilWMS.Framework.IoCFactoryDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDev
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            var movimientoManager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IMovimientoBLManager>();
            gridReporte.DataSource = movimientoManager.Reporte();
        }
    }
}
