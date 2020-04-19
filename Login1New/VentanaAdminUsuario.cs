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

namespace Login1New
{
    public partial class VentanaAdminUsuario : Form
    {
        public VentanaAdminUsuario()
        {
            InitializeComponent();
        }

        private void Btn_añadir_usu_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Usuario:";
            label2.Text = "Asignar contraseña:";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("SERVER=LAPTOP-9GEKNAJR\\SQLEXPRESS;DATABASE=BDusuario;Integrated security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Usuarios values(4,'"+textBox1.Text+"','"+textBox2.Text+"',2);", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Inserting Data Successfully");
            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
