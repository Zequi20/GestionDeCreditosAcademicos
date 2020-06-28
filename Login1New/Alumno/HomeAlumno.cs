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
using Login1New.BDusuarioDataSetTableAdapters;

namespace Login1New
{
    public partial class HomeAlumno : Form
    {
        public HomeAlumno()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void HomeAlumno_Load(object sender, EventArgs e)
        {
            SqlDataReader datos = Utilidades.Consulta("Select * FROM Usuarios WHERE usuario = '"+labelAux2.Text+"'");
            if(datos.Read())
            {
                label5.Text = datos["usuario"].ToString();
                label6.Text = datos["carrera"].ToString();
                label7.Text = datos["codigo"].ToString();
                label8.Text = datos["curso"].ToString();
                label9.Text = datos["creditos_acade"].ToString();
            }
        }

        private void reglasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReglamentoCAE reg = new ReglamentoCAE();
            reg.Show();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            SqlDataReader usu = Utilidades.Consulta("SELECT contraseña FROM Usuarios WHERE usuario='" + labelAux2.Text + "'");
            if (usu.Read())
            {
                string pass = usu["contraseña"].ToString();
                if (textBox1.Text == labelAux2.Text && pass == textBox2.Text)
                {
                    if (textBox3.Text.Trim() != "" && textBox4.Text.Trim() == textBox3.Text.Trim())
                    {
                        Utilidades.Ejecutar("UPDATE Usuarios SET contraseña='" + textBox3.Text.Trim() + "' WHERE usuario = '" + labelAux2.Text + "'");
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

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnCancelar.Visible = false;
            BtnAtras.Visible = true;
            BtnAceptar.Visible = false;
            nom.Visible = true;
            label1.Text = "Carrera:";
            label1.Visible = true;
            label2.Text = "Codigo:";
            label2.Visible = true;
            label3.Text = "Curso:";
            label3.Visible = true;
            label4.Text = "Creditos:";
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nom.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label1.Text = "Nombre del usuario:";
            label1.Visible = true;
            label2.Text = "Contraseña vieja:";
            label2.Visible = true;
            label3.Text = "Contraseña nueva:";
            label3.Visible = true;
            label4.Text = "Confirmar contraseña nueva:";
            label4.Visible = true;
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnCancelar.Visible = false;
            BtnAtras.Visible = false;
            BtnAceptar.Visible = false;
            nom.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            BtnCancelar.Visible = false;
            BtnAtras.Visible = false;
            BtnAceptar.Visible = false;
            nom.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
        }

        private void HomeAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
