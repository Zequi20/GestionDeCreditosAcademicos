
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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Login1New
{
    public partial class HomeAdmin : Form
    {
        public int option = 0;
        public string id="error";
        ReglamentoCAE v = new ReglamentoCAE();
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void reglasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            this.Focus();
            comboBoxCurso.SelectedIndex = 0;
            comboBoxCarrera.SelectedIndex = 0;
        }

        private void agregarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            option = 1;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = true;
            textBox5.Visible = true;
            comboBoxCarrera.Visible = true;
            comboBoxCurso.Visible = true;
            label5.Text = "Nombre:";
            label1.Text = "Codigo:";
            label3.Text = "Carrera:";
            label2.Text = "Curso:";
            label4.Text = "Creditos Academicos:";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
        }

        public void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (option == 4)
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "")
                {
                    Utilidades.Consulta("INSERT INTO Empresas(nombre, RUC, Telefono, Direccion, check_baja) VALUES('" + textBox1.Text.Trim() + "', '" + textBox3.Text.Trim() + "', '" + textBox2.Text.Trim() + "', '" + textBox4.Text.Trim() + "', 1)");
                    MessageBox.Show("Operacion Exitosa", "Aviso");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    MessageBox.Show("Porfavor complete todos los campos", "Aviso");
                }
            }
            else if (option == 1)
            {
                if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    SqlDataReader control = Utilidades.Consulta("SELECT * FROM Usuarios WHERE codigo='"+textBox1.Text.Trim()+"'");
                    if(control.Read())
                    {
                        MessageBox.Show("El Alumno ya existe","Error");
                    }
                    else
                    {
                        Utilidades.Ejecutar("INSERT INTO Usuarios (usuario, contraseña, check_usu,carrera,codigo,creditos_acade,curso) VALUES('" + textBox5.Text.Trim() + "', '1234567',2,'" + comboBoxCarrera.Text + "','" + textBox1.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + comboBoxCurso.Text + "')");
                        MessageBox.Show("Operacion exitosa");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Porfavor complete todos los campos", "Aviso");
                }
            }
            else
            {
                try
                {
                    SqlDataReader datos = Utilidades.Consulta("Select * FROM Usuarios WHERE usuario = '"+ textBox1.Text.Trim()+ "'");
                    if (datos.Read())
                    {
                        string usuario = textBox1.Text;
                        string carrera = datos["carrera"].ToString().Trim();
                        string curso = datos["curso"].ToString().Trim();
                        string codigo = datos["codigo"].ToString().Trim();
                        string creditos = datos["creditos_acade"].ToString().Trim();
                        id = datos["id_usuario"].ToString().Trim();
                        if (option == 3 && usuario == usuario.Trim())
                        {
                            Utilidades.Ejecutar("DELETE FROM Usuarios WHERE usuario = '" + usuario.Trim() + "';");
                            MessageBox.Show("Operacion exitosa");
                            textBox1.Text = "";
                        }
                        else if (option == 2 && usuario == textBox1.Text.Trim())
                        {
                            ModificarAlumno modAl = new ModificarAlumno();
                            modAl.label11.Text = usuario;
                            MessageBox.Show("Usuario valido");
                            this.Hide();
                            //modAl.MostrarDatos(textBox1.Text, carrera, curso, codigo, creditos, id);
                            modAl.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Se ha producido un error." + error.Message);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            comboBoxCarrera.Visible = false;
            comboBoxCurso.Visible = false;
            BtnAceptar.Visible = false;
            BtnCancelar.Visible = false;
        }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            option = 3;
            label1.Text = "Nombre del Alumno:";
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label5.Visible = false;
            textBox5.Visible = false;
            comboBoxCarrera.Visible = false;
            comboBoxCurso.Visible = false;
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeAlumnos lista = new ListaDeAlumnos();
            lista.Show();
        }

        private void modificarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Alumno:";
            label1.Visible = true;
            textBox1.Visible=true;
            option = 2;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label5.Visible = false;
            textBox5.Visible = false;
            comboBoxCarrera.Visible = false;
            comboBoxCurso.Visible = false;
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void verReglamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.Show();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void agraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            option = 4;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label1.Text = "Nombre de la Empresa:";
            label3.Text = "RUC de la Empresa:";
            label2.Text = "Telefono de la Empresa:";
            label4.Text = "Direccion de la Empresa:";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label5.Visible = false;
            textBox5.Visible = false;
            comboBoxCarrera.Visible = false;
            comboBoxCurso.Visible = false;
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HomeAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
