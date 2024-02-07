namespace CodFiscaleForm
{
    partial class CodiceFiscale
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
            this.Titolo = new System.Windows.Forms.Label();
            this.LabelCognome = new System.Windows.Forms.Label();
            this.TextBoxCognome = new System.Windows.Forms.TextBox();
            this.LabelNome = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.LabelData = new System.Windows.Forms.Label();
            this.RadioM = new System.Windows.Forms.RadioButton();
            this.RadioF = new System.Windows.Forms.RadioButton();
            this.GroupBoxSesso = new System.Windows.Forms.GroupBox();
            this.DataNascita = new System.Windows.Forms.DateTimePicker();
            this.ButtonCalcola = new System.Windows.Forms.Button();
            this.LabelCodice = new System.Windows.Forms.Label();
            this.GroupBoxSesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titolo
            // 
            this.Titolo.AutoSize = true;
            this.Titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titolo.Location = new System.Drawing.Point(12, 9);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(161, 25);
            this.Titolo.TabIndex = 0;
            this.Titolo.Text = "Codice fiscale";
            // 
            // LabelCognome
            // 
            this.LabelCognome.AutoSize = true;
            this.LabelCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCognome.Location = new System.Drawing.Point(14, 62);
            this.LabelCognome.Name = "LabelCognome";
            this.LabelCognome.Size = new System.Drawing.Size(66, 16);
            this.LabelCognome.TabIndex = 1;
            this.LabelCognome.Text = "Cognome";
            // 
            // TextBoxCognome
            // 
            this.TextBoxCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCognome.Location = new System.Drawing.Point(223, 60);
            this.TextBoxCognome.Name = "TextBoxCognome";
            this.TextBoxCognome.Size = new System.Drawing.Size(149, 22);
            this.TextBoxCognome.TabIndex = 2;
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.Location = new System.Drawing.Point(14, 105);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(44, 16);
            this.LabelNome.TabIndex = 3;
            this.LabelNome.Text = "Nome";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNome.Location = new System.Drawing.Point(223, 105);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(149, 22);
            this.TextBoxNome.TabIndex = 4;
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelData.Location = new System.Drawing.Point(14, 155);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(185, 16);
            this.LabelData.TabIndex = 5;
            this.LabelData.Text = "Data di nascita (gg/mm/aaaa)";
            // 
            // RadioM
            // 
            this.RadioM.AutoSize = true;
            this.RadioM.Checked = true;
            this.RadioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioM.Location = new System.Drawing.Point(30, 35);
            this.RadioM.Name = "RadioM";
            this.RadioM.Size = new System.Drawing.Size(36, 20);
            this.RadioM.TabIndex = 8;
            this.RadioM.TabStop = true;
            this.RadioM.Text = "M";
            this.RadioM.UseVisualStyleBackColor = true;
            this.RadioM.CheckedChanged += new System.EventHandler(this.RadioM_CheckedChanged);
            // 
            // RadioF
            // 
            this.RadioF.AutoSize = true;
            this.RadioF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioF.Location = new System.Drawing.Point(72, 35);
            this.RadioF.Name = "RadioF";
            this.RadioF.Size = new System.Drawing.Size(33, 20);
            this.RadioF.TabIndex = 9;
            this.RadioF.Text = "F";
            this.RadioF.UseVisualStyleBackColor = true;
            this.RadioF.CheckedChanged += new System.EventHandler(this.RadioF_CheckedChanged);
            // 
            // GroupBoxSesso
            // 
            this.GroupBoxSesso.Controls.Add(this.RadioM);
            this.GroupBoxSesso.Controls.Add(this.RadioF);
            this.GroupBoxSesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSesso.Location = new System.Drawing.Point(17, 199);
            this.GroupBoxSesso.Name = "GroupBoxSesso";
            this.GroupBoxSesso.Size = new System.Drawing.Size(141, 87);
            this.GroupBoxSesso.TabIndex = 10;
            this.GroupBoxSesso.TabStop = false;
            this.GroupBoxSesso.Text = "Sesso";
            // 
            // DataNascita
            // 
            this.DataNascita.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataNascita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascita.Location = new System.Drawing.Point(223, 155);
            this.DataNascita.MaxDate = new System.DateTime(2023, 11, 22, 0, 0, 0, 0);
            this.DataNascita.Name = "DataNascita";
            this.DataNascita.Size = new System.Drawing.Size(149, 22);
            this.DataNascita.TabIndex = 11;
            this.DataNascita.Value = new System.DateTime(2023, 11, 22, 0, 0, 0, 0);
            // 
            // ButtonCalcola
            // 
            this.ButtonCalcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCalcola.Location = new System.Drawing.Point(244, 221);
            this.ButtonCalcola.Name = "ButtonCalcola";
            this.ButtonCalcola.Size = new System.Drawing.Size(101, 40);
            this.ButtonCalcola.TabIndex = 12;
            this.ButtonCalcola.Text = "Calcola";
            this.ButtonCalcola.UseVisualStyleBackColor = true;
            this.ButtonCalcola.Click += new System.EventHandler(this.ButtonCalcola_Click);
            // 
            // LabelCodice
            // 
            this.LabelCodice.AutoSize = true;
            this.LabelCodice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodice.Location = new System.Drawing.Point(13, 322);
            this.LabelCodice.Name = "LabelCodice";
            this.LabelCodice.Size = new System.Drawing.Size(0, 24);
            this.LabelCodice.TabIndex = 13;
            // 
            // CodiceFiscale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 402);
            this.Controls.Add(this.LabelCodice);
            this.Controls.Add(this.ButtonCalcola);
            this.Controls.Add(this.DataNascita);
            this.Controls.Add(this.GroupBoxSesso);
            this.Controls.Add(this.LabelData);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.TextBoxCognome);
            this.Controls.Add(this.LabelCognome);
            this.Controls.Add(this.Titolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CodiceFiscale";
            this.Text = "Codice fiscale";
            this.GroupBoxSesso.ResumeLayout(false);
            this.GroupBoxSesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titolo;
        private System.Windows.Forms.Label LabelCognome;
        private System.Windows.Forms.TextBox TextBoxCognome;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.RadioButton RadioM;
        private System.Windows.Forms.RadioButton RadioF;
        private System.Windows.Forms.GroupBox GroupBoxSesso;
        private System.Windows.Forms.DateTimePicker DataNascita;
        private System.Windows.Forms.Button ButtonCalcola;
        private System.Windows.Forms.Label LabelCodice;
    }
}

