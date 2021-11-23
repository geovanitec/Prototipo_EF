using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloMovimiento;

namespace CapaModeloMovimiento
{
    public class CapaModelo
    {
     
        /*CODIGO PARA CUENTA*/
        public void insertarCuenta(TextBox id, TextBox nombre, TextBox estado, DataGridView dvg)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

            try
            {
                string cadena = "INSERT INTO cuenta (idCuenta, nombre, estado) " +
                "VALUES ('" + id.Text + "', '" + nombre.Text + "', '" + estado.Text + "'); ";
                OdbcCommand consulta = new OdbcCommand(cadena, con);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Registro Agregado");
            
                LLenarTabla(dvg);
                id.Text = "";
                nombre.Text = "";
                estado.Text = "";
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al insertar " + Error);
            }
            finally
            {
                cn.desconexion(con);
            }
        }


        public void LLenarTabla(DataGridView dvg)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

           
            string sql = "select idCuenta , nombre , estado from cuenta;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con);

            DataTable table = new DataTable();
            dataTable.Fill(table);

            dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg.DataSource = table;

        }

        public void modificarCuenta(TextBox id, TextBox nombre, TextBox estado, DataGridView dvg)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

            try
            {
                string cadena = "UPDATE  cuenta SET  idCuenta = '" + id + "' , nombre = '" + nombre + "', estado= '" + estado + "' WHERE idCuenta = '" + id + "' ";


                OdbcCommand consulta = new OdbcCommand(cadena, con);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Registro Modificado");
                LLenarTabla(dvg);

                id.Text = "";
                nombre.Text = "";
                
                estado.Text = "";
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al MODIFICAR " + Error);
            }
            finally
            {
                cn.desconexion(con);
            }
        }


        public void funSeleccionarDT(DataGridView data, TextBox id, TextBox nombre, TextBox estado)
        {
            var filaSeleccionada = data.CurrentRow;
            int i = 0;
            TextBox[] arreglo = { id, nombre, estado };
            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    arreglo[i].Text = celda.Value.ToString();
                    i++;
                }

            }
        }

        public void buscarTxt(DataGridView data, TextBox id, TextBox nombre,  TextBox estado, TextBox buscar)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

            try
            {
                string cadena = "Select idCuenta='" + buscar + "' from cuenta ";


                OdbcCommand consulta = new OdbcCommand(cadena, con);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Registro Encontrado");
                funSeleccionarDT(data, id, nombre, estado);

                id.Text = "";
                nombre.Text = "";
               
                estado.Text = "";
            }
            catch (Exception Error)
            {
                Console.WriteLine("No se encontro el ID Buscado " + Error);
            }
        }

        public void EliminarCuenta(TextBox idCuenta, TextBox nombre, TextBox estado, DataGridView data)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

            try
            {
                string cadena = "delete  from cuenta where idCuenta = '" + idCuenta + "'";
                OdbcCommand consulta = new OdbcCommand(cadena, con);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Registro Eliminado");

                LLenarTabla(data);
                nombre.Text = "";
                idCuenta.Text = "";
                estado.Text = "";

            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al Eliminar " + Error);
            }
        }

        /*////////////////////////////////////////////////////////Cuenta BANCARIA/////////////////////////////////*/
        public void insertarCuentaBancaria(TextBox id, TextBox nombre, TextBox estado, DataGridView dvg)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

            try
            {
                string cadena = "INSERT INTO cuentaBancaria (idCuentaB, nombre, estado) " +
                "VALUES ('" + id.Text + "', '" + nombre.Text + "', '" + estado.Text + "'); ";
                OdbcCommand consulta = new OdbcCommand(cadena, con);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Registro Agregado");

                LLenarTablaB(dvg);
                id.Text = "";
                nombre.Text = "";
                estado.Text = "";
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al insertar " + Error);
            }
            finally
            {
                cn.desconexion(con);
            }
        }

        public void LLenarTablaB(DataGridView dvg)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();


            string sql = "select idCuentaB , nombre , estado from cuentaBancaria;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con);

            DataTable table = new DataTable();
            dataTable.Fill(table);

            dvg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg.DataSource = table;

        }

        public void modificarCuentaBancaria(TextBox id, TextBox nombre, TextBox estado, DataGridView dvg)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

            try
            {
                string cadena = "UPDATE  cuentaBancaria SET nombre = '" + nombre + "', estado= '" + estado + "' WHERE idCuentaB = '" + id + "' ";


                OdbcCommand consulta = new OdbcCommand(cadena, con);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Registro Modificado");
                LLenarTablaB(dvg);

                id.Text = "";
                nombre.Text = "";

                estado.Text = "";
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al MODIFICAR " + Error);
            }
            finally
            {
                cn.desconexion(con);
            }
        }

        public void funSeleccionarDTBancaria(DataGridView data, TextBox id, TextBox nombre, TextBox estado)
        {
            var filaSeleccionada = data.CurrentRow;
            int i = 0;
            TextBox[] arreglo = { id, nombre, estado };
            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    arreglo[i].Text = celda.Value.ToString();
                    i++;
                }

            }
        }

        public void buscarTxtBancaria(DataGridView data, TextBox id, TextBox nombre, TextBox estado, TextBox buscar)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

            try
            {
                string cadena = "Select idCuentaB='" + buscar + "' from cuentaBancaria ";


                OdbcCommand consulta = new OdbcCommand(cadena, con);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Registro Encontrado");
                funSeleccionarDTBancaria(data, id, nombre, estado);

                id.Text = "";
                nombre.Text = "";

                estado.Text = "";
            }
            catch (Exception Error)
            {
                Console.WriteLine("No se encontro el ID Buscado " + Error);
            }
        }

        public void EliminarCuentaBancaria(TextBox idCuenta, TextBox nombre, TextBox estado, DataGridView data)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

            try
            {
                string cadena = "delete  from cuentaBancaria where idCuentaB = '" + idCuenta + "'";
                OdbcCommand consulta = new OdbcCommand(cadena, con);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Registro Eliminado");

                LLenarTablaB(data);
                nombre.Text = "";
                idCuenta.Text = "";
                estado.Text = "";

            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al Eliminar " + Error);
            }
        }

        ////MOVIMIENTO BANCARIO
        public void insertarMovimiento(TextBox id, string fecha, TextBox documento, TextBox concepto)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

            try
            {
                string cadena = "INSERT INTO movimientoE (idMovimientoE, fecha, documetno,concepto) " +
                "VALUES ('" + id.Text + "', '" + fecha + "', '" + documento.Text + "', '" + concepto.Text + "'); ";
                OdbcCommand consulta = new OdbcCommand(cadena, con);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Registro Agregado");

               
                id.Text = "";
                
                documento.Text = "";
                concepto.Text = "";
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al insertar " + Error);
            }
            finally
            {
                cn.desconexion(con);
            }
        }

        ////////////////////////detalle
        public void funLlenarComboID(ComboBox cbx)
        {
            Conexion con = new Conexion();
            OdbcDataReader leer = null;

            string psql = "SELECT * FROM cuenta WHERE estado='A'";

            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cbx.Items.Add(leer.GetString(1));
                    cbx.ValueMember = leer.GetString(0);
                }

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                con.desconexion(conect);
            }
        }

        ////////cuenta bancaria
        public void funLlenarComboCB(ComboBox cbx)
        {
            Conexion con = new Conexion();
            OdbcDataReader leer = null;

            string psql = "SELECT * FROM cuentaBancaria WHERE estado='A'";

            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cbx.Items.Add(leer.GetString(1));
                    cbx.ValueMember = leer.GetString(0);
                }

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                con.desconexion(conect);
            }
        }

        //////// Tipo Cuenta
        public void funLlenarComboTC(ComboBox cbx)
        {
            Conexion con = new Conexion();
            OdbcDataReader leer = null;

            string psql = "SELECT * FROM tipoCuenta WHERE estado='A'";

            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cbx.Items.Add(leer.GetString(1));
                    cbx.ValueMember = leer.GetString(0);
                }

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                con.desconexion(conect);
            }
        }

        //////// Tipo Cuenta
        public void funLlenarComboM(ComboBox cbx)
        {
            Conexion con = new Conexion();
            OdbcDataReader leer = null;

            string psql = "SELECT * FROM movimientoE WHERE documetno='001'";

            OdbcConnection conect = con.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cbx.Items.Add(leer.GetString(0));
                    cbx.ValueMember = leer.GetString(0);
                }

            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                con.desconexion(conect);
            }
        }

        ////MOVIMIENTO BANCARIO
        public void insertar(ComboBox idMovimientoE, ComboBox idCuenta, ComboBox idCuentaB, ComboBox idTipoCuenta, TextBox saldo)
        {
            Conexion cn = new Conexion();
            OdbcConnection con = cn.conexion();

            try
            {
                string cadena = "INSERT INTO movimientoD (idRecetaE, idCuenta, idCuentaB,idTipoCuenta,saldo) " +
                "VALUES ('" + idMovimientoE.ValueMember + "', '" + idCuenta.ValueMember + "', '" + idCuentaB.ValueMember + "','" + idTipoCuenta.ValueMember + "', '" + saldo.Text + "'); ";
                OdbcCommand consulta = new OdbcCommand(cadena, con);
                consulta.ExecuteNonQuery();

                MessageBox.Show("Registro Agregado");
                // LLenarTablaRecetaDet(data);

                saldo.Text = "";
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error al insertar " + Error);
            }
        }
    }
}
