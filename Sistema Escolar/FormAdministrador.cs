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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Sistema_Escolar
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        String connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TRABAJOFINAL;Integrated Security=True";

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Clear();
            txtBoxApellidoPaterno.Clear();
            txtBoxApellidoMaterno.Clear();
            txtBoxTelefono.Clear();

            txtBoxNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombre, apellidoPaterno, apellidoMaterno, telefono;

            nombre = txtBoxNombre.Text;
            apellidoPaterno = txtBoxApellidoPaterno.Text;
            apellidoMaterno = txtBoxApellidoMaterno.Text;
            if(txtBoxTelefono.Text == "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO ALUMNO (nombre, apellidoPaterno, apellidoMaterno) VALUES (@nombre, @apellidoPaterno, @apellidoMaterno)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                        command.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);

                        command.ExecuteNonQuery();
                    }
                }

            } else
            {
                telefono = txtBoxTelefono.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO ALUMNO VALUES (@nombre, @apellidoPaterno, @apellidoMaterno, @telefono)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                        command.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
                        command.Parameters.AddWithValue("@telefono", telefono);

                        command.ExecuteNonQuery();
                    }
                }

            }

            

            txtBoxNombre.Clear();
            txtBoxApellidoPaterno.Clear();
            txtBoxApellidoMaterno.Clear();
            txtBoxTelefono.Clear();

            txtBoxNombre.Focus();


        }
    }
}
