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

namespace ProyectoClinica
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection con = ob.establecerConexion();
            string query = "SELECT COUNT(*) FROM clinica.usuarios WHERE usuario = @Usuario AND pasw = @Contrasena";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            command.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
            try
            {
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("CONEXION EXITOSA");
                    CentroMedicoLaPaz form = new CentroMedicoLaPaz();
                    form.Visible = true;
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectarse a la base de datos: " + ex.Message);

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
