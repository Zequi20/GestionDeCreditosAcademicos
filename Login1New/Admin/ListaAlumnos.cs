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
            // TODO: esta línea de código carga datos en la tabla 'bDusuarioDataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.bDusuarioDataSet1.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'bDusuarioDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bDusuarioDataSet.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'bDusuarioDataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.bDusuarioDataSet1.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'bDusuarioDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bDusuarioDataSet.Usuarios);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter1.FillBy(this.bDusuarioDataSet1.Usuarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
