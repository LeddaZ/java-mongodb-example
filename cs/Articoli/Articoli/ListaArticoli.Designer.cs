namespace Articoli
{
    partial class FormListaArticoli
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
            this.ButtonGenera = new System.Windows.Forms.Button();
            this.Tabella = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGenera
            // 
            this.ButtonGenera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenera.Location = new System.Drawing.Point(326, 41);
            this.ButtonGenera.Name = "ButtonGenera";
            this.ButtonGenera.Size = new System.Drawing.Size(115, 36);
            this.ButtonGenera.TabIndex = 0;
            this.ButtonGenera.Text = "Genera lista";
            this.ButtonGenera.UseVisualStyleBackColor = true;
            this.ButtonGenera.Click += new System.EventHandler(this.ButtonGenera_Click);
            // 
            // Tabella
            // 
            this.Tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabella.Location = new System.Drawing.Point(27, 131);
            this.Tabella.Name = "Tabella";
            this.Tabella.Size = new System.Drawing.Size(708, 170);
            this.Tabella.TabIndex = 1;
            // 
            // FormListaArticoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 313);
            this.Controls.Add(this.Tabella);
            this.Controls.Add(this.ButtonGenera);
            this.Name = "FormListaArticoli";
            this.Text = "Lista articoli";
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGenera;
        private System.Windows.Forms.DataGridView Tabella;
    }
}

