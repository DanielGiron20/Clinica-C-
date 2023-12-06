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
    public partial class FormHospitalizaciones : Form
    {
        SqlDataAdapter adaHospitalizaciones;
        DataTable dtHospitalizaciones;

        public FormHospitalizaciones()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaHospitalizaciones = new SqlDataAdapter();
            adaHospitalizaciones.SelectCommand = new SqlCommand("select * from clinica.hospitalizaciones", cnx);
        }

        private void FormHospitalizaciones_Load(object sender, EventArgs e)
        {
            dtHospitalizaciones = new DataTable();
            adaHospitalizaciones.Fill(dtHospitalizaciones);
            dataGridView1.DataSource = dtHospitalizaciones;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.Show();
        }
    }
}
