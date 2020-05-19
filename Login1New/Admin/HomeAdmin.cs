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
            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE usuario = '{0}'", textBox1.Text);
                DataSet ds = Utilidades.Ejecutar(CMD);
                string usuario = ds.Tables[0].Rows[0]["usuario"].ToString().Trim();
                string carrera= ds.Tables[0].Rows[0]["carrera"].ToString().Trim();
                string curso = ds.Tables[0].Rows[0]["curso"].ToString().Trim();
                string codigo = ds.Tables[0].Rows[0]["codigo"].ToString().Trim();
                string creditos = ds.Tables[0].Rows[0]["creditos_acade"].ToString().Trim();

                if (option == 1 && usuario == textBox1.Text.Trim())
                {
                    Utilidades.Ejecutar("INSERT INTO Usuarios (usuario, contraseña, check_usu) VALUES('" + textBox1.Text.Trim() + "', '" + textBox2.Text + "',2);");
                    MessageBox.Show("Operacion exitosa");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else if (option == 3 && usuario == textBox1.Text.Trim())
                {
                    Utilidades.Ejecutar("DELETE FROM Usuarios WHERE usuario = '" + textBox1.Text.Trim() + "';");
                    MessageBox.Show("Operacion exitosa");
                    textBox1.Text = "";
                }
                else if (option == 2 && usuario == textBox1.Text.Trim())
                {
                    ModificarAlumno modAl = new ModificarAlumno();
                    MessageBox.Show("Usuario valido");
                    this.Hide();
                    modAl.MostrarDatos(textBox1.Text, carrera, curso, codigo, creditos);
                    modAl.Show();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Se ha producido un error." + error.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            BtnAceptar.Visible = false;
            BtnCancelar.Visible = false;
        }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            option = 3;
            label1.Text = "Nombre del Alumno:";
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

        private void modificarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Alumno:";
            label1.Visible = true;
            textBox1.Visible=true;
            option = 2;
            label2.Visible = false;
            textBox2.Visible = false;
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
        }
    }
}
