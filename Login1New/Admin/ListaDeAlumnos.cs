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

namespace Login1New.Admin
{
    public partial class ListaDeAlumnos : Form
    {
        public ListaDeAlumnos()
        {
            InitializeComponent();
        }

        private void ListaDeAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDusuarioDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            //this.usuariosTableAdapter.Fill(this.bDusuarioDataSet.Usuarios);
            DataTable tabla = Utilidades.ObtenerEmpresa("SELECT id_usuario,usuario,codigo,curso,carrera,creditos_acade FROM Usuarios WHERE check_usu = 2");
            Lista.DataSource = tabla;
        }
    }
}
