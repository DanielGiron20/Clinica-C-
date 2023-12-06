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
    public partial class FormAdminPrecio : Form
    {
        SqlDataAdapter adaHabitaciones;
        DataTable dtHabitaciones;

        SqlDataAdapter adaConsultorios;
        DataTable dtConsultorios;

        public FormAdminPrecio()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaHabitaciones = new SqlDataAdapter();
            adaHabitaciones.SelectCommand = new SqlCommand("select * from clinica.habitaciones", cnx);

            adaConsultorios = new SqlDataAdapter();
            adaConsultorios.SelectCommand = new SqlCommand("select * from clinica.habitaciones", cnx);
        }

        private void FormAdminPrecio_Load(object sender, EventArgs e)
        {
            dtHabitaciones = new DataTable();
            adaHabitaciones.Fill(dtHabitaciones);
            dataGridView1.DataSource = dtHabitaciones;

            dtConsultorios = new DataTable();
            adaConsultorios.Fill(dtConsultorios);
            dataGridView2.DataSource = dtConsultorios;
        }
    }
}
