
namespace _26.Proje
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBaslangic = new System.Windows.Forms.TextBox();
            this.tbBitis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lSayilar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitiş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sayılar";
            // 
            // tbBaslangic
            // 
            this.tbBaslangic.Location = new System.Drawing.Point(80, 65);
            this.tbBaslangic.Name = "tbBaslangic";
            this.tbBaslangic.Size = new System.Drawing.Size(205, 27);
            this.tbBaslangic.TabIndex = 1;
            // 
            // tbBitis
            // 
            this.tbBitis.Location = new System.Drawing.Point(80, 134);
            this.tbBitis.Name = "tbBitis";
            this.tbBitis.Size = new System.Drawing.Size(205, 27);
            this.tbBitis.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Say";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lSayilar
            // 
            this.lSayilar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lSayilar.Location = new System.Drawing.Point(80, 319);
            this.lSayilar.Name = "lSayilar";
            this.lSayilar.Size = new System.Drawing.Size(205, 155);
            this.lSayilar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBitis);
            this.Controls.Add(this.tbBaslangic);
            this.Controls.Add(this.lSayilar);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBaslangic;
        private System.Windows.Forms.TextBox tbBitis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lSayilar;
    }
}

