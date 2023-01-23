namespace AplikacijaZaBiblioteku
{
    partial class Form2
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
            this.btnPregledKorisnika = new System.Windows.Forms.Button();
            this.btnPregledLiterature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Knjižnica grada Rovinja";
            // 
            // btnPregledKorisnika
            // 
            this.btnPregledKorisnika.Location = new System.Drawing.Point(47, 115);
            this.btnPregledKorisnika.Name = "btnPregledKorisnika";
            this.btnPregledKorisnika.Size = new System.Drawing.Size(104, 30);
            this.btnPregledKorisnika.TabIndex = 1;
            this.btnPregledKorisnika.Text = "Pregled korisnika";
            this.btnPregledKorisnika.UseVisualStyleBackColor = true;
            this.btnPregledKorisnika.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPregledLiterature
            // 
            this.btnPregledLiterature.Location = new System.Drawing.Point(47, 191);
            this.btnPregledLiterature.Name = "btnPregledLiterature";
            this.btnPregledLiterature.Size = new System.Drawing.Size(104, 30);
            this.btnPregledLiterature.TabIndex = 2;
            this.btnPregledLiterature.Text = "Pregled literature";
            this.btnPregledLiterature.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPregledLiterature);
            this.Controls.Add(this.btnPregledKorisnika);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPregledKorisnika;
        private System.Windows.Forms.Button btnPregledLiterature;
    }
}