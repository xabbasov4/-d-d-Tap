using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ƏdədTap
{

    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.yenioyunbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelCehd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // yenioyunbtn
            // 
            this.yenioyunbtn.BackColor = System.Drawing.Color.Maroon;
            this.yenioyunbtn.ForeColor = System.Drawing.Color.White;
            this.yenioyunbtn.Location = new System.Drawing.Point(20, 20);
            this.yenioyunbtn.Name = "yenioyunbtn";
            this.yenioyunbtn.Size = new System.Drawing.Size(180, 35);
            this.yenioyunbtn.TabIndex = 0;
            this.yenioyunbtn.Text = "Yeni Oyun";
            this.yenioyunbtn.UseVisualStyleBackColor = false;
            this.yenioyunbtn.Click += new System.EventHandler(this.yenioyunbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Axtarılan ədəd:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yoxla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(230, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 148);
            this.listBox1.TabIndex = 4;
            // 
            // labelCehd
            // 
            this.labelCehd.AutoSize = true;
            this.labelCehd.ForeColor = System.Drawing.Color.White;
            this.labelCehd.Location = new System.Drawing.Point(230, 180);
            this.labelCehd.Name = "labelCehd";
            this.labelCehd.Size = new System.Drawing.Size(81, 16);
            this.labelCehd.TabIndex = 5;
            this.labelCehd.Text = "Cəhd sayı: 0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(460, 220);
            this.Controls.Add(this.labelCehd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yenioyunbtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ədəd Tap Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yenioyunbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelCehd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}