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
        string nom;
        public ModificarAlumno()
        {
            InitializeComponent();
        }

        private void ModificarAlumno_Load(object sender, EventArgs e)
        {
            label2.Text = nom;
        }
    }
}
