
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
            DataTable Nombres = Utilidades.ObtenerEmpresa("SELECT nombre FROM Empresas WHERE check_baja='1'");
            for (int i = 0; i < Nombres.Rows.Count; i++)
            {
                comboBoxEmpresa.Items.Add(Nombres.Rows[i]["nombre"]);
                comboBoxEmpresa.SelectedIndex = 0;
            }
            DataTable Nombres2 = Utilidades.ObtenerEmpresa("SELECT nombre FROM Empresas WHERE check_baja='0'");
            for (int i = 0; i < Nombres2.Rows.Count; i++)
            {
                comboBoxHabilitar.Items.Add(Nombres2.Rows[i]["nombre"]);
                comboBoxHabilitar.SelectedIndex = 0;
            }
        }

        private void agregarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            option = 1;
            textBoxOldPass.Visible = false;
            textBoxNewPass.Visible = false;
            textBoxNewPass2.Visible = false;
            comboBoxEmpresa.Visible = false;
            comboBoxHabilitar.Visible = false;
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
                    try
                    {
                        Utilidades.Consulta("INSERT INTO Empresas(nombre, RUC, Telefono, Direccion, check_baja) VALUES('" + textBox1.Text.Trim() + "', '" + textBox3.Text.Trim() + "', '" + textBox2.Text.Trim() + "', '" + textBox4.Text.Trim() + "', 1)");
                        MessageBox.Show("Operacion Exitosa", "Aviso");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Dato invalido", "Error");
                    }
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
                    try
                    {
                        SqlDataReader control = Utilidades.Consulta("SELECT * FROM Usuarios WHERE codigo='" + textBox1.Text.Trim() + "'");
                        if (control.Read())
                        {
                            MessageBox.Show("El Alumno ya existe", "Error");
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
                    catch(Exception)
                    {
                        MessageBox.Show("Valor incorrecto","Error");
                    }
                }
                else
                {
                    MessageBox.Show("Porfavor complete todos los campos", "Aviso");
                }
            }
            else if(option==5)
            {
                Utilidades.Ejecutar("UPDATE Empresas SET check_baja=0 WHERE nombre='"+comboBoxEmpresa.Text+"'");
                MessageBox.Show("Se ha Anulado la empresa "+comboBoxEmpresa.Text);
                comboBoxEmpresa.Items.Clear();
                comboBoxHabilitar.Items.Clear();
                DataTable Nombres = Utilidades.ObtenerEmpresa("SELECT nombre FROM Empresas WHERE check_baja='1'");
                for (int i = 0; i < Nombres.Rows.Count; i++)
                {
                    comboBoxEmpresa.Items.Add(Nombres.Rows[i]["nombre"]);
                    comboBoxEmpresa.SelectedIndex = 0;
                }
                DataTable Nombres2 = Utilidades.ObtenerEmpresa("SELECT nombre FROM Empresas WHERE check_baja='0'");
                for (int i = 0; i < Nombres2.Rows.Count; i++)
                {
                    comboBoxHabilitar.Items.Add(Nombres2.Rows[i]["nombre"]);
                    comboBoxHabilitar.SelectedIndex = 0;
                }
                comboBoxHabilitar.Visible = false;
                comboBoxEmpresa.Visible = false;
                BtnAceptar.Visible = false;
                BtnCancelar.Visible = false;
                label3.Visible = false;
            }
            else if (option == 6)
            {
                Utilidades.Ejecutar("UPDATE Empresas SET check_baja=1 WHERE nombre='" + comboBoxHabilitar.Text + "'");
                MessageBox.Show("Se ha Habilitado la empresa " + comboBoxHabilitar.Text);
                comboBoxEmpresa.Items.Clear();
                comboBoxHabilitar.Items.Clear();
                DataTable Nombres = Utilidades.ObtenerEmpresa("SELECT nombre FROM Empresas WHERE check_baja='1'");
                for (int i = 0; i < Nombres.Rows.Count; i++)
                {
                    comboBoxEmpresa.Items.Add(Nombres.Rows[i]["nombre"]);
                    comboBoxEmpresa.SelectedIndex = 0;
                }
                DataTable Nombres2 = Utilidades.ObtenerEmpresa("SELECT nombre FROM Empresas WHERE check_baja='0'");
                for (int i = 0; i < Nombres2.Rows.Count; i++)
                {
                    comboBoxHabilitar.Items.Add(Nombres2.Rows[i]["nombre"]);
                    comboBoxHabilitar.SelectedIndex = 0;
                }
                comboBoxHabilitar.Visible = false;
                comboBoxEmpresa.Visible = false;
                BtnAceptar.Visible = false;
                BtnCancelar.Visible = false;
                label3.Visible = false;
                comboBoxEmpresa.Text = "";
                comboBoxHabilitar.Text = "";
            }
            else if(option==7)
            {
                SqlDataReader doc = Utilidades.Consulta("SELECT usuario FROM Usuarios WHERE codigo='"+textBox3.Text.Trim()+"'");
                if(doc.Read())
                {
                    MessageBox.Show("El Docente ya existe","Error");
                    textBox1.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    Utilidades.Ejecutar("INSERT INTO Usuarios (usuario,check_usu,codigo,contraseña) values('"+textBox1.Text.Trim()+"',1,'"+ textBox3.Text.Trim() + "',101010)");
                    MessageBox.Show("Operacion Exitosa","Aviso");
                    textBox1.Text = "";
                    textBox3.Text = "";
                }
            }
            else if(option==8)
            {
                SqlDataReader elim = Utilidades.Consulta("SELECT usuario FROM Usuarios WHERE codigo='" + textBox3.Text.Trim() + "' AND usuario='"+textBox1.Text.Trim()+"'");
                if(elim.Read())
                {
                    Utilidades.Ejecutar("DELETE FROM Usuarios WHERE codigo = '" + textBox3.Text.Trim() + "'");
                    MessageBox.Show("Operacion Exitosa", "Aviso");
                    textBox1.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Error");
                    textBox1.Text = "";
                    textBox3.Text = "";
                }
            }
            else if(option==9)
            {
                SqlDataReader usu = Utilidades.Consulta("SELECT contraseña FROM Usuarios WHERE usuario='"+labelAux.Text+"'");
                if(usu.Read())
                {
                    string pass = usu["contraseña"].ToString();
                    if(textBox5.Text==labelAux.Text && pass==textBoxOldPass.Text)
                    {
                        if(textBoxNewPass.Text.Trim() != ""&&textBoxNewPass2.Text.Trim()==textBoxNewPass.Text.Trim())
                        {
                            Utilidades.Ejecutar("UPDATE Usuarios SET contraseña='"+ textBoxNewPass.Text.Trim() + "' WHERE usuario = '"+labelAux.Text+"'");
                            MessageBox.Show("Operacion Exitosa", "Aviso");
                            textBoxNewPass.Text = "";
                            textBoxNewPass2.Text = "";
                            textBoxOldPass.Text = "";
                            textBox5.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("La contraseña nueva no se acepta","Error");
                            textBoxNewPass.Text = "";
                            textBoxNewPass2.Text = "";
                            textBoxOldPass.Text = "";
                            textBox5.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta", "Error");
                        textBoxNewPass.Text = "";
                        textBoxNewPass2.Text = "";
                        textBoxOldPass.Text = "";
                        textBox5.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Error de usuario","Error");
                    textBoxNewPass.Text = "";
                    textBoxNewPass2.Text = "";
                    textBoxOldPass.Text = "";
                    textBox5.Text = "";
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
                            Utilidades.Ejecutar("DELETE FROM Usuarios WHERE usuario = '" + usuario.Trim() + "'");
                            MessageBox.Show("Operacion exitosa");
                            textBox1.Text = "";
                        }
                        else if (option == 2 && usuario == textBox1.Text.Trim())
                        {
                            SqlDataReader usu = Utilidades.Consulta("SELECT check_usu FROM Usuarios WHERE usuario ='"+usuario+"'");
                            if(usu.Read())
                            {
                                string check_usu = usu["check_usu"].ToString();
                                if(check_usu=="2")
                                {
                                    ModificarAlumno modAl = new ModificarAlumno();
                                    modAl.label11.Text = usuario;
                                    MessageBox.Show("Usuario valido");
                                    this.Hide();
                                    //modAl.MostrarDatos(textBox1.Text, carrera, curso, codigo, creditos, id);
                                    modAl.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Usuario invalido");
                                }
                            }
                            
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
            comboBoxEmpresa.Visible = false;
            comboBoxHabilitar.Visible = false;
            textBoxOldPass.Visible = false;
            textBoxNewPass.Visible = false;
            textBoxNewPass2.Visible = false;
            BtnAceptar.Visible = false;
            BtnCancelar.Visible = false;
        }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            option = 3;
            textBoxOldPass.Visible = false;
            textBoxNewPass.Visible = false;
            textBoxNewPass2.Visible = false;
            comboBoxEmpresa.Visible = false;
            comboBoxHabilitar.Visible = false;
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
            textBoxOldPass.Visible = false;
            textBoxNewPass.Visible = false;
            textBoxNewPass2.Visible = false;
            comboBoxHabilitar.Visible = false;
            comboBoxEmpresa.Visible = false;
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
            textBoxOldPass.Visible = false;
            textBoxNewPass.Visible = false;
            textBoxNewPass2.Visible = false;
            comboBoxHabilitar.Visible = false;
            comboBoxEmpresa.Visible = false;
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
            
            this.Dispose();
            
        }

        private void anularEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxOldPass.Visible = false;
            textBoxNewPass.Visible = false;
            textBoxNewPass2.Visible = false;
            comboBoxEmpresa.Items.Clear();
            DataTable Nombres = Utilidades.ObtenerEmpresa("SELECT nombre FROM Empresas WHERE check_baja='1'");
            for (int i = 0; i < Nombres.Rows.Count; i++)
            {
                comboBoxEmpresa.Items.Add(Nombres.Rows[i]["nombre"]);
                comboBoxEmpresa.SelectedIndex = 0;
            }
            option = 5;
            comboBoxHabilitar.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label1.Text = "";
            label3.Text = "Seleccione la Empresa:";
            label2.Text = "";
            label4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label5.Visible = false;
            textBox5.Visible = false;
            comboBoxCarrera.Visible = false;
            comboBoxCurso.Visible = false;
            comboBoxEmpresa.Visible = true;
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
        }

        private void validarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxOldPass.Visible = false;
            textBoxNewPass.Visible = false;
            textBoxNewPass2.Visible = false;
            comboBoxHabilitar.Items.Clear();
            DataTable Nombres2 = Utilidades.ObtenerEmpresa("SELECT nombre FROM Empresas WHERE check_baja='0'");
            for (int i = 0; i < Nombres2.Rows.Count; i++)
            {
                comboBoxHabilitar.Items.Add(Nombres2.Rows[i]["nombre"]);
                comboBoxHabilitar.SelectedIndex = 0;
            }
            option = 6;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label1.Text = "";
            label3.Text = "Seleccione la Empresa:";
            label2.Text = "";
            label4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label5.Visible = false;
            textBox5.Visible = false;
            comboBoxCarrera.Visible = false;
            comboBoxCurso.Visible = false;
            comboBoxEmpresa.Visible = false;
            comboBoxHabilitar.Visible = true;
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
        }

        private void agregarDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Docente:";
            textBoxOldPass.Visible = false;
            textBoxNewPass.Visible = false;
            textBoxNewPass2.Visible = false;
            comboBoxHabilitar.Visible = false;
            comboBoxEmpresa.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            option = 7;
            label2.Visible = false;
            label3.Text = "CI:";
            label3.Visible = true;
            label4.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = true;
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

        private void eliminarDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Nombre del Docente:";
            textBoxOldPass.Visible = false;
            textBoxNewPass.Visible = false;
            textBoxNewPass2.Visible = false;
            comboBoxHabilitar.Visible = false;
            comboBoxEmpresa.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            option = 8;
            label2.Visible = false;
            label3.Text = "CI:";
            label3.Visible = true;
            label4.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = true;
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

        private void listaDeDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDocente vd = new ListaDocente();
            vd.Show();
        }

        private void cambiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label5.Text = "Nombre de Usuario:";
            label1.Visible = true;
            label1.Text = "Contraseña vieja:";
            label3.Visible = true;
            label3.Text = "Contraseña nueva:";
            label2.Visible = true;
            label2.Text = "Confirma contraseña nueva:";
            textBox5.Visible = true;
            textBoxOldPass.Visible = true;
            textBoxNewPass.Visible = true;
            textBoxNewPass2.Visible = true;
            label4.Visible = false;
            textBox4.Visible = false;
            comboBoxCarrera.Visible = false;
            comboBoxCurso.Visible = false;
            comboBoxEmpresa.Visible = false;
            comboBoxHabilitar.Visible = false;
            BtnAceptar.Visible = true;
            BtnCancelar.Visible = true;
            option = 9;
        }
    }
}
