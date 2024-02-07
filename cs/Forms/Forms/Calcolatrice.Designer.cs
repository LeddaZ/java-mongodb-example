namespace Forms
{
    partial class Calcolatrice
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
            this.LabelNum1 = new System.Windows.Forms.Label();
            this.TextBoxNum1 = new System.Windows.Forms.TextBox();
            this.LabelNum2 = new System.Windows.Forms.Label();
            this.TextBoxNum2 = new System.Windows.Forms.TextBox();
            this.ButtonAddizione = new System.Windows.Forms.Button();
            this.ButtonSottrazione = new System.Windows.Forms.Button();
            this.ButtonMoltiplicazione = new System.Windows.Forms.Button();
            this.ButtonDivisione = new System.Windows.Forms.Button();
            this.LabelRisultato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titolo
            // 
            this.Titolo.AutoSize = true;
            this.Titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titolo.Location = new System.Drawing.Point(12, 9);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(137, 25);
            this.Titolo.TabIndex = 0;
            this.Titolo.Text = "Calcolatrice";
            // 
            // LabelNum1
            // 
            this.LabelNum1.AutoSize = true;
            this.LabelNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNum1.Location = new System.Drawing.Point(14, 65);
            this.LabelNum1.Name = "LabelNum1";
            this.LabelNum1.Size = new System.Drawing.Size(150, 16);
            this.LabelNum1.TabIndex = 1;
            this.LabelNum1.Text = "Inserisci il primo numero";
            // 
            // TextBoxNum1
            // 
            this.TextBoxNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNum1.Location = new System.Drawing.Point(189, 59);
            this.TextBoxNum1.Name = "TextBoxNum1";
            this.TextBoxNum1.Size = new System.Drawing.Size(100, 22);
            this.TextBoxNum1.TabIndex = 2;
            // 
            // LabelNum2
            // 
            this.LabelNum2.AutoSize = true;
            this.LabelNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNum2.Location = new System.Drawing.Point(14, 112);
            this.LabelNum2.Name = "LabelNum2";
            this.LabelNum2.Size = new System.Drawing.Size(169, 16);
            this.LabelNum2.TabIndex = 3;
            this.LabelNum2.Text = "Inserisci il secondo numero";
            // 
            // TextBoxNum2
            // 
            this.TextBoxNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNum2.Location = new System.Drawing.Point(189, 108);
            this.TextBoxNum2.Name = "TextBoxNum2";
            this.TextBoxNum2.Size = new System.Drawing.Size(100, 22);
            this.TextBoxNum2.TabIndex = 4;
            // 
            // ButtonAddizione
            // 
            this.ButtonAddizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddizione.Location = new System.Drawing.Point(17, 162);
            this.ButtonAddizione.Name = "ButtonAddizione";
            this.ButtonAddizione.Size = new System.Drawing.Size(29, 23);
            this.ButtonAddizione.TabIndex = 5;
            this.ButtonAddizione.Text = "+";
            this.ButtonAddizione.UseVisualStyleBackColor = true;
            this.ButtonAddizione.Click += new System.EventHandler(this.ButtonAddizione_Click);
            // 
            // ButtonSottrazione
            // 
            this.ButtonSottrazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSottrazione.Location = new System.Drawing.Point(52, 162);
            this.ButtonSottrazione.Name = "ButtonSottrazione";
            this.ButtonSottrazione.Size = new System.Drawing.Size(29, 23);
            this.ButtonSottrazione.TabIndex = 6;
            this.ButtonSottrazione.Text = "-";
            this.ButtonSottrazione.UseVisualStyleBackColor = true;
            this.ButtonSottrazione.Click += new System.EventHandler(this.ButtonSottrazione_Click);
            // 
            // ButtonMoltiplicazione
            // 
            this.ButtonMoltiplicazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMoltiplicazione.Location = new System.Drawing.Point(87, 162);
            this.ButtonMoltiplicazione.Name = "ButtonMoltiplicazione";
            this.ButtonMoltiplicazione.Size = new System.Drawing.Size(29, 23);
            this.ButtonMoltiplicazione.TabIndex = 7;
            this.ButtonMoltiplicazione.Text = "X";
            this.ButtonMoltiplicazione.UseVisualStyleBackColor = true;
            this.ButtonMoltiplicazione.Click += new System.EventHandler(this.ButtonMoltiplicazione_Click);
            // 
            // ButtonDivisione
            // 
            this.ButtonDivisione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDivisione.Location = new System.Drawing.Point(122, 162);
            this.ButtonDivisione.Name = "ButtonDivisione";
            this.ButtonDivisione.Size = new System.Drawing.Size(29, 23);
            this.ButtonDivisione.TabIndex = 8;
            this.ButtonDivisione.Text = "/";
            this.ButtonDivisione.UseVisualStyleBackColor = true;
            this.ButtonDivisione.Click += new System.EventHandler(this.ButtonDivisione_Click);
            // 
            // LabelRisultato
            // 
            this.LabelRisultato.AutoSize = true;
            this.LabelRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRisultato.Location = new System.Drawing.Point(14, 212);
            this.LabelRisultato.Name = "LabelRisultato";
            this.LabelRisultato.Size = new System.Drawing.Size(85, 18);
            this.LabelRisultato.TabIndex = 9;
            this.LabelRisultato.Text = "Risultato: ";
            // 
            // Calcolatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 300);
            this.Controls.Add(this.LabelRisultato);
            this.Controls.Add(this.ButtonDivisione);
            this.Controls.Add(this.ButtonMoltiplicazione);
            this.Controls.Add(this.ButtonSottrazione);
            this.Controls.Add(this.ButtonAddizione);
            this.Controls.Add(this.TextBoxNum2);
            this.Controls.Add(this.LabelNum2);
            this.Controls.Add(this.TextBoxNum1);
            this.Controls.Add(this.LabelNum1);
            this.Controls.Add(this.Titolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calcolatrice";
            this.Text = "Calcolatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titolo;
        private System.Windows.Forms.Label LabelNum1;
        private System.Windows.Forms.TextBox TextBoxNum1;
        private System.Windows.Forms.Label LabelNum2;
        private System.Windows.Forms.TextBox TextBoxNum2;
        private System.Windows.Forms.Button ButtonAddizione;
        private System.Windows.Forms.Button ButtonSottrazione;
        private System.Windows.Forms.Button ButtonMoltiplicazione;
        private System.Windows.Forms.Button ButtonDivisione;
        private System.Windows.Forms.Label LabelRisultato;
    }
}

