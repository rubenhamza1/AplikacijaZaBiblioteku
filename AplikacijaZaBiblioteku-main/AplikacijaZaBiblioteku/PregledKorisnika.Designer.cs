namespace AplikacijaZaBiblioteku
{
    partial class PregledKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledKorisnika));
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbPregledKorisnika = new System.Windows.Forms.RichTextBox();
            this.btnIzbrisiKorisnika = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btnPregledaj = new System.Windows.Forms.Button();
            this.btnDodajNovogKorisnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(21, 29);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(198, 20);
            this.txtPretrazi.TabIndex = 0;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretrazi.Location = new System.Drawing.Point(225, 27);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraži korisnika:";
            // 
            // rtbPregledKorisnika
            // 
            this.rtbPregledKorisnika.BackColor = System.Drawing.Color.White;
            this.rtbPregledKorisnika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPregledKorisnika.ForeColor = System.Drawing.Color.OrangeRed;
            this.rtbPregledKorisnika.Location = new System.Drawing.Point(21, 80);
            this.rtbPregledKorisnika.Name = "rtbPregledKorisnika";
            this.rtbPregledKorisnika.ReadOnly = true;
            this.rtbPregledKorisnika.Size = new System.Drawing.Size(529, 326);
            this.rtbPregledKorisnika.TabIndex = 3;
            this.rtbPregledKorisnika.Text = "Ime:\tPrezime:\t       Datum rođenja:\t         ID:\t       Broj telefona:           " +
    "  E-mail:  \t";
            // 
            // btnIzbrisiKorisnika
            // 
            this.btnIzbrisiKorisnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIzbrisiKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzbrisiKorisnika.Location = new System.Drawing.Point(114, 428);
            this.btnIzbrisiKorisnika.Name = "btnIzbrisiKorisnika";
            this.btnIzbrisiKorisnika.Size = new System.Drawing.Size(149, 25);
            this.btnIzbrisiKorisnika.TabIndex = 4;
            this.btnIzbrisiKorisnika.Text = "Izbriši odabranog korisnika";
            this.btnIzbrisiKorisnika.UseVisualStyleBackColor = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(533, 80);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 358);
            this.vScrollBar1.TabIndex = 6;
            // 
            // btnPregledaj
            // 
            this.btnPregledaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPregledaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPregledaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregledaj.Location = new System.Drawing.Point(21, 428);
            this.btnPregledaj.Name = "btnPregledaj";
            this.btnPregledaj.Size = new System.Drawing.Size(87, 25);
            this.btnPregledaj.TabIndex = 7;
            this.btnPregledaj.Text = "Pregledaj";
            this.btnPregledaj.UseVisualStyleBackColor = false;
            // 
            // btnDodajNovogKorisnika
            // 
            this.btnDodajNovogKorisnika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDodajNovogKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajNovogKorisnika.Location = new System.Drawing.Point(269, 428);
            this.btnDodajNovogKorisnika.Name = "btnDodajNovogKorisnika";
            this.btnDodajNovogKorisnika.Size = new System.Drawing.Size(149, 25);
            this.btnDodajNovogKorisnika.TabIndex = 8;
            this.btnDodajNovogKorisnika.Text = "Dodaj novog korisnika";
            this.btnDodajNovogKorisnika.UseVisualStyleBackColor = false;
            this.btnDodajNovogKorisnika.Click += new System.EventHandler(this.btnDodajNovogKorisnika_Click);
            // 
            // PregledKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 472);
            this.Controls.Add(this.btnDodajNovogKorisnika);
            this.Controls.Add(this.btnPregledaj);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnIzbrisiKorisnika);
            this.Controls.Add(this.rtbPregledKorisnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PregledKorisnika";
            this.Text = "Pregled korisnika";
            this.Load += new System.EventHandler(this.PregledKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbPregledKorisnika;
        private System.Windows.Forms.Button btnIzbrisiKorisnika;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btnPregledaj;
        private System.Windows.Forms.Button btnDodajNovogKorisnika;
    }
}