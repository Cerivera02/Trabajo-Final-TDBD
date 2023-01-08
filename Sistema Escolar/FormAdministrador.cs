using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Escolar
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador(string usernameIniciado)
        {
            InitializeComponent();
            this.usernameIniciado = usernameIniciado;
        }

        String connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TRABAJOFINAL;Integrated Security=True";
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TRABAJOFINAL;Integrated Security=True");

        String usernameIniciado;
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
            String nombre, apellidoPaterno, apellidoMaterno, telefono, CURP;
            int carrera;

            nombre = txtBoxNombre.Text;
            apellidoPaterno = txtBoxApellidoPaterno.Text;
            apellidoMaterno = txtBoxApellidoMaterno.Text;
            CURP = txtBoxCURP.Text;
            carrera = int.Parse(txtBoxCarrera.Text);
            if(txtBoxTelefono.Text == "")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO ALUMNO (nombre, apellidoPaterno, apellidoMaterno, curp, id_carrera) VALUES (@nombre, @apellidoPaterno, @apellidoMaterno, @CURP, @id_carrera)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                        command.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
                        command.Parameters.AddWithValue("@CURP", CURP);
                        command.Parameters.AddWithValue("@id_carrera", carrera);
                        command.ExecuteNonQuery();
                    }
                }
            } else
            {
                telefono = txtBoxTelefono.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = " EXEC INSERTAR_ALUMNO @nombre, @apellidoPaterno, @apellidoMaterno, @telefono, @CURP, @carrera";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
                        command.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@CURP", CURP);
                        command.Parameters.AddWithValue("@carrera", carrera);
                        command.ExecuteNonQuery();
                    }
                }
            }
            txtBoxNombre.Clear();
            txtBoxApellidoPaterno.Clear();
            txtBoxApellidoMaterno.Clear();
            txtBoxTelefono.Clear();
            txtBoxCURP.Clear();
            txtBoxCarrera.Clear();
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
            String consulta;
            consulta = "SELECT noControl as 'No. Control', nombre as 'Nombre' FROM ALUMNO";
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
            consulta = "SELECT noControl as 'No. Control', nombre as 'Nombre', apellidoPaterno as 'Apellido Paterno', apellidoMaterno as 'Apellido Materno', nombreBeca as 'Beca', monto as 'Monto de la Beca' FROM ALUMNO AS A LEFT JOIN BECADOS AS B ON A.id_beca=B.id_beca WHERE A.id_beca >= 1";
            sda = new SqlDataAdapter(consulta, conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgv2.DataSource = dt;

            //VISTAS
            consulta = "SELECT * FROM VISTA2";
            sda = new SqlDataAdapter(consulta, conn);
            dt = new DataTable();
            sda.Fill(dt);
            dgv3.DataSource = dt;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                consulta = "SELECT dbo.fn_obtener_nombre_maestro(@username)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@username", usernameIniciado);
                string nombre = (string)comando.ExecuteScalar();
                label5.Text = nombre;
            }
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
                string consulta;
                if (nuevoValor_Tbx.Text == "")
                {
                    consulta = "UPDATE ALUMNO SET " + Editar_datos_Cbx.Text + " = null WHERE noControl = '" + NoControlParaEditar_Tbx.Text + "'";
                } else
                {
                    consulta = "UPDATE ALUMNO SET " + Editar_datos_Cbx.Text + " = '" + nuevoValor_Tbx.Text + "' WHERE noControl = '" + NoControlParaEditar_Tbx.Text + "'";
                }
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

