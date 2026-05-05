using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaConcesionario
{
    internal class CConexion
    {
        public OleDbConnection conectorBaseDatos;
        public string estadoConexion = "sin conexion";
        //metodos para abrir la base
        public void ConectarBaseDatos()
        {
            try
            {
                conectorBaseDatos = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\DATABASE\concesionaria.accdb;Persist Security Info=False;");
                conectorBaseDatos.Open();
                estadoConexion = conectorBaseDatos.State.ToString();
            }
            catch (Exception error)
            {
                estadoConexion = "error: " + error.Message;
                throw;
            }
        }
        public bool CargarAuto(string marca, string modelo, string año, string patente, string kilometraje, string estado)
        {
            ConectarBaseDatos();
            string query = "INSERT INTO Vehiculo (Marca, Modelo, año, patente, kilometraje, estado) VALUES (?, ?, ?, ?, ?, ?)";

            using (OleDbCommand cmd = new OleDbCommand(query, conectorBaseDatos))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@Marca", marca);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@año", año);
                    cmd.Parameters.AddWithValue("@patente", patente);
                    cmd.Parameters.AddWithValue("@kilometraje", kilometraje);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar comando: " + ex.Message);
                }
                finally
                {
                    conectorBaseDatos.Close();
                }
            }
        }
        public void cargarCliente(string nombre, string telefono, string mail, string direccion, string  dni)
        {
            ConectarBaseDatos();
            string query = "INSERT INTO Cliente (nombre, Telefono, Mail, direccion ,dni) VALUES (?, ?, ?, ?, ?)";
            using (OleDbCommand cmd = new OleDbCommand(query, conectorBaseDatos))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Mail", mail);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@dni", dni);
                    
                    
                    
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar comando: " + ex.Message);
                }
                finally
                {
                    conectorBaseDatos.Close();
                }
            }
        }
    }
}
