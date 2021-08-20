
namespace _21.Proje
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tekÇiftDeğerleriBelirleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxİçerisineEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekÇiftDeğerleriBelirleToolStripMenuItem,
            this.listBoxİçerisineEkleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 80);
            // 
            // tekÇiftDeğerleriBelirleToolStripMenuItem
            // 
            this.tekÇiftDeğerleriBelirleToolStripMenuItem.Name = "tekÇiftDeğerleriBelirleToolStripMenuItem";
            this.tekÇiftDeğerleriBelirleToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.tekÇiftDeğerleriBelirleToolStripMenuItem.Text = "Tek/Çift Değerleri Belirle";
            this.tekÇiftDeğerleriBelirleToolStripMenuItem.Click += new System.EventHandler(this.tekÇiftDeğerleriBelirleToolStripMenuItem_Click);
            // 
            // listBoxİçerisineEkleToolStripMenuItem
            // 
            this.listBoxİçerisineEkleToolStripMenuItem.Name = "listBoxİçerisineEkleToolStripMenuItem";
            this.listBoxİçerisineEkleToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.listBoxİçerisineEkleToolStripMenuItem.Text = "ListBox İçerisine Ekle";
            this.listBoxİçerisineEkleToolStripMenuItem.Click += new System.EventHandler(this.listBoxİçerisineEkleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 27);
            this.textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(260, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 224);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tekÇiftDeğerleriBelirleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxİçerisineEkleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

