namespace Login1New.Admin
{
    partial class ListaDocente
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
            this.ListaDoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaDoc
            // 
            this.ListaDoc.AllowUserToAddRows = false;
            this.ListaDoc.AllowUserToDeleteRows = false;
            this.ListaDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaDoc.Location = new System.Drawing.Point(0, 0);
            this.ListaDoc.Name = "ListaDoc";
            this.ListaDoc.ReadOnly = true;
            this.ListaDoc.Size = new System.Drawing.Size(624, 441);
            this.ListaDoc.TabIndex = 0;
            // 
            // ListaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ListaDoc);
            this.Name = "ListaDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDocente";
            this.Load += new System.EventHandler(this.ListaDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaDoc;
    }
}