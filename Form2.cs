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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnListarPedidoCompañia_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("data source=SRVMIO;" +
                    "initial catalog=Neptuno; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true"))
                {

                    SqlCommand command = new SqlCommand("USP_ListarPedidoCompania", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dataTable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(dataTable);

                    dgvPedidoCompania.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnInsertarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("data source=SRVMIO;" +
                    "initial catalog=Neptuno; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true"))
                {
                    conexion.Open();

                    SqlCommand command = new SqlCommand("USP_InsertarCategoriaPrueba", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter parameter1 = new SqlParameter("@IdCategoria",SqlDbType.Int); //Tienen q tener los mismos nombres que en el procedimiento almacenado
                    parameter1.Value = Convert.ToInt32(txtId.Text);

                    SqlParameter parameter2 = new SqlParameter("@Nombre", SqlDbType.VarChar, 50);
                    parameter2.Value = txtNombre.Text;

                    SqlParameter parameter3 = new SqlParameter("@Descripcion", SqlDbType.Text);
                    parameter3.Value = txtDescripcion.Text;

                    command.Parameters.Add(parameter1);
                    command.Parameters.Add(parameter2);
                    command.Parameters.Add(parameter3);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Registro Exitoso");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnListarCategorias_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("data source=SRVMIO;" +
                    "initial catalog=Neptuno; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true"))
                {

                    SqlCommand command = new SqlCommand("SELECT * FROM Categorias", conexion); //No se debe usar esta forma
                    //command.CommandType = CommandType.StoredProcedure;

                    DataTable dataTable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(dataTable);

                    dgvPedidoCompania.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
