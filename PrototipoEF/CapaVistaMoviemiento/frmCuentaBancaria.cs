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
    public partial class frmCuentaBancaria : Form
    {
        ClaseControlador co = new ClaseControlador();
        public frmCuentaBancaria()
        {
            InitializeComponent();
            co.LLenarTablaCuentaBan(dgvCuentaB);
        }

        private void btnInsertarB_Click(object sender, EventArgs e)
        {
            co.insertarCuentaBan(txtIdCuentaB,txtNombreB,txtEstadoB,dgvCuentaB);
        }

        private void btnModificarB_Click(object sender, EventArgs e)
        {
            co.modificarCuentaBan(txtIdCuentaB,txtNombreB,txtEstadoB,dgvCuentaB);
        }

        private void btnBuscarB_Click(object sender, EventArgs e)
        {
            co.buscarTxtBan(dgvCuentaB,txtIdCuentaB,txtNombreB,txtEstadoB,txtBuscarB);
        }

        private void btnEliminarB_Click(object sender, EventArgs e)
        {
            co.EliminarBancaria(txtIdCuentaB,txtNombreB,txtEstadoB,dgvCuentaB);
        }

        public void funSeleccionarDT(DataGridView data)
        {
            var filaSeleccionada = data.CurrentRow;
            int i = 0;
            TextBox[] arreglo = { txtIdCuentaB, txtNombreB, txtEstadoB };
            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    arreglo[i].Text = celda.Value.ToString();
                    i++;
                }

            }
        }
        private void frmCuentaBancaria_Load(object sender, EventArgs e)
        {

        }

        private void dgvCuentaB_SelectionChanged(object sender, EventArgs e)
        {
            funSeleccionarDT(dgvCuentaB);
        }

        private void btnAyudaB_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/geova/Escritorio/Ayudas/help.chm", "Ayuda-Cuenta-Contable.html");
        }

        private void btnReporteB_Click(object sender, EventArgs e)
        {
            frmReporteBancario abrir = new frmReporteBancario();
            abrir.Show();
        }
    }
}
