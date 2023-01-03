using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Escolar
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TRABAJOFINAL;Integrated Security=True");
        
        private void btn_Login_Click(object sender, EventArgs e)
        {
            String username, password,tipoUser;

            username = txtBox_User.Text;
            password = txtBox_Password.Text;

            try
            {
                String query = "SELECT * FROM MAESTRO WHERE username = '" + username + "' AND password = '" + password + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    username = txtBox_User.Text;
                    password = txtBox_Password.Text;

                    MessageBox.Show("Sesion Iniciada");
                                        
                    conn.Open();

                    query = "SELECT tipoUser FROM MAESTRO WHERE username = @username";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Crea una tipoUser para guardar el valor del campo

                            if (reader.Read())
                            {
                                // Asigna el valor del campo a la tipoUser
                                tipoUser = reader["tipoUser"].ToString();

                                switch (tipoUser)
                                {
                                    case "Administrador":
                                        Form FormAdministrador = new FormAdministrador();
                                        FormAdministrador.Show();
                                        Console.WriteLine("Form iniciado de Administrador");
                                        break;

                                    case "Maestro":
                                        Form FormMaestro = new FormMaestro();
                                        FormMaestro.Show();
                                        Console.WriteLine("Form iniciado de Maestro");
                                        break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Datos Erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBox_Password.Clear();
                    txtBox_User.Clear();

                    txtBox_User.Focus();
                }
            }
            catch 
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_Password.Clear();
            txtBox_User.Clear();

            txtBox_User.Focus();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
