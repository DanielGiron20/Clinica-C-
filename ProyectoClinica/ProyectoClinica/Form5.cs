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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            long id = Convert.ToInt64(id_doctor.Text);
            string nombre = nombre_doctor.Text;
            string apellido = apellido_doctor.Text;
            long numeroCedula = Convert.ToInt64(cedula_doctor.Text);
            string telefono = telefono_doctor.Text;
            string correo = correo_doctor.Text;
            string estado = estado_doctor.SelectedItem.ToString();
            decimal salario = Convert.ToDecimal(salario_doctor.Text);
            decimal costo = Convert.ToDecimal(precioC_doctor.Text);
            int cons = Convert.ToInt32(consultorio.Text);

            string consultaInsert = "INSERT INTO clinica.doctores (id_doctor, nombre, apellido, nnumero_cedula, telefono, correo_electronico, salario, id_consultorio, estado_laboral, fecha_registro, precio_consulta) " +
                                    "VALUES (@id, @nombre, @apellido, @numeroCedula, @telefono, @correo, @salario, @id_consultorio, @estado, GETDATE(), @precio)";


            using (SqlCommand comando = new SqlCommand(consultaInsert, cnx))
            {
                // Agregar parámetros a la consulta SQL
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@numeroCedula", numeroCedula);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@salario", salario);
                comando.Parameters.AddWithValue("@id_consultorio", cons);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@precio", costo);

                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos del doctor guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos del doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
