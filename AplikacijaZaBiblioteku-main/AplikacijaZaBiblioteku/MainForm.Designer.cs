namespace AplikacijaZaBiblioteku
{
    partial class MainForm
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
            System.Windows.Forms.Button btnPregledKorisnika;
            System.Windows.Forms.Button btnPregledLiterature;
            System.Windows.Forms.Button btnDodajNovogKorisnika;
            System.Windows.Forms.Button btnDodajNovuLiteraturu;
            System.Windows.Forms.Button btnPosudba;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            btnPregledKorisnika = new System.Windows.Forms.Button();
            btnPregledLiterature = new System.Windows.Forms.Button();
            btnDodajNovogKorisnika = new System.Windows.Forms.Button();
            btnDodajNovuLiteraturu = new System.Windows.Forms.Button();
            btnPosudba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPregledKorisnika
            // 
            btnPregledKorisnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btnPregledKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnPregledKorisnika.ForeColor = System.Drawing.Color.Black;
            btnPregledKorisnika.Location = new System.Drawing.Point(57, 136);
            btnPregledKorisnika.Name = "btnPregledKorisnika";
            btnPregledKorisnika.Size = new System.Drawing.Size(179, 30);
            btnPregledKorisnika.TabIndex = 1;
            btnPregledKorisnika.Text = "Pregled korisnika";
            btnPregledKorisnika.UseVisualStyleBackColor = false;
            btnPregledKorisnika.Click += new System.EventHandler(this.btnPregledKorisnika_Click);
            // 
            // btnPregledLiterature
            // 
            btnPregledLiterature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btnPregledLiterature.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnPregledLiterature.ForeColor = System.Drawing.Color.Black;
            btnPregledLiterature.Location = new System.Drawing.Point(57, 298);
            btnPregledLiterature.Name = "btnPregledLiterature";
            btnPregledLiterature.Size = new System.Drawing.Size(179, 30);
            btnPregledLiterature.TabIndex = 2;
            btnPregledLiterature.Text = "Pregled literature";
            btnPregledLiterature.UseVisualStyleBackColor = false;
            btnPregledLiterature.Click += new System.EventHandler(this.btnPregledLiterature_Click);
            // 
            // btnDodajNovogKorisnika
            // 
            btnDodajNovogKorisnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btnDodajNovogKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDodajNovogKorisnika.ForeColor = System.Drawing.Color.Black;
            btnDodajNovogKorisnika.Location = new System.Drawing.Point(57, 187);
            btnDodajNovogKorisnika.Name = "btnDodajNovogKorisnika";
            btnDodajNovogKorisnika.Size = new System.Drawing.Size(179, 30);
            btnDodajNovogKorisnika.TabIndex = 3;
            btnDodajNovogKorisnika.Text = "Dodaj novog korisnika";
            btnDodajNovogKorisnika.UseVisualStyleBackColor = false;
            btnDodajNovogKorisnika.Click += new System.EventHandler(this.btnDodajNovogKorisnika_Click);
            // 
            // btnDodajNovuLiteraturu
            // 
            btnDodajNovuLiteraturu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btnDodajNovuLiteraturu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDodajNovuLiteraturu.ForeColor = System.Drawing.Color.Black;
            btnDodajNovuLiteraturu.Location = new System.Drawing.Point(57, 344);
            btnDodajNovuLiteraturu.Name = "btnDodajNovuLiteraturu";
            btnDodajNovuLiteraturu.Size = new System.Drawing.Size(179, 30);
            btnDodajNovuLiteraturu.TabIndex = 4;
            btnDodajNovuLiteraturu.Text = "Dodaj novu literaturu";
            btnDodajNovuLiteraturu.UseVisualStyleBackColor = false;
            btnDodajNovuLiteraturu.Click += new System.EventHandler(this.btnDodajNovuLiteraturu_Click);
            // 
            // btnPosudba
            // 
            btnPosudba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btnPosudba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnPosudba.ForeColor = System.Drawing.Color.Black;
            btnPosudba.Location = new System.Drawing.Point(552, 136);
            btnPosudba.Name = "btnPosudba";
            btnPosudba.Size = new System.Drawing.Size(179, 30);
            btnPosudba.TabIndex = 5;
            btnPosudba.Text = "Posudba i vraćanje knjiga";
            btnPosudba.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(124, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Korisnici";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(124, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Literatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImageIndex = 0;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Knjižnica grada Rovinja";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(btnPosudba);
            this.Controls.Add(btnDodajNovuLiteraturu);
            this.Controls.Add(btnDodajNovogKorisnika);
            this.Controls.Add(btnPregledLiterature);
            this.Controls.Add(btnPregledKorisnika);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Knjižnica grada Rovinja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}