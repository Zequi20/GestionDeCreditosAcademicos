namespace Login1New.Admin
{
    partial class ReglamentoCAE
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
            this.Reglamentos = new System.Windows.Forms.WebBrowser();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reglamentos
            // 
            this.Reglamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reglamentos.IsWebBrowserContextMenuEnabled = false;
            this.Reglamentos.Location = new System.Drawing.Point(0, 0);
            this.Reglamentos.MinimumSize = new System.Drawing.Size(20, 20);
            this.Reglamentos.Name = "Reglamentos";
            this.Reglamentos.Size = new System.Drawing.Size(800, 450);
            this.Reglamentos.TabIndex = 0;
            this.Reglamentos.Url = new System.Uri("https://drive.google.com/file/d/1DgBB7m-lw6nKH0AqOfIK4WJysIbw4vGI/view?fbclid=IwA" +
        "R0Ncd4jp1bo17e65dKc3MbZh5hawDxOYT7ZUMaiir8oejaocc68IVf_qCo", System.UriKind.Absolute);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(659, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(120, 40);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Cerrar";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // ReglamentoCAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.Reglamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReglamentoCAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReglamentoCAE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser Reglamentos;
        private System.Windows.Forms.Button btnAtras;
    }
}