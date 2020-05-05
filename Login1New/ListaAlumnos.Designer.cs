namespace Login1New
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
            this.GridAlumnos = new System.Windows.Forms.DataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDusuarioDataSet = new Login1New.BDusuarioDataSet();
            this.lblLista = new System.Windows.Forms.Label();
            this.BtnSincronizar = new System.Windows.Forms.Button();
            this.usuariosTableAdapter = new Login1New.BDusuarioDataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GridAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDusuarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAlumnos
            // 
            this.GridAlumnos.AllowUserToOrderColumns = true;
            this.GridAlumnos.AutoGenerateColumns = false;
            this.GridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn});
            this.GridAlumnos.DataSource = this.usuariosBindingSource;
            this.GridAlumnos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridAlumnos.Location = new System.Drawing.Point(3, 43);
            this.GridAlumnos.Name = "GridAlumnos";
            this.GridAlumnos.Size = new System.Drawing.Size(344, 201);
            this.GridAlumnos.TabIndex = 0;
            this.GridAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAlumnos_CellContentClick);
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
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bDusuarioDataSet;
            // 
            // bDusuarioDataSet
            // 
            this.bDusuarioDataSet.DataSetName = "BDusuarioDataSet";
            this.bDusuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.BackColor = System.Drawing.Color.Transparent;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLista.Location = new System.Drawing.Point(12, 9);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(85, 24);
            this.lblLista.TabIndex = 1;
            this.lblLista.Text = "Alumnos";
            this.lblLista.Click += new System.EventHandler(this.lblLista_Click);
            // 
            // BtnSincronizar
            // 
            this.BtnSincronizar.Location = new System.Drawing.Point(587, 8);
            this.BtnSincronizar.Name = "BtnSincronizar";
            this.BtnSincronizar.Size = new System.Drawing.Size(160, 25);
            this.BtnSincronizar.TabIndex = 2;
            this.BtnSincronizar.Text = "Sincronizar";
            this.BtnSincronizar.UseVisualStyleBackColor = true;
            this.BtnSincronizar.Click += new System.EventHandler(this.BtnSincronizar_Click);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // ListaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login1New.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(754, 316);
            this.Controls.Add(this.BtnSincronizar);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.GridAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListaAlumnos";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.ListaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDusuarioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridAlumnos;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button BtnSincronizar;
        private BDusuarioDataSet bDusuarioDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BDusuarioDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
    }
}