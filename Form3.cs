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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("data source=SRVMIO;" +
                    "initial catalog=Neptuno; User Id=usMio; Pwd=Rcm123456;" +
                    "TrustServerCertificate=true"))
                {
                    //conexion.Open();

                    SqlCommand command = new SqlCommand("USP_BuscarClientesPorFiltro", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter parameter1 = new SqlParameter("@NombreContacto", SqlDbType.VarChar,50); //Tienen q tener los mismos nombres que en el procedimiento almacenado
                    parameter1.Value = txtContacto.Text;

                    SqlParameter parameter2 = new SqlParameter("@CargoContacto", SqlDbType.VarChar, 50);
                    parameter2.Value = txtCargo.Text;
                                        
                    command.Parameters.Add(parameter1);
                    command.Parameters.Add(parameter2);                    

                    DataTable datatable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(datatable);

                    dgvClientes.DataSource = datatable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
