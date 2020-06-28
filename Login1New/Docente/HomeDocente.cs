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
using System.Data.SqlClient;

namespace Login1New
{
    public partial class HomeDocente : Form
    {
        
        public HomeDocente()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void listarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeAlumnos n = new ListaDeAlumnos();
            n.Show();
        }

        private void reglamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReglamentoCAE reglas = new ReglamentoCAE();
            reglas.Show();
        }

        private void cambiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
        }

        private void HomeDocente_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader usu = Utilidades.Consulta("SELECT contraseña FROM Usuarios WHERE usuario='" + labelAux1.Text + "'");
            if (usu.Read())
            {
                string pass = usu["contraseña"].ToString();
                if (textBox1.Text == labelAux1.Text && pass == textBox2.Text)
                {
                    if (textBox3.Text.Trim() != "" && textBox4.Text.Trim() == textBox3.Text.Trim())
                    {
                        Utilidades.Ejecutar("UPDATE Usuarios SET contraseña='" + textBox3.Text.Trim() + "' WHERE usuario = '" + labelAux1.Text + "'");
                        MessageBox.Show("Operacion Exitosa", "Aviso");
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox2.Text = "";
                        textBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("La contraseña nueva no se acepta", "Error");
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox2.Text = "";
                        textBox1.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Error");
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox2.Text = "";
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Error de usuario", "Error");
                textBox3.Text = "";
                textBox4.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            BtnAceptar.Visible = false;
            BtnCancelar.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HomeDocente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
