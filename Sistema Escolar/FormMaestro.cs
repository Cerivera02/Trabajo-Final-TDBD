using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escolar
{
    public partial class FormMaestro : Form
    {
        public FormMaestro()
        {
            InitializeComponent();
        }
        String connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TRABAJOFINAL;Integrated Security=True";
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=TRABAJOFINAL;Integrated Security=True");

        private void FormMaestro_Load(object sender, EventArgs e)
        {
            String consulta;
            consulta = "SELECT id_carrera as 'Id Carrera', nombreCarrera as 'Nombre' FROM CARRERA";
            SqlDataAdapter sda = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String consulta;
            int id_carrera = int.Parse(textBox1.Text);
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                consulta = "SELECT dbo.fn_obtener_num_alumnos_por_carrera(@idCarrera)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@idCarrera", id_carrera);
                int nombre = (int)comando.ExecuteScalar();
                label1.Text = nombre.ToString();
            }
        }
    }
}
