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
    public partial class FormAgenda : Form
    {
        SqlDataAdapter adaAgenda;
        DataTable dtAgenda;
        public FormAgenda()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaAgenda = new SqlDataAdapter();
            adaAgenda.SelectCommand = new SqlCommand("select * from clinica.agendaquirofano", cnx);

        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            dtAgenda = new DataTable();
            adaAgenda.Fill(dtAgenda);
            dataGridView1.DataSource = dtAgenda;
        }
    }
}
