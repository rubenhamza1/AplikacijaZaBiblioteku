namespace AplikacijaZaBiblioteku
{
    partial class PregledLiterature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledLiterature));
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btnIzbrisiKnjIzBaze = new System.Windows.Forms.Button();
            this.rtbPregledKnjiga = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraziKnjigu = new System.Windows.Forms.Button();
            this.txtPretraziKnjigu = new System.Windows.Forms.TextBox();
            this.btnOznaciKnjKaoNedostupnu = new System.Windows.Forms.Button();
            this.btnDodajNovuKnj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(524, 73);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 358);
            this.vScrollBar1.TabIndex = 12;
            // 
            // btnIzbrisiKnjIzBaze
            // 
            this.btnIzbrisiKnjIzBaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIzbrisiKnjIzBaze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzbrisiKnjIzBaze.Location = new System.Drawing.Point(565, 73);
            this.btnIzbrisiKnjIzBaze.Name = "btnIzbrisiKnjIzBaze";
            this.btnIzbrisiKnjIzBaze.Size = new System.Drawing.Size(149, 43);
            this.btnIzbrisiKnjIzBaze.TabIndex = 11;
            this.btnIzbrisiKnjIzBaze.Text = "Izbriši odabranu knjigu iz baze";
            this.btnIzbrisiKnjIzBaze.UseVisualStyleBackColor = false;
            // 
            // rtbPregledKnjiga
            // 
            this.rtbPregledKnjiga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPregledKnjiga.Location = new System.Drawing.Point(12, 73);
            this.rtbPregledKnjiga.Name = "rtbPregledKnjiga";
            this.rtbPregledKnjiga.ReadOnly = true;
            this.rtbPregledKnjiga.Size = new System.Drawing.Size(529, 358);
            this.rtbPregledKnjiga.TabIndex = 10;
            this.rtbPregledKnjiga.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pretraži knjigu:";
            // 
            // btnPretraziKnjigu
            // 
            this.btnPretraziKnjigu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPretraziKnjigu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretraziKnjigu.Location = new System.Drawing.Point(216, 31);
            this.btnPretraziKnjigu.Name = "btnPretraziKnjigu";
            this.btnPretraziKnjigu.Size = new System.Drawing.Size(75, 23);
            this.btnPretraziKnjigu.TabIndex = 8;
            this.btnPretraziKnjigu.Text = "Pretraži";
            this.btnPretraziKnjigu.UseVisualStyleBackColor = false;
            // 
            // txtPretraziKnjigu
            // 
            this.txtPretraziKnjigu.Location = new System.Drawing.Point(12, 33);
            this.txtPretraziKnjigu.Name = "txtPretraziKnjigu";
            this.txtPretraziKnjigu.Size = new System.Drawing.Size(198, 20);
            this.txtPretraziKnjigu.TabIndex = 7;
            // 
            // btnOznaciKnjKaoNedostupnu
            // 
            this.btnOznaciKnjKaoNedostupnu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOznaciKnjKaoNedostupnu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOznaciKnjKaoNedostupnu.Location = new System.Drawing.Point(565, 142);
            this.btnOznaciKnjKaoNedostupnu.Name = "btnOznaciKnjKaoNedostupnu";
            this.btnOznaciKnjKaoNedostupnu.Size = new System.Drawing.Size(149, 43);
            this.btnOznaciKnjKaoNedostupnu.TabIndex = 13;
            this.btnOznaciKnjKaoNedostupnu.Text = "Označi odabranu knjigu kao nedostupnu";
            this.btnOznaciKnjKaoNedostupnu.UseVisualStyleBackColor = false;
            // 
            // btnDodajNovuKnj
            // 
            this.btnDodajNovuKnj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDodajNovuKnj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajNovuKnj.Location = new System.Drawing.Point(565, 210);
            this.btnDodajNovuKnj.Name = "btnDodajNovuKnj";
            this.btnDodajNovuKnj.Size = new System.Drawing.Size(149, 43);
            this.btnDodajNovuKnj.TabIndex = 14;
            this.btnDodajNovuKnj.Text = "Dodaj novu knjigu";
            this.btnDodajNovuKnj.UseVisualStyleBackColor = false;
            this.btnDodajNovuKnj.Click += new System.EventHandler(this.btnDodajNovuKnj_Click);
            // 
            // PregledLiterature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.btnDodajNovuKnj);
            this.Controls.Add(this.btnOznaciKnjKaoNedostupnu);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnIzbrisiKnjIzBaze);
            this.Controls.Add(this.rtbPregledKnjiga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraziKnjigu);
            this.Controls.Add(this.txtPretraziKnjigu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PregledLiterature";
            this.Text = "PregledLiterature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btnIzbrisiKnjIzBaze;
        private System.Windows.Forms.RichTextBox rtbPregledKnjiga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraziKnjigu;
        private System.Windows.Forms.TextBox txtPretraziKnjigu;
        private System.Windows.Forms.Button btnOznaciKnjKaoNedostupnu;
        private System.Windows.Forms.Button btnDodajNovuKnj;
    }
}