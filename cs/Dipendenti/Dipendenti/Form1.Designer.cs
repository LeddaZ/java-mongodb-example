namespace Dipendenti
{
    partial class FormDipendenti
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
            this.ButtonDipendenti = new System.Windows.Forms.Button();
            this.Tabella = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonDipendenti
            // 
            this.ButtonDipendenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDipendenti.Location = new System.Drawing.Point(320, 46);
            this.ButtonDipendenti.Name = "ButtonDipendenti";
            this.ButtonDipendenti.Size = new System.Drawing.Size(185, 39);
            this.ButtonDipendenti.TabIndex = 0;
            this.ButtonDipendenti.Text = "Visualizza dipendenti";
            this.ButtonDipendenti.UseVisualStyleBackColor = true;
            this.ButtonDipendenti.Click += new System.EventHandler(this.ButtonDipendenti_Click);
            // 
            // Tabella
            // 
            this.Tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabella.Location = new System.Drawing.Point(12, 140);
            this.Tabella.Name = "Tabella";
            this.Tabella.Size = new System.Drawing.Size(776, 298);
            this.Tabella.TabIndex = 1;
            // 
            // FormDipendenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabella);
            this.Controls.Add(this.ButtonDipendenti);
            this.Name = "FormDipendenti";
            this.Text = "Dipendenti";
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonDipendenti;
        private System.Windows.Forms.DataGridView Tabella;
    }
}

