﻿using System;
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
    public partial class HomeDocente : Form
    {
        public HomeDocente()
        {
            InitializeComponent();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
