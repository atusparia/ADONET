using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
           
            SqlConnection conexion = new SqlConnection("data source=SRVMIO;" +
                    "initial catalog=Neptuno; Integrated Security=true;" +
                    "TrustServerCertificate=true");

            //Integrated Security=true; toma por defecto el usuario de windows
            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Productos", conexion);

                DataTable dataTable = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(dataTable);

                conexion.Close();

                dgvProductos.DataSource = dataTable;
            }
            catch (Exception ex) {

                throw ex;

            }
        }

        private void btnListarProductosUsuario_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("data source=SRVMIO;" +
                    "initial catalog=Neptuno; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true");                       
            try
            {
                conexion.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Productos", conexion);

                DataTable dataTable = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(dataTable);

                conexion.Close();

                dgvProductos.DataSource = dataTable;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        private void btnListarProductosUsing_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection conexion = new SqlConnection("data source=SRVMIO;" +
                    "initial catalog=Neptuno; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true"))
                {

                    SqlCommand command = new SqlCommand("SELECT * FROM Productos", conexion);

                    DataTable dataTable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(dataTable);

                    dgvProductos.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
