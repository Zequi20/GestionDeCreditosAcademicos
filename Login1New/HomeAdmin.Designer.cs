namespace Login1New
{
    partial class HomeAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.listaDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(444, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(444, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(132, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "-----";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(132, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "-----";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.reglasToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAlumnoToolStripMenuItem,
            this.modificarAlumnoToolStripMenuItem,
            this.eliminarAlumnoToolStripMenuItem,
            this.listaDeAlumnosToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // agregarAlumnoToolStripMenuItem
            // 
            this.agregarAlumnoToolStripMenuItem.Name = "agregarAlumnoToolStripMenuItem";
            this.agregarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarAlumnoToolStripMenuItem.Text = "Agregar Alumno";
            this.agregarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.agregarAlumnoToolStripMenuItem_Click);
            // 
            // modificarAlumnoToolStripMenuItem
            // 
            this.modificarAlumnoToolStripMenuItem.Name = "modificarAlumnoToolStripMenuItem";
            this.modificarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarAlumnoToolStripMenuItem.Text = "Modificar Alumno";
            this.modificarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.modificarAlumnoToolStripMenuItem_Click);
            // 
            // eliminarAlumnoToolStripMenuItem
            // 
            this.eliminarAlumnoToolStripMenuItem.Name = "eliminarAlumnoToolStripMenuItem";
            this.eliminarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarAlumnoToolStripMenuItem.Text = "Eliminar Alumno";
            this.eliminarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.eliminarAlumnoToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // reglasToolStripMenuItem
            // 
            this.reglasToolStripMenuItem.Name = "reglasToolStripMenuItem";
            this.reglasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.reglasToolStripMenuItem.Text = "Reglas";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.Location = new System.Drawing.Point(444, 376);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(210, 24);
            this.Btn_aceptar.TabIndex = 10;
            this.Btn_aceptar.Text = "Aceptar";
            this.Btn_aceptar.UseVisualStyleBackColor = true;
            this.Btn_aceptar.Visible = false;
            this.Btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click_1);
            // 
            // listaDeAlumnosToolStripMenuItem
            // 
            this.listaDeAlumnosToolStripMenuItem.Name = "listaDeAlumnosToolStripMenuItem";
            this.listaDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeAlumnosToolStripMenuItem.Text = "Lista de Alumnos";
            this.listaDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.listaDeAlumnosToolStripMenuItem_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login1New.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.Btn_aceptar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeAdmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "  Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeAdmin_FormClosing);
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglasToolStripMenuItem;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeAlumnosToolStripMenuItem;
    }
}