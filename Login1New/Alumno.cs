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
    public partial class Alumno : Form
    {
        int btn;
        public Alumno()
        {
            InitializeComponent();
        }

        private void Btn_añadir_usu_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = false;
            label1.Text = "Nombre del Alumno:";
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
                string CMD = string.Format("insert into Usuarios values('" + textBox1.Text + "','" + textBox2.Text + "',2)");
                DataSet ds = Utilidades.Insertar(CMD);
                MessageBox.Show("Operacion Exitosa");
            }
            else if(btn == 1)
            {
                ModificarAlumno VenModAl = new ModificarAlumno();
                //ModificarAlumno.nom = textBox1.Text;
                this.Hide();
                VenModAl.Show();

            }
            else if(btn == 2)
            {
                string CMD = string.Format("DELETE FROM Usuarios WHERE usuario = '" + textBox1.Text + "'");
                DataSet ds = Utilidades.Eliminar(CMD);
                MessageBox.Show("Usuario eliminado para siempre");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Btn_elim_usu_Click(object sender, EventArgs e)
        {
        }

        private void Btn_atras_Click(object sender, EventArgs e)
        {
            HomeAdministrador VenAd = new HomeAdministrador();
            this.Hide();
            VenAd.Show();
        }

        private void Btn_elim_usu_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Alumno:";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            btn = 2;
        }

        public void Btn_modif_usu_Click(object sender, EventArgs e)
        {
            label3.Text = "Nombre del Alumno que desea modificar:";
            label1.Visible = false;
            textBox1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = true;
            //ModificarAlumno.nom = textBox1.Text;
            btn = 1;
        }
    }
}
