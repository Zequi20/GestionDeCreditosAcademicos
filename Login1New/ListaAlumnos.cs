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

namespace Login1New
{
    public partial class ListaAlumnos : Form
    {
        public ListaAlumnos()
        {
            InitializeComponent();
        }

        private void GridAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ListaAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDusuarioDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bDusuarioDataSet.Usuarios);

        }

        private void lblLista_Click(object sender, EventArgs e)
        {

        }

        private void BtnSincronizar_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Data Source=Zack;Initial Catalog=BDusuario;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from BDusuario", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridAlumnos.DataSource = dt;*/
        }
    }
}
