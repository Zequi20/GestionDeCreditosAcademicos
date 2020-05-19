namespace Login1New.Admin
{
    partial class ListaAlumnos
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
            this.components = new System.ComponentModel.Container();
            this.bDusuarioDataSet = new Login1New.BDusuarioDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDusuarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Login1New.BDusuarioDataSetTableAdapters.UsuariosTableAdapter();
            this.bDusuarioDataSet1 = new Login1New.BDusuarioDataSet1();
            this.bDusuarioDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter1 = new Login1New.BDusuarioDataSet1TableAdapters.UsuariosTableAdapter();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditosacadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bDusuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDusuarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDusuarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDusuarioDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bDusuarioDataSet
            // 
            this.bDusuarioDataSet.DataSetName = "BDusuarioDataSet";
            this.bDusuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.checkusuDataGridViewTextBoxColumn,
            this.carreraDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.creditosacadeDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // bDusuarioDataSetBindingSource
            // 
            this.bDusuarioDataSetBindingSource.DataSource = this.bDusuarioDataSet;
            this.bDusuarioDataSetBindingSource.Position = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bDusuarioDataSetBindingSource;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // bDusuarioDataSet1
            // 
            this.bDusuarioDataSet1.DataSetName = "BDusuarioDataSet1";
            this.bDusuarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDusuarioDataSet1BindingSource
            // 
            this.bDusuarioDataSet1BindingSource.DataSource = this.bDusuarioDataSet1;
            this.bDusuarioDataSet1BindingSource.Position = 0;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.bDusuarioDataSet1BindingSource;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            // 
            // checkusuDataGridViewTextBoxColumn
            // 
            this.checkusuDataGridViewTextBoxColumn.DataPropertyName = "check_usu";
            this.checkusuDataGridViewTextBoxColumn.HeaderText = "check_usu";
            this.checkusuDataGridViewTextBoxColumn.Name = "checkusuDataGridViewTextBoxColumn";
            // 
            // carreraDataGridViewTextBoxColumn
            // 
            this.carreraDataGridViewTextBoxColumn.DataPropertyName = "carrera";
            this.carreraDataGridViewTextBoxColumn.HeaderText = "carrera";
            this.carreraDataGridViewTextBoxColumn.Name = "carreraDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // creditosacadeDataGridViewTextBoxColumn
            // 
            this.creditosacadeDataGridViewTextBoxColumn.DataPropertyName = "creditos_acade";
            this.creditosacadeDataGridViewTextBoxColumn.HeaderText = "creditos_acade";
            this.creditosacadeDataGridViewTextBoxColumn.Name = "creditosacadeDataGridViewTextBoxColumn";
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            // 
            // ListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::Login1New.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(844, 411);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListaAlumnos";
            this.Text = "ListaAlumnos";
            this.Load += new System.EventHandler(this.ListaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDusuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDusuarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDusuarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDusuarioDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BDusuarioDataSet bDusuarioDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bDusuarioDataSetBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BDusuarioDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource bDusuarioDataSet1BindingSource;
        private BDusuarioDataSet1 bDusuarioDataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private BDusuarioDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditosacadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
    }
}