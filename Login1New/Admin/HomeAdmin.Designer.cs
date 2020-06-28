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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpresaToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.agraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReglamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCarrera = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.comboBoxHabilitar = new System.Windows.Forms.ComboBox();
            this.listaDeDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass2 = new System.Windows.Forms.TextBox();
            this.labelAux = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.EmpresaToolStrip,
            this.reglasToolStripMenuItem,
            this.cambiarToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
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
            // listaDeAlumnosToolStripMenuItem
            // 
            this.listaDeAlumnosToolStripMenuItem.Name = "listaDeAlumnosToolStripMenuItem";
            this.listaDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeAlumnosToolStripMenuItem.Text = "Lista de Alumnos";
            this.listaDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.listaDeAlumnosToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDocenteToolStripMenuItem,
            this.eliminarDocenteToolStripMenuItem,
            this.listaDeDocentesToolStripMenuItem});
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // agregarDocenteToolStripMenuItem
            // 
            this.agregarDocenteToolStripMenuItem.Name = "agregarDocenteToolStripMenuItem";
            this.agregarDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarDocenteToolStripMenuItem.Text = "Agregar Docente";
            this.agregarDocenteToolStripMenuItem.Click += new System.EventHandler(this.agregarDocenteToolStripMenuItem_Click);
            // 
            // eliminarDocenteToolStripMenuItem
            // 
            this.eliminarDocenteToolStripMenuItem.Name = "eliminarDocenteToolStripMenuItem";
            this.eliminarDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarDocenteToolStripMenuItem.Text = "Eliminar Docente";
            this.eliminarDocenteToolStripMenuItem.Click += new System.EventHandler(this.eliminarDocenteToolStripMenuItem_Click);
            // 
            // EmpresaToolStrip
            // 
            this.EmpresaToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agraToolStripMenuItem,
            this.anularEmpresaToolStripMenuItem,
            this.validarEmpresaToolStripMenuItem});
            this.EmpresaToolStrip.Name = "EmpresaToolStrip";
            this.EmpresaToolStrip.Size = new System.Drawing.Size(64, 20);
            this.EmpresaToolStrip.Text = "Empresa";
            this.EmpresaToolStrip.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // agraToolStripMenuItem
            // 
            this.agraToolStripMenuItem.Name = "agraToolStripMenuItem";
            this.agraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agraToolStripMenuItem.Text = "Agregar Empresa";
            this.agraToolStripMenuItem.Click += new System.EventHandler(this.agraToolStripMenuItem_Click);
            // 
            // anularEmpresaToolStripMenuItem
            // 
            this.anularEmpresaToolStripMenuItem.Name = "anularEmpresaToolStripMenuItem";
            this.anularEmpresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anularEmpresaToolStripMenuItem.Text = "Invalidar Empresa";
            this.anularEmpresaToolStripMenuItem.Click += new System.EventHandler(this.anularEmpresaToolStripMenuItem_Click);
            // 
            // validarEmpresaToolStripMenuItem
            // 
            this.validarEmpresaToolStripMenuItem.Name = "validarEmpresaToolStripMenuItem";
            this.validarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validarEmpresaToolStripMenuItem.Text = "Validar Empresa";
            this.validarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.validarEmpresaToolStripMenuItem_Click);
            // 
            // reglasToolStripMenuItem
            // 
            this.reglasToolStripMenuItem.Checked = true;
            this.reglasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reglasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verReglamentoToolStripMenuItem});
            this.reglasToolStripMenuItem.Name = "reglasToolStripMenuItem";
            this.reglasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.reglasToolStripMenuItem.Text = "Reglas";
            this.reglasToolStripMenuItem.Click += new System.EventHandler(this.reglasToolStripMenuItem_Click);
            // 
            // verReglamentoToolStripMenuItem
            // 
            this.verReglamentoToolStripMenuItem.Name = "verReglamentoToolStripMenuItem";
            this.verReglamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verReglamentoToolStripMenuItem.Text = "Ver Reglamento";
            this.verReglamentoToolStripMenuItem.Click += new System.EventHandler(this.verReglamentoToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            this.cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            this.cerrarSesionToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem1.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(61, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(61, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBox1.Location = new System.Drawing.Point(384, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BtnAceptar.Location = new System.Drawing.Point(555, 350);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(100, 40);
            this.BtnAceptar.TabIndex = 5;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Visible = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnCancelar.Location = new System.Drawing.Point(65, 350);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 40);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(384, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(273, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(385, 283);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(270, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(61, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(61, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(61, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // comboBoxCarrera
            // 
            this.comboBoxCarrera.FormattingEnabled = true;
            this.comboBoxCarrera.Items.AddRange(new object[] {
            "Informatica",
            "Quimica",
            "Industrial"});
            this.comboBoxCarrera.Location = new System.Drawing.Point(385, 174);
            this.comboBoxCarrera.Name = "comboBoxCarrera";
            this.comboBoxCarrera.Size = new System.Drawing.Size(272, 21);
            this.comboBoxCarrera.TabIndex = 12;
            this.comboBoxCarrera.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(385, 50);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(272, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Visible = false;
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto"});
            this.comboBoxCurso.Location = new System.Drawing.Point(385, 227);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(272, 21);
            this.comboBoxCurso.TabIndex = 14;
            this.comboBoxCurso.Visible = false;
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(385, 174);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(272, 21);
            this.comboBoxEmpresa.TabIndex = 15;
            this.comboBoxEmpresa.Visible = false;
            // 
            // comboBoxHabilitar
            // 
            this.comboBoxHabilitar.FormattingEnabled = true;
            this.comboBoxHabilitar.Location = new System.Drawing.Point(385, 174);
            this.comboBoxHabilitar.Name = "comboBoxHabilitar";
            this.comboBoxHabilitar.Size = new System.Drawing.Size(272, 21);
            this.comboBoxHabilitar.TabIndex = 16;
            this.comboBoxHabilitar.Visible = false;
            // 
            // listaDeDocentesToolStripMenuItem
            // 
            this.listaDeDocentesToolStripMenuItem.Name = "listaDeDocentesToolStripMenuItem";
            this.listaDeDocentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeDocentesToolStripMenuItem.Text = "Lista de Docentes";
            this.listaDeDocentesToolStripMenuItem.Click += new System.EventHandler(this.listaDeDocentesToolStripMenuItem_Click);
            // 
            // cambiarToolStripMenuItem
            // 
            this.cambiarToolStripMenuItem.Name = "cambiarToolStripMenuItem";
            this.cambiarToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.cambiarToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarToolStripMenuItem.Click += new System.EventHandler(this.cambiarToolStripMenuItem_Click);
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Location = new System.Drawing.Point(385, 114);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.PasswordChar = '*';
            this.textBoxOldPass.Size = new System.Drawing.Size(272, 20);
            this.textBoxOldPass.TabIndex = 17;
            this.textBoxOldPass.Visible = false;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(385, 175);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.PasswordChar = '*';
            this.textBoxNewPass.Size = new System.Drawing.Size(272, 20);
            this.textBoxNewPass.TabIndex = 18;
            this.textBoxNewPass.Visible = false;
            // 
            // textBoxNewPass2
            // 
            this.textBoxNewPass2.Location = new System.Drawing.Point(385, 228);
            this.textBoxNewPass2.Name = "textBoxNewPass2";
            this.textBoxNewPass2.PasswordChar = '*';
            this.textBoxNewPass2.Size = new System.Drawing.Size(272, 20);
            this.textBoxNewPass2.TabIndex = 19;
            this.textBoxNewPass2.Visible = false;
            // 
            // labelAux
            // 
            this.labelAux.AutoSize = true;
            this.labelAux.Location = new System.Drawing.Point(694, 65);
            this.labelAux.Name = "labelAux";
            this.labelAux.Size = new System.Drawing.Size(35, 13);
            this.labelAux.TabIndex = 20;
            this.labelAux.Text = "label6";
            this.labelAux.Visible = false;
            // 
            // HomeAdmin
            // 
            this.AcceptButton = this.BtnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = global::Login1New.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 411);
            this.Controls.Add(this.labelAux);
            this.Controls.Add(this.textBoxNewPass2);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.textBoxOldPass);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBoxHabilitar);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.comboBoxCarrera);
            this.Controls.Add(this.comboBoxCurso);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeAdmin_FormClosed);
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpresaToolStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ToolStripMenuItem verReglamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCarrera;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.ToolStripMenuItem anularEmpresaToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.ToolStripMenuItem validarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxHabilitar;
        private System.Windows.Forms.ToolStripMenuItem agregarDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxNewPass2;
        public System.Windows.Forms.Label labelAux;
    }
}