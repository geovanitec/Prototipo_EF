using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorMovimiento;

namespace CapaVistaMoviemiento
{
    public partial class frmCuenta : Form
    {

        ClaseControlador co = new ClaseControlador();
        public frmCuenta()
        {
            InitializeComponent();
            
            txtIdCuenta.Text = "";
            txtNombre.Text = "";
            txtEstado.Text = "";
            co.LLenarTablaCuenta(dgvCuenta);
        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            co.insertarCuentaC(txtIdCuenta,txtNombre,txtEstado,dgvCuenta);
        }

        public void funSeleccionarDT(DataGridView data)
        {
            var filaSeleccionada = data.CurrentRow;
            int i = 0;
            TextBox[] arreglo = { txtIdCuenta, txtNombre, txtEstado };
            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    arreglo[i].Text = celda.Value.ToString();
                    i++;
                }

            }
        }

        private void dgvCuenta_SelectionChanged(object sender, EventArgs e)
        {
            funSeleccionarDT(dgvCuenta);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            co.modificarCuentaC(txtIdCuenta, txtNombre, txtEstado, dgvCuenta);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            co.buscarTxtCo(dgvCuenta, txtIdCuenta, txtNombre, txtEstado,txtBuscar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            co.EliminarC(txtIdCuenta,txtNombre,txtEstado,dgvCuenta);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteCuentas abrir = new ReporteCuentas();
            abrir.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/geova/Escritorio/Ayudas/help.chm", "Ayuda-Cuenta-Contable.html");
        }
    }
}
