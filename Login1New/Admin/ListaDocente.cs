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
    public partial class ListaDocente : Form
    {
        public ListaDocente()
        {
            InitializeComponent();
        }

        private void ListaDocente_Load(object sender, EventArgs e)
        {
            DataTable tabla = Utilidades.ObtenerEmpresa("SELECT usuario,codigo FROM Usuarios WHERE check_usu = 1");
            ListaDoc.DataSource = tabla;
        }
    }
}
