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
using System.Security.Cryptography.X509Certificates;

namespace Login1New
{
    public partial class HomeAdmin : Form
    {
        String nom;
        int btn;
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void Btn_añadir_usu_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label1.Text = "Nombre del Alumno:";
            label2.Text = "Asignar contraseña:";
            btn = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        public String getNombre()
        {
            return this.nom;
        }

        public void setNombre(String nom)
        {
            this.nom = textBox1.Text;
        }

        public void Btn_aceptar_Click(object sender, EventArgs e)
        {
            if (btn == 0)
            {
                string CMD = string.Format("insert into Usuarios values('" + textBox1.Text + "','" + textBox2.Text + "',2)");
                DataSet ds = Utilidades.Insertar(CMD);
                MessageBox.Show("Operacion Exitosa");
            }
            else if (btn == 1)
            {
                ModificarAlumno VenModAl = new ModificarAlumno();
                VenModAl.Show();
                 HomeAdmin Nombre = new HomeAdmin();
                Nombre.setNombre(textBox1.Text);
                MessageBox.Show(Nombre.nom);
            }
            else if (btn == 2)
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

        private void Btn_elim_usu_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Alumno:";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            btn = 2;
        }

        public void Btn_modif_usu_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Alumno que desea modificar:";
            label1.Visible = false;
            textBox1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            label1.Visible = true;
            label1.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
            btn = 1;
        }

        private void agregarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            label1.Text = "Nombre del Alumno:";
            label2.Text = "Asignar contraseña:";
            Btn_aceptar.Visible = true;
            btn = 0;
        }

        private void Alumno_Load(object sender, EventArgs e)
        {

        }

        private void Btn_aceptar_Click_1(object sender, EventArgs e)
        {
            if (btn == 0)
            {
                string CMD = string.Format("insert into Usuarios values('" + textBox1.Text + "','" + textBox2.Text + "',2)");
                DataSet ds = Utilidades.Insertar(CMD);
                MessageBox.Show("Operacion Exitosa");
            }
            else if (btn == 1)
            {
                ModificarAlumno VenModAl = new ModificarAlumno();
                VenModAl.Show();
                HomeAdmin Nombre = new HomeAdmin();
                Nombre.setNombre(textBox1.Text);
                MessageBox.Show(Nombre.nom);
            }
            else if (btn == 2)
            {
                string CMD = string.Format("DELETE FROM Usuarios WHERE usuario = '" + textBox1.Text + "'");
                DataSet ds = Utilidades.Eliminar(CMD);
                MessageBox.Show("Usuario eliminado para siempre");
            }
        }

        private void modificarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Alumno a modificar:";
            label1.Visible = false;
            textBox1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            label1.Visible = true;
            Btn_aceptar.Visible = true;
            btn = 1;
        }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Alumno:";
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            Btn_aceptar.Visible = true;
            btn = 2;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void HomeAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void listaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAlumnos lista = new ListaAlumnos();
            lista.Show();
        }
    }
}
