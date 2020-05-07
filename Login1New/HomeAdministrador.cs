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
    public partial class HomeAdministrador : Form
    {
        public HomeAdministrador()
        {
            InitializeComponent();
        }

        public void Btn_usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alumno VentUsu = new Alumno();
            VentUsu.Show();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
