using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;


namespace Login1New
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            // mi servidor de base de datos es: LAPTOP-RRPVHD2G\\SQLEXPRESS "Luciano"
            SqlConnection Con = new SqlConnection("SERVER=LAPTOP-RRPVHD2G\\SQLEXPRESS;DATABASE=BDusuario;Integrated security=True"); // asigna a una variable una cadena de conexion para sql
            Con.Open(); //abre la base de datos

            DataSet DS = new DataSet(); // Una variable dataset para ir cargando los resultados del comando
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con); // adapta el comando con la base de datos
            
            DP.Fill(DS); // 

            Con.Close(); // cierra la base de datos

            return DS; //retorna un dataset con los pedidos
        }

        public static SqlDataReader Consulta(string consulta)
        {
            SqlConnection Con = new SqlConnection("SERVER=LAPTOP-RRPVHD2G\\SQLEXPRESS;DATABASE=BDusuario;Integrated security=True"); // asigna a una variable una cadena de conexion para sql
            Con.Open();
            SqlCommand comando = new SqlCommand(consulta, Con);
            SqlDataReader registro = comando.ExecuteReader();
            return registro;
        }

        public static DataSet Insertar(string cmd)
        {
            SqlConnection Con = new SqlConnection("SERVER=LAPTOP-RRPVHD2G\\SQLEXPRESS;DATABASE=BDusuario;Integrated security=True"); // asigna a una variable una cadena de conexion para sql
            Con.Open(); //abre la base de datos

            DataSet DS = new DataSet(); // Una variable dataset para ir cargando los resultados del comando
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con); // adapta el comando con la base de datos

            DP.Fill(DS); // 

            Con.Close(); // cierra la base de datos

            return DS; //retorna un dataset con los pedidos
        }

        public static DataSet Eliminar(string cmd)
        {
            SqlConnection Con = new SqlConnection("SERVER=LAPTOP-RRPVHD2G\\SQLEXPRESS;DATABASE=BDusuario;Integrated security=True"); // asigna a una variable una cadena de conexion para sql
            Con.Open(); //abre la base de datos

            DataSet DS = new DataSet(); // Una variable dataset para ir cargando los resultados del comando
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con); // adapta el comando con la base de datos

            DP.Fill(DS); // 

            Con.Close(); // cierra la base de datos

            return DS; //retorna un dataset con los pedidos
        }

        public static DataTable ObtenerEmpresa(string cmd)
        {
            SqlConnection Con = new SqlConnection("SERVER=LAPTOP-RRPVHD2G\\SQLEXPRESS;DATABASE=BDusuario;Integrated security=True"); // asigna a una variable una cadena de conexion para sql
            Con.Open(); //abre la base de datos

            DataTable DT = new DataTable(); // Una variable dataset para ir cargando los resultados del comando
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con); // adapta el comando con la base de datos

            DP.Fill(DT); // 

            Con.Close(); // cierra la base de datos

            return DT; //retorna un dataset con los pedidos
        }
    }
}
