namespace VotoForms
{
    partial class FormVoto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonCalcola = new Button();
            TextBoxVoto = new TextBox();
            LabelTitolo = new Label();
            ButtonRGB = new Button();
            SuspendLayout();
            // 
            // ButtonCalcola
            // 
            ButtonCalcola.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCalcola.Location = new Point(131, 34);
            ButtonCalcola.Name = "ButtonCalcola";
            ButtonCalcola.Size = new Size(75, 24);
            ButtonCalcola.TabIndex = 0;
            ButtonCalcola.Text = "Calcola";
            ButtonCalcola.UseVisualStyleBackColor = true;
            ButtonCalcola.Click += ButtonCalcola_Click;
            // 
            // TextBoxVoto
            // 
            TextBoxVoto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxVoto.Location = new Point(12, 32);
            TextBoxVoto.Name = "TextBoxVoto";
            TextBoxVoto.Size = new Size(100, 27);
            TextBoxVoto.TabIndex = 1;
            // 
            // LabelTitolo
            // 
            LabelTitolo.AutoSize = true;
            LabelTitolo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitolo.Location = new Point(12, 9);
            LabelTitolo.Name = "LabelTitolo";
            LabelTitolo.Size = new Size(94, 20);
            LabelTitolo.TabIndex = 2;
            LabelTitolo.Text = "Calcola voto";
            // 
            // FormVoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 144);
            Controls.Add(ButtonRGB);
            Controls.Add(LabelTitolo);
            Controls.Add(TextBoxVoto);
            Controls.Add(ButtonCalcola);
            Name = "FormVoto";
            Text = "Voto";
            Load += FormVoto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCalcola;
        private TextBox TextBoxVoto;
        private Label LabelTitolo;
        private Button ButtonRGB;
    }
}