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
    public partial class AdminFarmacia : Form
    {
        SqlDataAdapter adaFarmacia;
        DataTable dtFarmacia;
        public AdminFarmacia()
        {
            InitializeComponent();
            Class1 ob = new Class1();
            SqlConnection cnx = ob.establecerConexion();
            adaFarmacia = new SqlDataAdapter();

            adaFarmacia.SelectCommand = new SqlCommand("select * from clinica.farmacia", cnx);


            adaFarmacia.InsertCommand = new SqlCommand("insert into clinica.farmacia values(@id, @nom, @can, @des, @costo)", cnx);
            adaFarmacia.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_medicamento");
            adaFarmacia.InsertCommand.Parameters.Add("@nom", SqlDbType.VarChar, 100, "nombre_medicamento");
            adaFarmacia.InsertCommand.Parameters.Add("@can", SqlDbType.Int, 4, "cantidad_inventario");
            adaFarmacia.InsertCommand.Parameters.Add("@des", SqlDbType.VarChar, 255, "descripcion");
            adaFarmacia.InsertCommand.Parameters.Add("@costo", SqlDbType.Float, 10, "costo");

            adaFarmacia.UpdateCommand = new SqlCommand("update clinica.farmacia set nombre_medicamento=@nom, cantidad_inventario=@can, descripcion=@des, costo=@costo where id_medicamento=@id", cnx);
            adaFarmacia.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id_medicamento");
            adaFarmacia.UpdateCommand.Parameters.Add("@nom", SqlDbType.VarChar, 100, "nombre_medicamento");
            adaFarmacia.UpdateCommand.Parameters.Add("@can", SqlDbType.Int, 4, "cantidad_inventario");
            adaFarmacia.UpdateCommand.Parameters.Add("@des", SqlDbType.VarChar, 255, "descripcion");
            adaFarmacia.UpdateCommand.Parameters.Add("@costo", SqlDbType.Float, 10, "costo");


            adaFarmacia.DeleteCommand = new SqlCommand("delete from clinica.farmacia where id_medicamento=@idp", cnx);
            adaFarmacia.DeleteCommand.Parameters.Add("@idp", SqlDbType.Int, 4, "id_medicamento");

        }

        private void AdminFarmacia_Load(object sender, EventArgs e)
        {
            dtFarmacia = new DataTable();
            adaFarmacia.Fill(dtFarmacia);
            dataGridView1.DataSource = dtFarmacia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                adaFarmacia.Update(dtFarmacia);
                MessageBox.Show("Informacion salvada satisfactoriamente ", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
