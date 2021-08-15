
namespace _19.Proje
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
            this.tbMaas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbZam = new System.Windows.Forms.TextBox();
            this.tbPrim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lZamMiktari = new System.Windows.Forms.Label();
            this.lYeniMaas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maaş";
            // 
            // tbMaas
            // 
            this.tbMaas.Location = new System.Drawing.Point(239, 62);
            this.tbMaas.Name = "tbMaas";
            this.tbMaas.Size = new System.Drawing.Size(256, 27);
            this.tbMaas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Zam Oranı(%)";
            // 
            // tbZam
            // 
            this.tbZam.Location = new System.Drawing.Point(239, 145);
            this.tbZam.Name = "tbZam";
            this.tbZam.Size = new System.Drawing.Size(256, 27);
            this.tbZam.TabIndex = 1;
            // 
            // tbPrim
            // 
            this.tbPrim.Location = new System.Drawing.Point(239, 221);
            this.tbPrim.Name = "tbPrim";
            this.tbPrim.Size = new System.Drawing.Size(256, 27);
            this.tbPrim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prim";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(239, 274);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(256, 51);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zam Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yeni Maaş";
            // 
            // lZamMiktari
            // 
            this.lZamMiktari.AutoSize = true;
            this.lZamMiktari.Location = new System.Drawing.Point(374, 354);
            this.lZamMiktari.Name = "lZamMiktari";
            this.lZamMiktari.Size = new System.Drawing.Size(15, 20);
            this.lZamMiktari.TabIndex = 0;
            this.lZamMiktari.Text = "-";
            // 
            // lYeniMaas
            // 
            this.lYeniMaas.AutoSize = true;
            this.lYeniMaas.Location = new System.Drawing.Point(374, 402);
            this.lYeniMaas.Name = "lYeniMaas";
            this.lYeniMaas.Size = new System.Drawing.Size(15, 20);
            this.lYeniMaas.TabIndex = 0;
            this.lYeniMaas.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.tbPrim);
            this.Controls.Add(this.tbZam);
            this.Controls.Add(this.tbMaas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lYeniMaas);
            this.Controls.Add(this.lZamMiktari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbZam;
        private System.Windows.Forms.TextBox tbPrim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lZamMiktari;
        private System.Windows.Forms.Label lYeniMaas;
    }
}

