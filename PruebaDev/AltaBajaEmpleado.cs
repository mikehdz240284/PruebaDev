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
    public partial class AltaBajaEmpleado : Form
    {
        public string NombreVentana { get; set; }
        public string TextoControl { get; set; }
        public int IdNumEmpleado { get; set; }
        public AltaBajaEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaBajaEmpleado_Load(object sender, EventArgs e)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IRolBLManager>();

            cboRol.DataSource = manager.ObtieneLista();
            cboRol.DisplayMember = "Nombre";
            cboRol.ValueMember = "Id_Num_Rol";

            cboRol.SelectedIndex = 0; 

            this.Text = NombreVentana;
            btnAction.Text = TextoControl;

            if(TextoControl == "Modificar")
            {
                var empleadoManager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IEmpleadoBLManager>();
                var empleadoInfo = empleadoManager.BuscaEmpleados(IdNumEmpleado, string.Empty, string.Empty, 0);

                txtNombre.Text = empleadoInfo.Rows[0]["NombreEmpleado"].ToString();
                txtNumeroEmpleado.Text = empleadoInfo.Rows[0]["NumeroEmpleado"].ToString();
                cboRol.DisplayMember = empleadoInfo.Rows[0]["NombreRol"].ToString();
                lblIdNumEmpleado.Text = empleadoInfo.Rows[0]["Id_Num_Empleado"].ToString();
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if(!Valida())
                return;

            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IEmpleadoBLManager>();
            if(TextoControl == "Agregar")
                manager.InsertaEmpleado(txtNombre.Text.Trim(), txtNumeroEmpleado.Text.Trim(), (int)cboRol.SelectedValue);

            if (TextoControl == "Modificar")
            {

                manager.ModificarEmpleados(Int32.Parse( lblIdNumEmpleado.Text), txtNombre.Text.Trim(), txtNumeroEmpleado.Text.Trim(), (int)cboRol.SelectedValue);
            }
            this.Close();
        }

        private bool Valida()
        {
            if(cboRol.SelectedValue == null || (int)cboRol.SelectedValue == 0)
            {
                MessageBox.Show("Seleccione un Rol");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Ingrese el nombre del empleado");
                return false;
            }

            if (string.IsNullOrEmpty(txtNumeroEmpleado.Text.Trim()))
            {
                MessageBox.Show("Ingrese el numero del empleado");
                return false;
            }

            return true;
        }
    }
}
