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
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        public void Btn_usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaAdminUsuario VentUsu = new VentanaAdminUsuario();
            VentUsu.Show();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
