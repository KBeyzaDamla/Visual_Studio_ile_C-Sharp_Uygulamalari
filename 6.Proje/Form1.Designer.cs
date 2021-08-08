
namespace _6.Proje
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rbArttir = new System.Windows.Forms.RadioButton();
            this.rbAzalt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lSayi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(294, 58);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miktar";
            // 
            // rbArttir
            // 
            this.rbArttir.AutoSize = true;
            this.rbArttir.Checked = true;
            this.rbArttir.Location = new System.Drawing.Point(261, 132);
            this.rbArttir.Name = "rbArttir";
            this.rbArttir.Size = new System.Drawing.Size(64, 24);
            this.rbArttir.TabIndex = 2;
            this.rbArttir.TabStop = true;
            this.rbArttir.Text = "Arttır";
            this.rbArttir.UseVisualStyleBackColor = true;
            // 
            // rbAzalt
            // 
            this.rbAzalt.AutoSize = true;
            this.rbAzalt.Location = new System.Drawing.Point(405, 132);
            this.rbAzalt.Name = "rbAzalt";
            this.rbAzalt.Size = new System.Drawing.Size(64, 24);
            this.rbAzalt.TabIndex = 2;
            this.rbAzalt.Text = "Azalt";
            this.rbAzalt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı";
            // 
            // lSayi
            // 
            this.lSayi.AutoSize = true;
            this.lSayi.Location = new System.Drawing.Point(361, 305);
            this.lSayi.Name = "lSayi";
            this.lSayi.Size = new System.Drawing.Size(17, 20);
            this.lSayi.TabIndex = 1;
            this.lSayi.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbAzalt);
            this.Controls.Add(this.rbArttir);
            this.Controls.Add(this.lSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbArttir;
        private System.Windows.Forms.RadioButton rbAzalt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lSayi;
        private System.Windows.Forms.Button button1;
    }
}

