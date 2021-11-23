using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMoviemiento
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void mANTENIMIENTOCUENTACONTABLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuenta abrir = new frmCuenta();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void mANTENIMIENTOCUENTABANCARIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentaBancaria abrir = new frmCuentaBancaria();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void mOVIMIENTOBANCARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimientoBancario abrir = new frmMovimientoBancario();
            abrir.MdiParent = this;
            abrir.Show();
        }
    }
}
