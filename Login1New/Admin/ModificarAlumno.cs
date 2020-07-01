using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Login1New.Admin;

namespace Login1New
{
    public partial class ModificarAlumno : Form
    {
        int cons=0;
        bool check = true; 
        Credito cae = new Credito(); // Clase que realiza los calculos de los creditos
        EmpresaAlumno empresa = new EmpresaAlumno(); //ventana que muestra informacion sobre las empresas
        public ModificarAlumno()
        {
            InitializeComponent();
        }

        private void BtnModAl_Click(object sender, EventArgs e)
        {
            Aceptar.Visible = false;
            button1.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            name.Visible = true;
            codigo.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            name.Text = label3.Text;
            codigo.Text = label6.Text;
            comboBox1.Text = label4.Text;
            comboBox2.Text = label8.Text;
            BtnModAl.Visible = false;
            BtnCancelarCamb.Visible = true;
            BtnAceptarCamb.Visible = true;
            agregarHoras.Visible = true;
            menuStrip1.Visible = true;
            verEmpresasToolStrip.Visible = true;
        }

        private void BtnAceptarCamb_Click(object sender, EventArgs e)
        {
            if(BtnModAl.Visible==true)
            {
                BtnModAl.Visible = false;
                menuStrip1.Visible = true;
            }
            else if(BtnModAl.Visible == false)
            {
                BtnModAl.Visible = true;
                menuStrip1.Visible = false;
                BtnAceptarCamb.Visible = false;
            }
            string newNom, newCarrera, newCurso, newcod, newCredi;
            if (name.Text != "" && name.Text.Length >= 5)
            {
                newNom = name.Text;
                name.Visible = false;
                label3.Visible = true;
                label3.Text = newNom;
                newCarrera = comboBox1.Text;
                label4.Text = newCarrera;
                comboBox1.Visible = false;
                label4.Visible = true;
                newcod = codigo.Text;
                label6.Text = newcod;
                label6.Visible = true;
                codigo.Visible = false;
                newCurso = comboBox2.Text;
                label8.Text = newCurso;
                label8.Visible = true;
                comboBox2.Visible = false;
                Utilidades.Ejecutar("UPDATE Usuarios SET carrera = '" + comboBox1.Text + "'  WHERE usuario = '" + label11.Text + "'");
                Utilidades.Ejecutar("UPDATE Usuarios SET usuario = '" + name.Text + "'  WHERE usuario = '" + label11.Text.Trim() + "'");
                label11.Text = name.Text;
                Utilidades.Ejecutar("UPDATE Usuarios SET curso = '" + comboBox2.Text + "'  WHERE usuario = '" + label11.Text.Trim() + "'");
                Utilidades.Ejecutar("UPDATE Usuarios SET codigo = '" + codigo.Text + "'  WHERE usuario = '" + label11.Text.Trim() + "'");
            }
        }

        private void BtnCancelarCamb_Click(object sender, EventArgs e)
        {
            HomeAdmin ventana = new HomeAdmin();
            this.Dispose();
            ventana.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {
            //Se obtiene los datos del alumno
            SqlDataReader reader = Utilidades.Consulta("SELECT usuario,carrera,codigo,curso,creditos_acade FROM Usuarios WHERE usuario ='"+label11.Text.Trim()+"'");
            if(reader.Read())
            {
                label3.Text = reader["usuario"].ToString();
                label4.Text = reader["carrera"].ToString();
                label6.Text = reader["codigo"].ToString();
                label8.Text = reader["curso"].ToString();
                label10.Text = reader["creditos_acade"].ToString();
            }
            empresa.labelNombre.Text = label3.Text;
            //Se obtienen los nombres de las empresas en un Data Table y luego se listan
            DataTable Nombres=Utilidades.ObtenerEmpresa("SELECT nombre FROM Empresas WHERE check_baja='1'");
            for(int i=0;i<Nombres.Rows.Count;i++)
            {
                comboBoxPas.Items.Add(Nombres.Rows[i]["nombre"]);
                comboBoxPas.SelectedIndex = 0;
            }
        }

        private void agregarHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(agregarHoras.Visible==true)
            {
                agregarHoras.Visible = false;
            }
            else
            {
                agregarHoras.Visible = true;
            }
            label1.Text="Cantidad de horas:";
            BtnAceptarCamb.Visible = false;
            Aceptar.Visible = true;
            txtAyudantia.Visible = true;
            name.Text = "";
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            codigo.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            label7.Text = "Semanas totales de la materia:";
            label9.Visible = false;
            label10.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxPas.Visible == false)
            {
                comboBoxPas.Visible = true;
                label7.Text = "Empresa";
                label7.Visible = true;
            }
            else
            {
                comboBoxPas.Visible = false;
                label7.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(check==true)
            {
                label7.Text = "Semanas totales de la materia:";
                label7.Visible = false;
                txtAyudantia.Visible = false;
                check = false;
            }
            else
            {
                label7.Text = "Semanas totales de la materia:";
                label7.Visible = true;
                txtAyudantia.Visible = true;
                check = true;
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            verEmpresasToolStrip.Visible = false;
            int horas = 0, semanas = 0, creditos = 0, creditosNew=0;
            int residuo=0, residuoNew=0;
            try
            {
                horas=Int32.Parse(name.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Inserte un valor valido","Valor Invalido");
            }
        
            if(radioButton1.Checked==true)
            {
                cons = 16;
                try
                {
                    semanas = Int32.Parse(txtAyudantia.Text.Trim());
                }
                catch (Exception)
                {
                    MessageBox.Show("Formato Invalido");
                }
             
                SqlDataReader reg = Utilidades.Consulta("SELECT creditos_acade,res_ayudantia FROM Usuarios WHERE usuario='"+label3.Text+"'");
                if (reg.Read())
                {
                    string auxRes= reg["res_ayudantia"].ToString();
                    if(auxRes=="")
                    {
                        auxRes = "0";
                    }
                    residuo = Convert.ToInt32(auxRes);
                    creditos = Int32.Parse(reg["creditos_acade"].ToString());
                    semanas = semanas - 2;
                    cae.calcularAyudantia(horas, semanas);
                    creditosNew = creditos + cae.credito;
                    residuoNew = residuo + cae.residuo;
                    if(residuoNew>=16)
                    {
                        creditosNew++;
                        residuoNew -= 16;
                    }
                    //Se modifican los datos en la base de datos
                    Utilidades.Consulta("UPDATE Usuarios SET creditos_acade = '"+creditosNew+ "'  WHERE usuario = '" + label3.Text + "'");
                    Utilidades.Consulta("UPDATE Usuarios SET res_ayudantia = '"+residuoNew+"'  WHERE usuario = '" + label3.Text + "'");
                    MessageBox.Show("Creditos acumulados: " + creditosNew + "\nResiduo a favor: " + residuoNew, "Info");
                    name.Text = "";
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if(radioButton2.Checked==true)
            {
                cons = 48;
                SqlDataReader reg = Utilidades.Consulta("SELECT creditos_acade,res_pasantia FROM Usuarios WHERE usuario='" + label3.Text + "'");
                if (reg.Read())
                {
                    string auxRes = reg["res_pasantia"].ToString();
                    if (auxRes == "")
                    {
                        auxRes = "0";
                    }
                    residuo = Convert.ToInt32(auxRes);
                    creditos = Int32.Parse(reg["creditos_acade"].ToString());
                    cae.calcular(horas, cons);
                    creditosNew = creditos + cae.credito;
                    residuoNew = residuo + cae.residuo;
                    if (residuoNew >= cons)
                    {
                        creditosNew++;
                        residuoNew -= cons;
                    }
                    Utilidades.Consulta("UPDATE Usuarios SET creditos_acade = '" + creditosNew + "'  WHERE usuario = '" + label3.Text + "'");
                    Utilidades.Consulta("UPDATE Usuarios SET res_pasantia = '" + residuoNew + "'  WHERE usuario = '" + label3.Text + "'");
                    SqlDataReader cod = Utilidades.Consulta("SELECT cod_empresa FROM Empresas WHERE nombre='" + comboBoxPas.Text.Trim() + "'");
                    if (cod.Read())
                    {
                        Utilidades.Consulta("INSERT INTO Pasantia(cod_alumno, nombre, horas, cod_empresa) VALUES('" + label6.Text + "','" + label3.Text + "','" + name.Text + "','"+cod["cod_empresa"].ToString()+"')");
                    }
                    MessageBox.Show("Operacion Exitosa","Aviso");
                    name.Text = "";
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if (radioButton3.Checked == true)
            {
                cons = 16;
                SqlDataReader reg = Utilidades.Consulta("SELECT creditos_acade,res_charlaCyT FROM Usuarios WHERE usuario='" + label3.Text + "'");
                if (reg.Read())
                {
                    string auxRes = reg["res_charlaCyT"].ToString();
                    if (auxRes == "")
                    {
                        auxRes = "0";
                    }
                    residuo = Convert.ToInt32(auxRes);
                    creditos = Int32.Parse(reg["creditos_acade"].ToString());
                    cae.calcular(horas, cons);
                    creditosNew = creditos + cae.credito;
                    residuoNew = residuo + cae.residuo;
                    if (residuoNew >= cons)
                    {
                        creditosNew++;
                        residuoNew -= cons;
                    }
                    Utilidades.Consulta("UPDATE Usuarios SET creditos_acade = '" + creditosNew + "'  WHERE usuario = '" + label3.Text + "'");
                    Utilidades.Consulta("UPDATE Usuarios SET res_charlaCyT = '" + residuoNew + "'  WHERE usuario = '" + label3.Text + "'");
                    MessageBox.Show("Creditos acumulados: " + creditosNew + "\nResiduo a favor: " + residuoNew, "Info");
                    MessageBox.Show("Operacion Exitosa", "Aviso");
                    name.Text = "";
                }

            }
            else if (radioButton4.Checked == true)
            {
                cons = 32;
                SqlDataReader reg = Utilidades.Consulta("SELECT creditos_acade,res_charlaNoCyT FROM Usuarios WHERE usuario='" + label3.Text + "'");
                if (reg.Read())
                {
                    string auxRes = reg["res_charlaNoCyT"].ToString();
                    if (auxRes == "")
                    {
                        auxRes = "0";
                    }
                    residuo = Convert.ToInt32(auxRes);
                    creditos = Int32.Parse(reg["creditos_acade"].ToString());
                    cae.calcular(horas, cons);
                    creditosNew = creditos + cae.credito;
                    residuoNew = residuo + cae.residuo;
                    if (residuoNew >= cons)
                    {
                        creditosNew++;
                        residuoNew -= cons;
                    }
                    Utilidades.Consulta("UPDATE Usuarios SET creditos_acade = '" + creditosNew + "'  WHERE usuario = '" + label3.Text + "'");
                    Utilidades.Consulta("UPDATE Usuarios SET res_charlaNoCyT = '" + residuoNew + "'  WHERE usuario = '" + label3.Text + "'");
                    MessageBox.Show("Creditos acumulados: " + creditosNew + "\nResiduo a favor: " + residuoNew, "Info");
                    MessageBox.Show("Operacion Exitosa", "Aviso");
                    name.Text = "";
                }
            }
            else if (radioButton5.Checked == true)
            {
                cons = 48;
                SqlDataReader reg = Utilidades.Consulta("SELECT creditos_acade,res_otros FROM Usuarios WHERE usuario='" + label3.Text + "'");
                if (reg.Read())
                {
                    string auxRes = reg["res_otros"].ToString();
                    if (auxRes == "")
                    {
                        auxRes = "0";
                    }
                    residuo = Convert.ToInt32(auxRes);
                    creditos = Int32.Parse(reg["creditos_acade"].ToString());
                    cae.calcular(horas, cons);
                    creditosNew = creditos + cae.credito;
                    residuoNew = residuo + cae.residuo;
                    if (residuoNew >= cons)
                    {
                        creditosNew++;
                        residuoNew -= cons;
                    }
                    Utilidades.Consulta("UPDATE Usuarios SET creditos_acade = '" + creditosNew + "'  WHERE usuario = '" + label3.Text + "'");
                    Utilidades.Consulta("UPDATE Usuarios SET res_otros = '" + residuoNew + "'  WHERE usuario = '" + label3.Text + "'");
                    MessageBox.Show("Creditos acumulados: " + creditosNew + "\nResiduo a favor: " + residuoNew, "Info");
                    MessageBox.Show("Operacion Exitosa", "Aviso");
                    name.Text = "";
                }
            }

        }

        private void verEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empresa.Show();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            ModificarAlumno inst = new ModificarAlumno();
            inst.label11.Text = label3.Text;
            this.Dispose();
            inst.Show();
            
        }

        private void ModificarAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeAdmin ventana = new HomeAdmin();
            this.Dispose();
            ventana.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
