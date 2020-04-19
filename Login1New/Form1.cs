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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE usuario='{0}' AND contraseña='{1}'", txtBoxUsu.Text.Trim(), txtBoxPass.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                string usuario = ds.Tables[0].Rows[0]["usuario"].ToString().Trim();
                string contraseña = ds.Tables[0].Rows[0]["contraseña"].ToString().Trim();

                if (usuario==txtBoxUsu.Text.Trim() && contraseña==txtBoxPass.Text.Trim())
                {                    
                    if(Convert.ToInt32(ds.Tables[0].Rows[0]["check_usu"])==0)
                    {
                        VentanaAdmin VenAd = new VentanaAdmin();
                        this.Hide();
                        VenAd.Show();

                    }
                    else if(Convert.ToInt32(ds.Tables[0].Rows[0]["check_usu"])==1)
                    {
                        VentanaDocente VenDoc = new VentanaDocente();
                        this.Hide();
                        VenDoc.Show();
                    }
                    else if(Convert.ToInt32(ds.Tables[0].Rows[0]["check_usu"])==2)
                    {
                        VentanaUsuario VenUsu = new VentanaUsuario();
                        this.Hide();
                        VenUsu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ha fallado el sistema.");
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Se ha producido un error." + error.Message);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
