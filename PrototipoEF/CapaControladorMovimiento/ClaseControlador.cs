using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloMovimiento;

namespace CapaControladorMovimiento
{
    public class ClaseControlador
    {
        CapaModelo mo = new CapaModelo();

        public void LLenarTablaCuenta(DataGridView dvg)
        {
            mo.LLenarTabla(dvg);
            
        }

        public void insertarCuentaC(TextBox id, TextBox nombre,  TextBox estado, DataGridView dvg)
        {
            mo.insertarCuenta(id, nombre, estado, dvg);
        }

        public void modificarCuentaC(TextBox id, TextBox nombre,TextBox estado, DataGridView dvg)
        {
            mo.modificarCuenta(id, nombre, estado, dvg);
        }

        public void buscarTxtCo(DataGridView data, TextBox id, TextBox nombre, TextBox estado, TextBox buscar)
        {
            mo.buscarTxt(data, id, nombre, estado, buscar);
        }

        public void EliminarC(TextBox idCuenta, TextBox nombre, TextBox estado, DataGridView data)
        {
            mo.EliminarCuenta(idCuenta, nombre, estado, data);
        }

        /*////////////////////////////////////////////////////////Cuenta BANCARIA/////////////////////////////////*/

        public void insertarCuentaBan(TextBox id, TextBox nombre, TextBox estado, DataGridView dvg)
        {
            mo.insertarCuentaBancaria(id, nombre, estado, dvg);
        }

        public void modificarCuentaBan(TextBox id, TextBox nombre, TextBox estado, DataGridView dvg)
        {
            mo.modificarCuentaBancaria(id, nombre, estado, dvg);
        }

        public void LLenarTablaCuentaBan(DataGridView dvg)
        {
            mo.LLenarTablaB(dvg);

        }

        public void buscarTxtBan(DataGridView data, TextBox id, TextBox nombre, TextBox estado, TextBox buscar)
        {
            mo.buscarTxtBancaria(data, id, nombre, estado, buscar);
        }

        public void EliminarBancaria(TextBox idCuenta, TextBox nombre, TextBox estado, DataGridView data)
        {
            mo.EliminarCuentaBancaria(idCuenta, nombre, estado, data);
        }

        /////////////////////movimiento bancario  ////////////////////
       public void insertarMovimientoE(TextBox id, string fecha, TextBox documento, TextBox concepto)
        {
            
            mo.insertarMovimiento(id,fecha,documento,concepto);
        }

        public void funLlenarComboIDCuenta(ComboBox cbx)
        {
            mo.funLlenarComboID(cbx);
        }

        public void funLlenarComboCBan(ComboBox cbx)
        {
            mo.funLlenarComboCB(cbx);
        }

        public void funLlenarComboTCu(ComboBox cbx)
        {
            mo.funLlenarComboTC(cbx);
        }

        public void funLlenarComboMID(ComboBox cbx)
        {
            mo.funLlenarComboM(cbx);
        }

        public void insertarD(ComboBox idMovimientoE, ComboBox idCuenta, ComboBox idCuentaB, ComboBox idTipoCuenta, TextBox saldo)
        {
            mo.insertar(idMovimientoE, idCuenta, idCuentaB, idTipoCuenta, saldo, data);
        }
    }
}
