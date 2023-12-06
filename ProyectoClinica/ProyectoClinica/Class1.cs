using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoClinica
{
    internal class Class1
    {
        SqlConnection cnx = new SqlConnection();
        static string servidor = "DESKTOP-3K7DLR6\\SQLEXPRESS";
        static string bd = "clinica2";
        static string usuario = "daniel";
        static string password = "123";
        static string puerto = "1433";

        string cadena_conexion = "Data Source=" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "initial catalog=" + bd + ";" + "Persist Security info = true";

        public SqlConnection establecerConexion()
        {
            try {
                cnx.ConnectionString = cadena_conexion;
                cnx.Open();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Conexion fallida: " + ex.ToString);
            }
            return cnx;
        }
    }
}
