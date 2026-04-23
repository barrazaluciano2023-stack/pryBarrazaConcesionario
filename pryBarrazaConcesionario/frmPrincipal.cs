using System;
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

            OleDbDataAdapter adapter = new OleDbDataAdapter(query,objetoConeccionBaseDatos.conectorBaseDatos);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
        }
    }
}
