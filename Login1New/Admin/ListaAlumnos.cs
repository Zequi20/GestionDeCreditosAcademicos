using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1New.Admin
{
    public partial class ListaAlumnos : Form
    {
        public ListaAlumnos()
        {
            InitializeComponent();
        }

        private void ListaAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDusuarioDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bDusuarioDataSet.Usuarios);

        }
    }
}
