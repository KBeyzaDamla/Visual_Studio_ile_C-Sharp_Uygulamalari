
namespace _17.Proje
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDonustur = new System.Windows.Forms.Button();
            this.lYeniIfade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İfade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 27);
            this.textBox1.TabIndex = 1;
            // 
            // btnDonustur
            // 
            this.btnDonustur.Location = new System.Drawing.Point(151, 128);
            this.btnDonustur.Name = "btnDonustur";
            this.btnDonustur.Size = new System.Drawing.Size(187, 40);
            this.btnDonustur.TabIndex = 2;
            this.btnDonustur.Text = "Dönüştür";
            this.btnDonustur.UseVisualStyleBackColor = true;
            this.btnDonustur.Click += new System.EventHandler(this.btnDonustur_Click);
            // 
            // lYeniIfade
            // 
            this.lYeniIfade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lYeniIfade.Location = new System.Drawing.Point(53, 206);
            this.lYeniIfade.Name = "lYeniIfade";
            this.lYeniIfade.Size = new System.Drawing.Size(390, 177);
            this.lYeniIfade.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDonustur);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lYeniIfade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDonustur;
        private System.Windows.Forms.Label lYeniIfade;
    }
}

