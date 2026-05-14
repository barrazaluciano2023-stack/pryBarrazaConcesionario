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
    public partial class Concesionaria : Form
    {
        public Concesionaria()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            refrescarAutos();
        }
        public void refrescarAutos ()
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
        public void refrescarClientes()
        {
            CConexion objetoConeccionBaseDatos = new CConexion();
            objetoConeccionBaseDatos.ConectarBaseDatos();
            string query = "SELECT * FROM Cliente";
            {
                try
                {
                    // 3. Crear DataAdapter y DataTable
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, objetoConeccionBaseDatos.conectorBaseDatos);
                    DataTable dataTable = new DataTable();
                    // 4. Llenar el DataTable
                    adapter.Fill(dataTable);
                    // 5. Asignar datos al DataGridView
                    dgvClientes.DataSource = dataTable;
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
                int idSelecVehiculo = Convert.ToInt32(
                    dgvAutos.CurrentRow.Cells["idVehiculo"].Value);

                int idSelecCliente = Convert.ToInt32(
                    dgvClientes.CurrentRow.Cells["idCliente"].Value);

                CConexion objetoConexion = new CConexion();

                objetoConexion.cargarReserva(
                    idSelecVehiculo,
                    dtpReserva.Value,
                    dtpDevolucion.Value,
                    cmbSeguro.Text,
                    mtbImporte.Text,
                    idSelecCliente
                );

                cmbEstado.SelectedIndex = -1;
                cmbSeguro.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehiculo y cliente.");
            }
        }



        private void RegistrarVehiculo_Click(object sender, EventArgs e)
        {

            
            try
            {
                CConexion objetoConeccionBaseDatos = new CConexion();
                objetoConeccionBaseDatos.CargarAuto(
                    txtMarca.Text,
                    txtModelo.Text,
                    txtAño.Text,
                    txtPatente.Text,
                    txtKilometraje.Text,
                    cmbEstado.Text
                );

                txtMarca.Text = "";
                txtModelo.Text = "";
                txtAño.Text = "";
                txtPatente.Text = "";
                txtKilometraje.Text = "";
                cmbEstado.SelectedIndex = -1;

                MessageBox.Show("Vehículo registrado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refrescarAutos();
           
        }
        
        private void txtKilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidacion.SoloNumeros(e);
        }


        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidacion.SoloNumeros(e);
        }


        private void btnRegistrarCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                CConexion objetoConeccionBaseDatos = new CConexion();
                objetoConeccionBaseDatos.cargarCliente(
                    txtNombre.Text,                    
                    txtTelefono.Text,
                    txtMail.Text,
                    txtDireccion.Text,
                    txtDni.Text
                );

                txtNombre.Text = "";
                txtDni.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";
                txtMail.Text = "";

                MessageBox.Show("Cliente registrado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refrescarClientes();
        }


        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidacion.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidacion.SoloNumeros(e);
        }

        private void BtnCancelarCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
