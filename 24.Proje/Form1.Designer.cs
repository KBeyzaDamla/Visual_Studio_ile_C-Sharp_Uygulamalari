
namespace _24.Proje
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbBaslangic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBitis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbArtisMiktari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDegerler = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç";
            // 
            // tbBaslangic
            // 
            this.tbBaslangic.Location = new System.Drawing.Point(51, 86);
            this.tbBaslangic.Name = "tbBaslangic";
            this.tbBaslangic.Size = new System.Drawing.Size(369, 27);
            this.tbBaslangic.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitiş";
            // 
            // tbBitis
            // 
            this.tbBitis.Location = new System.Drawing.Point(51, 170);
            this.tbBitis.Name = "tbBitis";
            this.tbBitis.Size = new System.Drawing.Size(369, 27);
            this.tbBitis.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Artış Miktarı";
            // 
            // tbArtisMiktari
            // 
            this.tbArtisMiktari.Location = new System.Drawing.Point(51, 261);
            this.tbArtisMiktari.Name = "tbArtisMiktari";
            this.tbArtisMiktari.Size = new System.Drawing.Size(369, 27);
            this.tbArtisMiktari.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Değerler";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(480, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 202);
            this.button1.TabIndex = 2;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDegerler
            // 
            this.tbDegerler.Location = new System.Drawing.Point(51, 369);
            this.tbDegerler.Multiline = true;
            this.tbDegerler.Name = "tbDegerler";
            this.tbDegerler.Size = new System.Drawing.Size(369, 159);
            this.tbDegerler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDegerler);
            this.Controls.Add(this.tbArtisMiktari);
            this.Controls.Add(this.tbBitis);
            this.Controls.Add(this.tbBaslangic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbArtisMiktari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbDegerler;
    }
}

