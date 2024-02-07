namespace Database
{
    partial class Form1
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
            this.BtnArticoli = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnInserisci = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.numPrezzo = new System.Windows.Forms.NumericUpDown();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.numGiacenza = new System.Windows.Forms.NumericUpDown();
            this.lblGiacenza = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.numIVA = new System.Windows.Forms.NumericUpDown();
            this.BtnElimina = new System.Windows.Forms.Button();
            this.lblElimina = new System.Windows.Forms.Label();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.BtnCerca = new System.Windows.Forms.Button();
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiacenza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnArticoli
            // 
            this.BtnArticoli.Location = new System.Drawing.Point(12, 12);
            this.BtnArticoli.Name = "BtnArticoli";
            this.BtnArticoli.Size = new System.Drawing.Size(115, 33);
            this.BtnArticoli.TabIndex = 0;
            this.BtnArticoli.Text = "Visualizza database";
            this.BtnArticoli.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 256);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(756, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // BtnInserisci
            // 
            this.BtnInserisci.Location = new System.Drawing.Point(12, 421);
            this.BtnInserisci.Name = "BtnInserisci";
            this.BtnInserisci.Size = new System.Drawing.Size(115, 33);
            this.BtnInserisci.TabIndex = 3;
            this.BtnInserisci.Text = "Inserisci articolo";
            this.BtnInserisci.UseVisualStyleBackColor = true;
            this.BtnInserisci.Click += new System.EventHandler(this.BtnInserisci_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 473);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(357, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.Text = "Nome";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(12, 499);
            this.txtDescrizione.MaxLength = 70;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(357, 20);
            this.txtDescrizione.TabIndex = 5;
            this.txtDescrizione.Text = "Descrizione";
            // 
            // numPrezzo
            // 
            this.numPrezzo.DecimalPlaces = 2;
            this.numPrezzo.Location = new System.Drawing.Point(71, 524);
            this.numPrezzo.Name = "numPrezzo";
            this.numPrezzo.Size = new System.Drawing.Size(120, 20);
            this.numPrezzo.TabIndex = 7;
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(13, 526);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(39, 13);
            this.lblPrezzo.TabIndex = 8;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // numGiacenza
            // 
            this.numGiacenza.Location = new System.Drawing.Point(71, 550);
            this.numGiacenza.Name = "numGiacenza";
            this.numGiacenza.Size = new System.Drawing.Size(120, 20);
            this.numGiacenza.TabIndex = 9;
            // 
            // lblGiacenza
            // 
            this.lblGiacenza.AutoSize = true;
            this.lblGiacenza.Location = new System.Drawing.Point(13, 552);
            this.lblGiacenza.Name = "lblGiacenza";
            this.lblGiacenza.Size = new System.Drawing.Size(52, 13);
            this.lblGiacenza.TabIndex = 10;
            this.lblGiacenza.Text = "Giacenza";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(13, 576);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(24, 13);
            this.lblIVA.TabIndex = 11;
            this.lblIVA.Text = "IVA";
            // 
            // numIVA
            // 
            this.numIVA.Location = new System.Drawing.Point(71, 576);
            this.numIVA.Name = "numIVA";
            this.numIVA.Size = new System.Drawing.Size(120, 20);
            this.numIVA.TabIndex = 12;
            // 
            // BtnElimina
            // 
            this.BtnElimina.Location = new System.Drawing.Point(402, 421);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(115, 33);
            this.BtnElimina.TabIndex = 13;
            this.BtnElimina.Text = "Elimina articolo";
            this.BtnElimina.UseVisualStyleBackColor = true;
            this.BtnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // lblElimina
            // 
            this.lblElimina.AutoSize = true;
            this.lblElimina.Location = new System.Drawing.Point(399, 476);
            this.lblElimina.Name = "lblElimina";
            this.lblElimina.Size = new System.Drawing.Size(55, 13);
            this.lblElimina.TabIndex = 14;
            this.lblElimina.Text = "ID articolo";
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(460, 473);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(120, 20);
            this.numID.TabIndex = 15;
            // 
            // BtnCerca
            // 
            this.BtnCerca.Location = new System.Drawing.Point(402, 511);
            this.BtnCerca.Name = "BtnCerca";
            this.BtnCerca.Size = new System.Drawing.Size(115, 33);
            this.BtnCerca.TabIndex = 16;
            this.BtnCerca.Text = "Cerca";
            this.BtnCerca.UseVisualStyleBackColor = true;
            this.BtnCerca.Click += new System.EventHandler(this.BtnCerca_Click);
            // 
            // txtCerca
            // 
            this.txtCerca.Location = new System.Drawing.Point(402, 552);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(242, 20);
            this.txtCerca.TabIndex = 17;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(16, 618);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(749, 163);
            this.dataGridView3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 803);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.txtCerca);
            this.Controls.Add(this.BtnCerca);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.lblElimina);
            this.Controls.Add(this.BtnElimina);
            this.Controls.Add(this.numIVA);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblGiacenza);
            this.Controls.Add(this.numGiacenza);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.numPrezzo);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.BtnInserisci);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnArticoli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiacenza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnArticoli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnInserisci;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.NumericUpDown numPrezzo;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.NumericUpDown numGiacenza;
        private System.Windows.Forms.Label lblGiacenza;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.NumericUpDown numIVA;
        private System.Windows.Forms.Button BtnElimina;
        private System.Windows.Forms.Label lblElimina;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.Button BtnCerca;
        private System.Windows.Forms.TextBox txtCerca;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

