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
    public partial class ModificarAlumno : Form
    {
        string nombre;
        string carreFa;
        string cod;
        string cur;
        string credi;
        public ModificarAlumno()
        {
            InitializeComponent();
            MostrarDatos(nombre, carreFa, cod, cur, credi);
        }

        public void MostrarDatos(string nombre, string carreFa, string cur, string cod, string credi)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label3.Text = nombre;
            label4.Text = carreFa;
            label6.Text = cod;
            label8.Text = cur;
            label10.Text = credi;
            BtnAceptarCamb.Visible = false;
            BtnCancelarCamb.Visible = false;
        }

        private void BtnModAl_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            textBox1.Text = label3.Text;
            textBox2.Text = label6.Text;
            comboBox1.Text = label4.Text;
            comboBox2.Text = label8.Text;
            BtnModAl.Visible = false;
            BtnCancelarCamb.Visible = true;
            BtnAceptarCamb.Visible = true;
        }

        private void BtnAceptarCamb_Click(object sender, EventArgs e)
        {
            string newNom, newCarrera, newCurso, newcod, newCredi;
            if (textBox1.Text != "" && textBox1.Text.Length >= 5)
            {
                newNom = textBox1.Text;
                textBox1.Visible = false;
                label3.Visible = true;
                label3.Text = newNom;
                newCarrera = comboBox1.Text;
                label4.Text = newCarrera;
                comboBox1.Visible = false;
                label4.Visible = true;
                newcod = textBox2.Text;
                label6.Text = newcod;
                label6.Visible = true;
                textBox2.Visible = false;
                newCurso = comboBox2.Text;
                label8.Text = newCurso;
                label8.Visible = true;
                comboBox2.Visible = false;             
            }
        }

        private void BtnCancelarCamb_Click(object sender, EventArgs e)
        {
        }
    }
}
