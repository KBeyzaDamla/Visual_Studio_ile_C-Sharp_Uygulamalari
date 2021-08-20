
namespace _23.Proje
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
            this.tbVize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lGecmeNotu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vize";
            // 
            // tbVize
            // 
            this.tbVize.Location = new System.Drawing.Point(251, 63);
            this.tbVize.Name = "tbVize";
            this.tbVize.Size = new System.Drawing.Size(125, 27);
            this.tbVize.TabIndex = 1;
            this.tbVize.TextChanged += new System.EventHandler(this.tbVize_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Final";
            // 
            // tbFinal
            // 
            this.tbFinal.Location = new System.Drawing.Point(251, 155);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(125, 27);
            this.tbFinal.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Geçme Notu";
            // 
            // lGecmeNotu
            // 
            this.lGecmeNotu.AutoSize = true;
            this.lGecmeNotu.Location = new System.Drawing.Point(251, 271);
            this.lGecmeNotu.Name = "lGecmeNotu";
            this.lGecmeNotu.Size = new System.Drawing.Size(15, 20);
            this.lGecmeNotu.TabIndex = 0;
            this.lGecmeNotu.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbFinal);
            this.Controls.Add(this.tbVize);
            this.Controls.Add(this.lGecmeNotu);
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
        private System.Windows.Forms.TextBox tbVize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lGecmeNotu;
    }
}

