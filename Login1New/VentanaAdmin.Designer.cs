namespace Login1New
{
    partial class VentanaAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_usuario = new System.Windows.Forms.Button();
            this.Btn_docente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_reglamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // Btn_usuario
            // 
            this.Btn_usuario.Location = new System.Drawing.Point(193, 131);
            this.Btn_usuario.Name = "Btn_usuario";
            this.Btn_usuario.Size = new System.Drawing.Size(75, 23);
            this.Btn_usuario.TabIndex = 1;
            this.Btn_usuario.Text = "Usuario";
            this.Btn_usuario.UseVisualStyleBackColor = true;
            this.Btn_usuario.Click += new System.EventHandler(this.Btn_usuario_Click);
            // 
            // Btn_docente
            // 
            this.Btn_docente.Location = new System.Drawing.Point(193, 176);
            this.Btn_docente.Name = "Btn_docente";
            this.Btn_docente.Size = new System.Drawing.Size(75, 23);
            this.Btn_docente.TabIndex = 2;
            this.Btn_docente.Text = "Docente";
            this.Btn_docente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Con cual desea trabajar?";
            // 
            // Btn_reglamento
            // 
            this.Btn_reglamento.Location = new System.Drawing.Point(180, 226);
            this.Btn_reglamento.Name = "Btn_reglamento";
            this.Btn_reglamento.Size = new System.Drawing.Size(112, 22);
            this.Btn_reglamento.TabIndex = 4;
            this.Btn_reglamento.Text = "Reglamento";
            this.Btn_reglamento.UseVisualStyleBackColor = true;
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.Btn_reglamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_docente);
            this.Controls.Add(this.Btn_usuario);
            this.Controls.Add(this.label1);
            this.Name = "VentanaAdmin";
            this.Text = "VentanaAdmin";
            this.Load += new System.EventHandler(this.VentanaAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_usuario;
        private System.Windows.Forms.Button Btn_docente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_reglamento;
    }
}