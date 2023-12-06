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
    public partial class Form1 : Form
    {
        SqlDataAdapter adaHabitaciones;
        DataTable dtHabitaciones;
        public Form1()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaHabitaciones = new SqlDataAdapter();
            adaHabitaciones.SelectCommand = new SqlCommand("select * from clinica.habitaciones", cnx);
            dtHabitaciones = new DataTable();
            adaHabitaciones.Fill(dtHabitaciones);
            dataGridView1.DataSource = dtHabitaciones;
            CalcularHabitacionesDisponibles();
        }

        private void CalcularHabitacionesDisponibles()
        {
            int disponiblesPrivadas = 0, disponiblesSemiprivadas = 0, disponiblesSuites = 0;

            foreach (DataRow fila in dtHabitaciones.Rows)
            {
                string tipoHabitacion = fila["tipo_habitacion"].ToString();
                int nCamas = Convert.ToInt32(fila["n_camas"]);

                if (tipoHabitacion == "privada")
                    disponiblesPrivadas += nCamas;
                else if (tipoHabitacion == "semiprivada")
                    disponiblesSemiprivadas += nCamas;
                else if (tipoHabitacion == "Suite")
                    disponiblesSuites += nCamas;
            }

           
            privadas.Text = disponiblesPrivadas.ToString();
            semiprivadas.Text = disponiblesSemiprivadas.ToString();
            suites.Text = disponiblesSuites.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
