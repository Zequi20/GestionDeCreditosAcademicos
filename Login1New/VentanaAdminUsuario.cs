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
        int btn;
        public VentanaAdminUsuario()
        {
            InitializeComponent();
        }

        private void Btn_añadir_usu_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Usuario:";
            label2.Text = "Asignar contraseña:";
            btn = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            if (btn == 0)
            {
                SqlConnection conn = new SqlConnection("SERVER=LAPTOP-9GEKNAJR\\SQLEXPRESS;DATABASE=BDusuario;Integrated security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Usuarios values('" + textBox1.Text + "','" + textBox2.Text + "',2);", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Operacion Exitosa");
                conn.Close();
            }
            else if(btn == 2)
            {
                SqlConnection conn = new SqlConnection("SERVER=LAPTOP-9GEKNAJR\\SQLEXPRESS;DATABASE=BDusuario;Integrated security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE usuario = '"+textBox1.Text+"'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado para siempre");
                conn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_elim_usu_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Usuario:";
            label2.Visible = false;
            textBox2.Visible = false;
            btn = 2;
        }
    }
}
