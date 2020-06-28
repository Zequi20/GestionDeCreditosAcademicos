using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1New.Admin
{
    public partial class EmpresaAlumno : Form
    {
        
        public EmpresaAlumno()
        {
            InitializeComponent();
        }

        private void EmpresaAlumno_Load(object sender, EventArgs e)
        {
            SqlDataReader codigo = Utilidades.Consulta("SELECT cod_alumno FROM Pasantia WHERE nombre = '"+labelNombre.Text.Trim()+"'");
            if(codigo.Read())
            {
                labelCodigo.Text = codigo["cod_alumno"].ToString();
            }
            else
            {
                MessageBox.Show("El Alumno no ha realizado ninguna pasantia");
            }
            DataTable Horas = Utilidades.ObtenerEmpresa("SELECT horas FROM Pasantia WHERE nombre='"+labelNombre.Text.Trim()+"'");
            for (int i = 0; i < Horas.Rows.Count; i++)
            {
                listBox1.Items.Add(Horas.Rows[i]["horas"]);
    
            }
            string cod;
            DataTable code = Utilidades.ObtenerEmpresa("SELECT cod_empresa FROM Pasantia WHERE nombre='" + labelNombre.Text.Trim() + "'");
            for (int i = 0; i < code.Rows.Count; i++)
            {
                cod = code.Rows[i]["cod_empresa"].ToString();
                DataTable Nombre = Utilidades.ObtenerEmpresa("SELECT nombre FROM Empresas WHERE cod_empresa='" + cod.Trim() + "'");
                for (int a = 0; a < Nombre.Rows.Count; a++)
                {
                    listBox2.Items.Add(Nombre.Rows[a]["nombre"]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
             
        }
    }
}
