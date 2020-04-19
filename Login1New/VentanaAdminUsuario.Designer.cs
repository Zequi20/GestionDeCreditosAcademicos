namespace Login1New
{
    partial class VentanaAdminUsuario
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
            this.Btn_añadir_usu = new System.Windows.Forms.Button();
            this.Btn_modif_usu = new System.Windows.Forms.Button();
            this.Btn_elim_usu = new System.Windows.Forms.Button();
            this.Btn_atras = new System.Windows.Forms.Button();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_añadir_usu
            // 
            this.Btn_añadir_usu.Location = new System.Drawing.Point(31, 44);
            this.Btn_añadir_usu.Name = "Btn_añadir_usu";
            this.Btn_añadir_usu.Size = new System.Drawing.Size(171, 55);
            this.Btn_añadir_usu.TabIndex = 0;
            this.Btn_añadir_usu.Text = "Añadir Usuario";
            this.Btn_añadir_usu.UseVisualStyleBackColor = true;
            this.Btn_añadir_usu.Click += new System.EventHandler(this.Btn_añadir_usu_Click);
            // 
            // Btn_modif_usu
            // 
            this.Btn_modif_usu.Location = new System.Drawing.Point(31, 143);
            this.Btn_modif_usu.Name = "Btn_modif_usu";
            this.Btn_modif_usu.Size = new System.Drawing.Size(171, 63);
            this.Btn_modif_usu.TabIndex = 1;
            this.Btn_modif_usu.Text = "Modificar Usuario";
            this.Btn_modif_usu.UseVisualStyleBackColor = true;
            // 
            // Btn_elim_usu
            // 
            this.Btn_elim_usu.Location = new System.Drawing.Point(31, 251);
            this.Btn_elim_usu.Name = "Btn_elim_usu";
            this.Btn_elim_usu.Size = new System.Drawing.Size(168, 56);
            this.Btn_elim_usu.TabIndex = 2;
            this.Btn_elim_usu.Text = "Eliminar Usuario";
            this.Btn_elim_usu.UseVisualStyleBackColor = true;
            // 
            // Btn_atras
            // 
            this.Btn_atras.Location = new System.Drawing.Point(31, 362);
            this.Btn_atras.Name = "Btn_atras";
            this.Btn_atras.Size = new System.Drawing.Size(160, 53);
            this.Btn_atras.TabIndex = 3;
            this.Btn_atras.Text = "Atras";
            this.Btn_atras.UseVisualStyleBackColor = true;
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.Location = new System.Drawing.Point(574, 362);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(167, 53);
            this.Btn_aceptar.TabIndex = 4;
            this.Btn_aceptar.Text = "Aceptar";
            this.Btn_aceptar.UseVisualStyleBackColor = true;
            this.Btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(468, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "-----";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "-----";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(468, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // VentanaAdminUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 451);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_aceptar);
            this.Controls.Add(this.Btn_atras);
            this.Controls.Add(this.Btn_elim_usu);
            this.Controls.Add(this.Btn_modif_usu);
            this.Controls.Add(this.Btn_añadir_usu);
            this.Name = "VentanaAdminUsuario";
            this.Text = "VentanaAdminUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_añadir_usu;
        private System.Windows.Forms.Button Btn_modif_usu;
        private System.Windows.Forms.Button Btn_elim_usu;
        private System.Windows.Forms.Button Btn_atras;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}