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

                    string query2 = "SELECT * FROM Cliente";
                    {
                        try
                        {
                            // 3. Crear DataAdapter y DataTable
                            OleDbDataAdapter adapter2 = new OleDbDataAdapter(query2, objetoConeccionBaseDatos.conectorBaseDatos);
                            DataTable dataTable2 = new DataTable();
                            // 4. Llenar el DataTable
                            adapter2.Fill(dataTable2);
                            // 5. Asignar datos al DataGridView
                            dgvClientes.DataSource = dataTable2;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dgvAutos.CurrentRow != null && dgvClientes.CurrentRow != null)
            {
                // 2. Obtener los datos de las celdas (usa el nombre de la columna o el índice)
                int idSelecVehiculo = Convert.ToInt32(dgvAutos.CurrentRow.Cells["idVehiculo"].Value);
                int idSelecCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["idCliente"].Value);

                // 3. Llamar a tu método de guardado pasando estos datos
                GuardarEnBaseDeDatos(idSelecVehiculo , idSelecCliente);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehiculo y cliente.");
            }
        }
        public void GuardarEnBaseDeDatos(int idSelecVehiculo, int idSelecCliente)
        {
            CConexion objetoConeccionBaseDatos = new CConexion();
            objetoConeccionBaseDatos.ConectarBaseDatos();
            string query = "INSERT INTO Reserva (idVehiculo,fechaReserva, fechaDevolucion,Seguro,importe,idCliente) VALUES (?, ?, ?, ? ,?,?)";
            


            using (OleDbCommand cmd = new OleDbCommand(query, objetoConeccionBaseDatos.conectorBaseDatos))
                try
                {
                    cmd.Parameters.AddWithValue("@idVehiculo", idSelecVehiculo);
                    cmd.Parameters.AddWithValue("@fechaReserva", txtFechaReserva.Text);
                    cmd.Parameters.AddWithValue("@fechaDevoluicion", txtDevolucion.Text);
                    cmd.Parameters.AddWithValue("@Seguro", cmbSeguro.Text);
                    cmd.Parameters.AddWithValue("@importe", txtImporte.Text);
                    cmd.Parameters.AddWithValue("@idCliente", idSelecCliente);
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


        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            CConexion objetoConeccionBaseDatos = new CConexion();
            objetoConeccionBaseDatos.ConectarBaseDatos();
            string query2 = "INSERT INTO Cliente (nombre,Telefono,Mail,direccion,dni) VALUES (?, ?, ?, ? ,?)";

            using (OleDbCommand cmd2 = new OleDbCommand(query2, objetoConeccionBaseDatos.conectorBaseDatos))
                try
                {

                    cmd2.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd2.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd2.Parameters.AddWithValue("@Mail", txtMail.Text);
                    cmd2.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd2.Parameters.AddWithValue("@dni", txtDni.Text);
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    txtMail.Text = "";
                    txtDireccion.Text = "";
                    txtDni.Text = "";
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Cliente Registrado con éxito");
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

        private void RegistrarVehiculo_Click(object sender, EventArgs e)
        {

            CConexion objetoConeccionBaseDatos = new CConexion();
            objetoConeccionBaseDatos.ConectarBaseDatos();
            string query2 = "INSERT INTO Vehiculo (Marca,Modelo,año,patente,kilometraje,estado) VALUES (?, ?, ?, ? ,?,?)";

            using (OleDbCommand cmd2 = new OleDbCommand(query2, objetoConeccionBaseDatos.conectorBaseDatos))
                try
                {

                    cmd2.Parameters.AddWithValue("@Marca", txtMarca.Text);
                    cmd2.Parameters.AddWithValue("@Modelo",txtModelo.Text);
                    cmd2.Parameters.AddWithValue("@año", txtAño.Text);
                    cmd2.Parameters.AddWithValue("@patente", txtPatente.Text);
                    cmd2.Parameters.AddWithValue("@kilometraje", txtKilometraje.Text);
                    cmd2.Parameters.AddWithValue("@estado", cmbEstado.Text);
                    cmd2.ExecuteNonQuery();

                    txtMarca.Text = "";
                    txtAño.Text = "";
                    txtModelo.Text = "";
                    txtPatente.Text = "";
                    txtKilometraje.Text = "";

                    MessageBox.Show("Vehiculo Registrado con éxito");
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
}
