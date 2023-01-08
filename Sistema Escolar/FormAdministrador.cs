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
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TRABAJOFINAL;Integrated Security=True");

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

        private void btnAgregarMaestros_Click(object sender, EventArgs e)
        {
            String username, password, tipoUser;

            username = txtBoxUsername.Text;
            password = txtBoxPassword.Text;

            if (comboBoxTipoUser.Text == "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO MAESTRO (username, password) VALUES (@username, @password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        
                        command.ExecuteNonQuery();
                    }
                }

            }
            else
            {
                tipoUser = comboBoxTipoUser.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO MAESTRO (username, password, tipoUser) VALUES (@username, @password, @tipoUser)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@tipoUser", tipoUser);

                        command.ExecuteNonQuery();
                    }
                }
               
            }
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            //CONSUTAS 
            String consulta = "SELECT nombre as 'Nombre' FROM ALUMNO";
            SqlDataAdapter sda = new SqlDataAdapter(consulta,conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridAlumnos.DataSource = dt;

            consulta = "SELECT nombre, id_carrera FROM ALUMNO";
            sda = new SqlDataAdapter(consulta, conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridMaestros.DataSource = dt;

            //JOIN
            consulta = "SELECT * FROM ALUMNO AS A LEFT JOIN BECADOS AS B ON A.id_beca=B.id_beca";
      
            sda.Fill(dt);
            dgv2.DataSource = dt;

            consulta = "SELECT * FROM ALUMNO AS A LEFT JOIN BECADOS AS B ON A.id_beca=B.id_beca";
            sda = new SqlDataAdapter(consulta, conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgv2.DataSource = dt;

            //VISTAS
            consulta = "SELECT * FROM VISTA2";

            sda.Fill(dt);
            dgv3.DataSource = dt;

            consulta = "SELECT * FROM VISTA2";
            sda = new SqlDataAdapter(consulta, conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgv3.DataSource = dt;

            //UPDATE
        }

        private void Eliminar_Btn_Click(object sender, EventArgs e)
        {
            String noControl;

            noControl = noControl_Tbx.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "EXEC BAJA_ALUMNO @WCONTROL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@WCONTROL", noControl);

                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Alumno eliminado exitosamente");

        }

        private void Editar_Btn_Click(object sender, EventArgs e)
        {
            String noControl;

            noControl = NoControlParaEditar_Tbx.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string consulta = "UPDATE ALUMNO SET " + Editar_datos_Cbx.Text + " = '" + nuevoValor_Tbx.Text + "' WHERE noControl = '" + NoControlParaEditar_Tbx.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, connection);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant > 0)
                {
                    MessageBox.Show("Dato modificado exitosamente");

                }
                connection.Close();

            }
        }
    }
}

