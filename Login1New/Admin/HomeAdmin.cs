using Login1New.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1New
{
    public partial class HomeAdmin : Form
    {
        public int option = 0;
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void reglasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void agregarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            option = 1;
            label1.Text = "Nombre" ;
            label2.Text = "Contraseña";
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
        }

        public void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(option == 1)
            {
                Utilidades.Ejecutar("INSERT INTO Usuarios (usuario, contraseña, check_usu) VALUES('"+textBox1.Text.Trim()+"', '"+textBox2.Text+"',2);");
                MessageBox.Show("Operacion exitosa");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else if(option == 3)
            {
                Utilidades.Ejecutar("DELETE FROM Usuarios WHERE usuario = '" + textBox1.Text.Trim() + "';");
                MessageBox.Show("Operacion exitosa");
                textBox1.Text = "";
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            option = 3;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            BtnAceptar.Visible = false;
            BtnCancelar.Visible = false;
        }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Alumno";
            label1.Visible = true;
            textBox1.Visible = true;
            BtnAceptar.Visible = true;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void listaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAlumnos lista = new ListaAlumnos();
            lista.Show();
        }
    }
}
