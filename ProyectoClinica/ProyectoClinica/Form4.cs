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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }

        private void cmd_ingresar_Click(object sender, EventArgs e)
        {
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            long id = Convert.ToInt64(id_paciente.Text);
            string nombre = nombre_paciente.Text;
            string apellido = apellido_paciente.Text;
            string fechaNacimiento = fechaN_paciente.Text; // O también puedes usar el valor del DatePicker si lo prefieres
            long numeroCedula = Convert.ToInt64(cedula_paciente.Text);
            string genero = genero_paciente.SelectedItem.ToString();
            string telefono = telefono_paciente.Text;
            string detallesPaciente = detalles_paciente.Text;
            string Nombre_doctor = doctorR_paciente.SelectedItem.ToString(); // Asumiendo que el ComboBox tiene un DataSource vinculado con los doctores y el ValueMember es el id_doctor
            long id_doc = Convert.ToInt32(id_doctor.Text);
            // Crear la consulta SQL INSERT
            string consultaInsert = "INSERT INTO clinica.pacientes (id_paciente, nombre, apellido, fecha_nacimiento, numero_cedula, genero, telefono, detalles_del_paciente, id_doctor, fecha_registro, nombre_doctor) " +
                                    "VALUES (@id, @nombre, @apellido, @fechaNacimiento, @numeroCedula, @genero, @telefono, @detallesPaciente, @idDoctor, GETDATE(), @nombre_doctor)";


            using (SqlCommand comando = new SqlCommand(consultaInsert, cnx))
            {
                // Agregar parámetros a la consulta SQL
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                comando.Parameters.AddWithValue("@numeroCedula", numeroCedula);
                comando.Parameters.AddWithValue("@genero", genero);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@detallesPaciente", detallesPaciente);
                comando.Parameters.AddWithValue("@idDoctor", id_doc);
                comando.Parameters.AddWithValue("@nombre_doctor", Nombre_doctor);
                try
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos del paciente guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos del paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


                string consultaInsert2 = "INSERT INTO cargos (id_paciente, id_doctor, descripcion_cargo, tipo_cargo, costo) " +
                                   "VALUES (@id, @id_d, @desc, @tipocargo, @costo)";
            using (SqlCommand comando = new SqlCommand(consultaInsert2, cnx))
            {
                decimal costoConsulta = 0;
                string consultaCosto = "SELECT precio_consulta FROM clinica.doctores WHERE id_doctor = @idDoctor";


                using (SqlCommand comandoCosto = new SqlCommand(consultaCosto, cnx))
                {
                    comandoCosto.Parameters.AddWithValue("@idDoctor", id_doc);

                    try
                    {
                        object resultadoConsulta = comandoCosto.ExecuteScalar();

                        // Verificar si se obtuvo algún resultado y asignar el costo por consulta
                        if (resultadoConsulta != null && resultadoConsulta != DBNull.Value)
                        {
                            costoConsulta = Convert.ToDecimal(resultadoConsulta);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al obtener el costo por consulta: " + ex.Message);
                    }
                }


                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@id_d", id_doc);
                comando.Parameters.AddWithValue("@desc", "Consulta Medica");
                comando.Parameters.AddWithValue("@tipocargo", "Consulta medica");
                comando.Parameters.AddWithValue("@costo", costoConsulta);
                try
                {
                    comando.ExecuteNonQuery();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            string consultaInsert3 = "INSERT INTO cargos_doctores (id_paciente, id_doctor, descripcion_cargo, costo) " +
                                   "VALUES (@id, @id_d, @desc, @costo)";
            using (SqlCommand comando = new SqlCommand(consultaInsert3, cnx))
            {
                decimal costoConsulta = 0;
                string consultaCosto = "SELECT precio_consulta FROM clinica.doctores WHERE id_doctor = @idDoctor";


                using (SqlCommand comandoCosto = new SqlCommand(consultaCosto, cnx))
                {
                    comandoCosto.Parameters.AddWithValue("@idDoctor", id_doc);

                    try
                    {
                        object resultadoConsulta = comandoCosto.ExecuteScalar();

                        // Verificar si se obtuvo algún resultado y asignar el costo por consulta
                        if (resultadoConsulta != null && resultadoConsulta != DBNull.Value)
                        {
                            costoConsulta = Convert.ToDecimal(resultadoConsulta);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al obtener el costo por consulta: " + ex.Message);
                    }
                }


                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@id_d", id_doc);
                comando.Parameters.AddWithValue("@desc", "Consulta Medica");
                comando.Parameters.AddWithValue("@costo", costoConsulta);
                try
                {
                    comando.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
