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
    public partial class Movimietos : Form
    {
        /// <summary>
        /// Variable para cargar la informacion del empleado
        /// </summary>
        public int IdNumEmpleado { get; set; }
        public Movimietos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Movimietos_Load(object sender, EventArgs e)
        {            
            var mesManager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IMesBLManager>();

            cboMes.DataSource = mesManager.ObtieneLista();
            cboMes.DisplayMember = "Nombre";
            cboMes.ValueMember = "Id_Num_Mes";


            var empleadoManager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IEmpleadoBLManager>();
            var empleadoInfo = empleadoManager.BuscaEmpleados(IdNumEmpleado, string.Empty, string.Empty, 0);

            txtNombre.Text = empleadoInfo.Rows[0]["NombreEmpleado"].ToString();
            txtNumeroEmpleado.Text = empleadoInfo.Rows[0]["NumeroEmpleado"].ToString();
            txtRol.Text = empleadoInfo.Rows[0]["NombreRol"].ToString();

            ActualizaGrid();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!Valida())
                return;

            var movimientoManager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IMovimientoBLManager>();
            movimientoManager.GrabaMovimiento(IdNumEmpleado, (int)cboMes.SelectedValue, Int32.Parse(txtCantHoras.Text.Trim()), Int32.Parse(txtCantEntregas.Text.Trim()));
            ActualizaGrid();
        }

        private void ActualizaGrid()
        {
            var movimientoManager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IMovimientoBLManager>();
            gridEmpleado.DataSource = movimientoManager.BuscaInfoEmpleado(IdNumEmpleado);
        }

        private bool Valida()
        {
            if((int)cboMes.SelectedValue == 0)
            {
                MessageBox.Show("Seleccione el mes");
                return false;
            }

            if(txtCantHoras.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione el mes");
                return false;
            }

            if (Int32.Parse(txtCantHoras.Text.ToString()) > 192)
            {
                MessageBox.Show("Las horas maximas al mes son 192");
                return false;
            }

            if (string.IsNullOrEmpty(txtCantHoras.Text.Trim()))
            {
                MessageBox.Show("Ingrese la cantidad de entregas");
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            if ((int)cboMes.SelectedValue == 0)
            {
                MessageBox.Show("Seleccione el mes");
                return;
            }

            var movimientoManager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IMovimientoBLManager>();
            movimientoManager.EliminaMovimiento(IdNumEmpleado, (int)cboMes.SelectedValue);
            ActualizaGrid();
        }        
    }
}
