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

namespace ProyectoClinica
{
    public partial class FormPacientes : Form
    {

        SqlDataAdapter adaPacientes;
        DataTable dtPacientes;
        public FormPacientes()
        {

            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaPacientes = new SqlDataAdapter();
            adaPacientes.SelectCommand = new SqlCommand("select * from clinica.pacientes", cnx);


            adaPacientes.InsertCommand = new SqlCommand("insert into clinica.pacientes values(@id, @nom, @ap, @date, @cedula, @gen, @tel, @det, @idoctor, @consulta, @fechaR)", cnx);
            adaPacientes.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_paciente");
            adaPacientes.InsertCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "nombre");
            adaPacientes.InsertCommand.Parameters.Add("@ap", SqlDbType.VarChar, 50, "apellido");
            adaPacientes.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar, 20, "fecha_nacimiento");
            adaPacientes.InsertCommand.Parameters.Add("@cedula", SqlDbType.BigInt, 20, "numero_cedula");
            adaPacientes.InsertCommand.Parameters.Add("@gen", SqlDbType.VarChar, 10, "genero");
            adaPacientes.InsertCommand.Parameters.Add("@tel", SqlDbType.VarChar, 20, "telefono");
            adaPacientes.InsertCommand.Parameters.Add("@det", SqlDbType.VarChar, 50, "detalles_del_paciente");
            adaPacientes.InsertCommand.Parameters.Add("@idoctor", SqlDbType.Int, 4, "id_doctor");
            adaPacientes.InsertCommand.Parameters.Add("@consulta", SqlDbType.VarChar, 30, "tipo_de_consulta");
            adaPacientes.InsertCommand.Parameters.Add("@fechaR", SqlDbType.VarChar, 50, "fecha_registro");

            adaPacientes.UpdateCommand = new SqlCommand("update clinica.pacientes set  nombre=@nom, apellido=@ap, fecha_nacimiento=@date, numero_cedula=@cedula, genero=@gen, telefono=@tel, detalles_del_paciente=@det, id_doctor=@idoctor, tipo_de_consulta=@consulta, fecha_registro=@fechaR where id_paciente=@id", cnx);
            adaPacientes.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_paciente");
            adaPacientes.UpdateCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "nombre");
            adaPacientes.UpdateCommand.Parameters.Add("@ap", SqlDbType.VarChar, 50, "apellido");
            adaPacientes.UpdateCommand.Parameters.Add("@date", SqlDbType.VarChar, 20, "fecha_nacimiento");
            adaPacientes.UpdateCommand.Parameters.Add("@cedula", SqlDbType.BigInt, 20, "numero_cedula");
            adaPacientes.UpdateCommand.Parameters.Add("@gen", SqlDbType.VarChar, 10, "genero");
            adaPacientes.UpdateCommand.Parameters.Add("@tel", SqlDbType.VarChar, 20, "telefono");
            adaPacientes.UpdateCommand.Parameters.Add("@det", SqlDbType.VarChar, 50, "detalles_del_paciente");
            adaPacientes.UpdateCommand.Parameters.Add("@idoctor", SqlDbType.Int, 4, "id_doctor");
            adaPacientes.UpdateCommand.Parameters.Add("@consulta", SqlDbType.VarChar, 30, "tipo_de_consulta");
            adaPacientes.UpdateCommand.Parameters.Add("@fechaR", SqlDbType.VarChar, 50, "fecha_registro");

            adaPacientes.DeleteCommand = new SqlCommand("delete from clinica.pacientes where id_paciente=@idp", cnx);
            adaPacientes.DeleteCommand.Parameters.Add("@idp", SqlDbType.Int, 4, "id_paciente");

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            dtPacientes = new DataTable();
            adaPacientes.Fill(dtPacientes);
            dataGridView1.DataSource = dtPacientes;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                adaPacientes.Update(dtPacientes);
                MessageBox.Show("Informacion salvada satisfactoriamente ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
