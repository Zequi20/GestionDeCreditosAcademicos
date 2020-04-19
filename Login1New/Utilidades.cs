using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Login1New
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("SERVER=LAPTOP-9GEKNAJR\\SQLEXPRESS;DATABASE=BDusuario;Integrated security=True"); // asigna a una variable una cadena de conexion para sql
            Con.Open(); //abre la base de datos

            DataSet DS = new DataSet(); // Una variable dataset para ir cargando los resultados del comando
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con); // adapta el comando con la base de datos

            DP.Fill(DS); // 

            Con.Close(); // cierra la base de datos

            return DS; //retorna un dataset con los pedidos
        }
    }
}
