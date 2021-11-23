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
    public partial class frmMovimientoBancario : Form
    {
        ClaseControlador co = new ClaseControlador();
        public frmMovimientoBancario()
        {
            InitializeComponent();
            co.funLlenarComboIDCuenta(cbxCuentaContable);
            co.funLlenarComboCBan(cbxCuentaBancaria);
            co.funLlenarComboTCu(cbxTipoCuenta);
            co.funLlenarComboMID(cbxMovimiento);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void funDPTextBox(DateTimePicker date, TextBox textoDate)
        {
           // String dt = "";
//dt = date.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
           // textoDate.Text = dt;

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //funDPTextBox(dateTimePicker1,txtFecha);

        }

        private void frmMovimientoBancario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToString();
            co.insertarMovimientoE(txtIdMovimiento, fecha, txtDocumento,txtConcepto);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            co.insertarD(cbxMovimiento,cbxCuentaContable,cbxCuentaBancaria,cbxTipoCuenta,txtSaldo);
        }
    }
}
