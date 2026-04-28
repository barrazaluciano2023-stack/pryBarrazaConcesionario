using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaConcesionario
{
    public partial class frmPrincipal : Form
    {
        private CConexion miConexion;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CConexion objetoConeccionBaseDatos = new CConexion();
            objetoConeccionBaseDatos.ConectarBaseDatos();
            string query = "SELECT * FROM Vehiculo";

            {
                try
                {
                    // 3. Crear DataAdapter y DataTable
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, objetoConeccionBaseDatos.conectorBaseDatos);
                    DataTable dataTable = new DataTable();

                    // 4. Llenar el DataTable
                    adapter.Fill(dataTable);

                    // 5. Asignar datos al DataGridView
                    dgvAutos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dgvAutos.CurrentRow != null)
            {
                // 2. Obtener los datos de las celdas (usa el nombre de la columna o el índice)
                int idSeleccionado = Convert.ToInt32(dgvAutos.CurrentRow.Cells["idVehiculo"].Value);

                // 3. Llamar a tu método de guardado pasando estos datos
                GuardarEnBaseDeDatos(idSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehiculo.");
            }
        }
        public void GuardarEnBaseDeDatos(int id)
        {
            CConexion objetoConeccionBaseDatos = new CConexion();
            objetoConeccionBaseDatos.ConectarBaseDatos();
            string query = "INSERT INTO Reserva (fechaReserva, fechaDevolucion,Seguro,importe,idVehiculo) VALUES (?, ?, ?, ? ,?)";
            string query2 = "INSERT INTO Cliente (nombre,Telefono,Mail,direccion,dni) VALUES (?, ?, ?, ? ,?)";


            using (OleDbCommand cmd2 = new OleDbCommand(query2, objetoConeccionBaseDatos.conectorBaseDatos))
                try
                {

                    cmd2.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd2.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd2.Parameters.AddWithValue("@Mail", txtMail.Text);
                    cmd2.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd2.Parameters.AddWithValue("@dni", txtDni.Text);
                    cmd2.ExecuteNonQuery();
                    
                    using (OleDbCommand cmd = new OleDbCommand(query, objetoConeccionBaseDatos.conectorBaseDatos))
                    {
                        try
                        {

                            cmd.Parameters.AddWithValue("@fechaReserva", txtFechaReserva.Text);
                            cmd.Parameters.AddWithValue("@fechaDevoluicion", txtDevolucion.Text);
                            cmd.Parameters.AddWithValue("@Seguro", txtSeguro.Text);
                            cmd.Parameters.AddWithValue("@importe", txtImporte.Text);
                            cmd.Parameters.AddWithValue("@idVehiculo", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Reserva guardada con éxito");


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al ejecutar comando: " + ex.Message);
                        }
                        // cerrar la conexión al terminar
                        finally
                        {
                            objetoConeccionBaseDatos.conectorBaseDatos.Close();
                        }

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar comando: " + ex.Message);
                }
                // cerrar la conexión al terminar
                finally
                {
                    objetoConeccionBaseDatos.conectorBaseDatos.Close();
                }
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
