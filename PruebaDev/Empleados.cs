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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IRolBLManager>();

            cboRol.DataSource = manager.ObtieneLista();
            cboRol.DisplayMember = "Nombre";
            cboRol.ValueMember = "Id_Num_Rol";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IEmpleadoBLManager>();
            
            gridEmpleado.DataSource = manager.BuscaEmpleados(0, txtNombre.Text.Trim(), txtNumeroEmpleado.Text.Trim(), (int)cboRol.SelectedValue);

            txtNombre.Text = string.Empty;
            txtNumeroEmpleado.Text = string.Empty;
            cboRol.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var altaBajaEmpleado = new AltaBajaEmpleado();
            altaBajaEmpleado.NombreVentana = "Agrega Empleado";
            altaBajaEmpleado.TextoControl = "Agregar";

            altaBajaEmpleado.ShowDialog();
            BuscarLiempiar();            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var idNumEmpleado = IdNumEmpleadoSeleccionado();

            if (idNumEmpleado == 0)
                return;

            var altaBajaEmpleado = new AltaBajaEmpleado();
            altaBajaEmpleado.NombreVentana = "Modificar Empleado";
            altaBajaEmpleado.TextoControl = "Modificar";
            altaBajaEmpleado.IdNumEmpleado = idNumEmpleado;

            altaBajaEmpleado.ShowDialog();
            BuscarLiempiar();
        }

        private void BuscarLiempiar()
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IEmpleadoBLManager>();
            gridEmpleado.DataSource = manager.BuscaEmpleados(0, string.Empty, string.Empty, 0);

            txtNombre.Text = string.Empty;
            txtNumeroEmpleado.Text = string.Empty;
            cboRol.SelectedIndex = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var manager = IoCFactoryDataAccess.Instance.ChildDataAccessContainer.Resolve<IEmpleadoBLManager>();
            //if (gridEmpleado.SelectedCells.Count == 0 || gridEmpleado.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Debe seleccionar un empleado");
            //    return;
            //}

            //var row = gridEmpleado.CurrentCell.RowIndex;
            var idNumEmpleado = IdNumEmpleadoSeleccionado();

            if (idNumEmpleado == 0)
                return;

            manager.EliminarEmpleados(idNumEmpleado);
            BuscarLiempiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var movimientoForm = new Movimietos();
            movimientoForm.IdNumEmpleado = IdNumEmpleadoSeleccionado();
            if (movimientoForm.IdNumEmpleado == 0)
                return;
            movimientoForm.ShowDialog();

        }

        /// <summary>
        /// Metodo que retorna el identificar del empleado seleccionado en el Grid
        /// </summary>
        /// <returns></returns>
        private int IdNumEmpleadoSeleccionado()
        {
            if (gridEmpleado.SelectedCells.Count == 0 || gridEmpleado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un empleado");
                return 0;
            }
            var row = gridEmpleado.CurrentCell.RowIndex;
            var idNumEmpleado = (int)gridEmpleado.Rows[row].Cells[0].Value;

            return idNumEmpleado;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            var reporte = new Reporte();
            reporte.ShowDialog();
        }
    }
}
