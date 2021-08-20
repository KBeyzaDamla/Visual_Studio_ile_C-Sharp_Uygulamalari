
namespace _25.Proje
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
            this.tbMetin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAranan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lHarfSayisi = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metin";
            // 
            // tbMetin
            // 
            this.tbMetin.Location = new System.Drawing.Point(232, 72);
            this.tbMetin.Name = "tbMetin";
            this.tbMetin.Size = new System.Drawing.Size(230, 27);
            this.tbMetin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aranan Harf";
            // 
            // tbAranan
            // 
            this.tbAranan.Location = new System.Drawing.Point(232, 158);
            this.tbAranan.MaxLength = 1;
            this.tbAranan.Name = "tbAranan";
            this.tbAranan.Size = new System.Drawing.Size(230, 27);
            this.tbAranan.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Say";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Harf Sayısı";
            // 
            // lHarfSayisi
            // 
            this.lHarfSayisi.AutoSize = true;
            this.lHarfSayisi.Location = new System.Drawing.Point(356, 364);
            this.lHarfSayisi.Name = "lHarfSayisi";
            this.lHarfSayisi.Size = new System.Drawing.Size(15, 20);
            this.lHarfSayisi.TabIndex = 0;
            this.lHarfSayisi.Text = "-";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(232, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(245, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Büyük/Küçük Harf Duyarlılığı Var";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAranan);
            this.Controls.Add(this.tbMetin);
            this.Controls.Add(this.lHarfSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAranan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lHarfSayisi;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

