using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login1New
{
    public partial class Reglamento : Form
    {
        public Reglamento()
        {
            InitializeComponent();
            button3.Visible = false;
            StreamReader leer = new StreamReader(@"C:\Users\lucia\OneDrive\Desktop\Archivo.txt");
            try
            {
                textBox1.Text = leer.ReadLine();
                textBox1.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Error2");
            }
            leer.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            button1.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button1.Visible = true;
            StreamWriter escribir = new StreamWriter(@"C:\Users\lucia\OneDrive\Desktop\Archivo.txt",false);
            try
            {
                escribir.WriteLine(""+ textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error1");
            }
            escribir.Close();
            StreamReader leer = new StreamReader(@"C:\Users\lucia\OneDrive\Desktop\Archivo.txt");
            try
            {
                textBox1.Text = leer.ReadLine();
                textBox1.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Error2");
            }
            leer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeAdmin vent = new HomeAdmin();
            this.Hide();
            vent.Show();
        }

        private void Reglamento_Load(object sender, EventArgs e)
        {

        }
    }
}
