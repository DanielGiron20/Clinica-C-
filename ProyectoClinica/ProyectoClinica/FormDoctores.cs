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
    public partial class FormDoctores : Form
    {
        SqlDataAdapter adaDoctores;
        DataTable dtDoctores;

        public FormDoctores()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaDoctores = new SqlDataAdapter();
            adaDoctores.SelectCommand = new SqlCommand("select * from clinica.doctores", cnx);

            adaDoctores.InsertCommand = new SqlCommand("insert into clinica.doctores values(@id, @nom, @ap, @cedula, @esp, @tel, @correo, @salario, @idConsultorio, @Estado, @fechaR, @precioConsulta)", cnx);
            adaDoctores.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_doctor");
            adaDoctores.InsertCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "nombre");
            adaDoctores.InsertCommand.Parameters.Add("@ap", SqlDbType.VarChar, 50, "apellido");
            adaDoctores.InsertCommand.Parameters.Add("@cedula", SqlDbType.BigInt, 20, "nnumero_cedula");
            adaDoctores.InsertCommand.Parameters.Add("@esp", SqlDbType.VarChar, 50, "especialidad");
            adaDoctores.InsertCommand.Parameters.Add("@tel", SqlDbType.VarChar, 20, "telefono");
            adaDoctores.InsertCommand.Parameters.Add("@correo", SqlDbType.VarChar, 100, "correo_electronico");
            adaDoctores.InsertCommand.Parameters.Add("@salario", SqlDbType.Decimal, 10, "salario");
            adaDoctores.InsertCommand.Parameters.Add("@idConsultorio", SqlDbType.Int, 4, "id_consultorio");
            adaDoctores.InsertCommand.Parameters.Add("@Estado", SqlDbType.VarChar, 20, "estado_laboral");
            adaDoctores.InsertCommand.Parameters.Add("@fechaR", SqlDbType.VarChar, 50, "fecha_registro");
            adaDoctores.InsertCommand.Parameters.Add("@precioConsulta", SqlDbType.BigInt, 20, "precio_consulta");

            adaDoctores.UpdateCommand = new SqlCommand("update clinica.doctores set id_doctor=@id, nombre=@nom, apellido=@ap, nnumero_cedula=@cedula, especialidad=@esp, telefono=@tel, correo_electronico=@correo, salario=@salario, id_consultorio=@idConsultorio, estado_laboral=@Estado, fecha_registro=@fechaR, precio_consulta=@precioConsulta where id_doctor=@id", cnx);
            adaDoctores.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_doctor");
            adaDoctores.UpdateCommand.Parameters.Add("@nom", SqlDbType.VarChar, 50, "nombre");
            adaDoctores.UpdateCommand.Parameters.Add("@ap", SqlDbType.VarChar, 50, "apellido");
            adaDoctores.UpdateCommand.Parameters.Add("@cedula", SqlDbType.BigInt, 20, "nnumero_cedula");
            adaDoctores.UpdateCommand.Parameters.Add("@esp", SqlDbType.VarChar, 50, "especialidad");
            adaDoctores.UpdateCommand.Parameters.Add("@tel", SqlDbType.VarChar, 20, "telefono");
            adaDoctores.UpdateCommand.Parameters.Add("@correo", SqlDbType.VarChar, 100, "correo_electronico");
            adaDoctores.UpdateCommand.Parameters.Add("@salario", SqlDbType.Decimal, 10, "salario");
            adaDoctores.UpdateCommand.Parameters.Add("@idConsultorio", SqlDbType.Int, 4, "id_consultorio");
            adaDoctores.UpdateCommand.Parameters.Add("@Estado", SqlDbType.VarChar, 20, "estado_laboral");
            adaDoctores.UpdateCommand.Parameters.Add("@fechaR", SqlDbType.VarChar, 50, "fecha_registro");
            adaDoctores.UpdateCommand.Parameters.Add("@precioConsulta", SqlDbType.BigInt, 20, "precio_consulta");

            adaDoctores.DeleteCommand = new SqlCommand("delete from clinica.doctores where id_doctor=@idp", cnx);
            adaDoctores.DeleteCommand.Parameters.Add("@idp", SqlDbType.Int, 4, "id_doctor");


        }

        private void FormDoctores_Load(object sender, EventArgs e)
        {
            dtDoctores = new DataTable();
            adaDoctores.Fill(dtDoctores);
            dataGridView1.DataSource = dtDoctores;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                adaDoctores.Update(dtDoctores);
                MessageBox.Show("Informacion salvada satisfactoriamente ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }
    }
}
