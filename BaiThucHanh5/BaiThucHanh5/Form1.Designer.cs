﻿namespace BaiThucHanh5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CSC = new System.Windows.Forms.TextBox();
            this.CSM = new System.Windows.Forms.TextBox();
            this.DN = new System.Windows.Forms.TextBox();
            this.TT = new System.Windows.Forms.TextBox();
            this.VAT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(50, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉ số cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(50, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chỉ số mới";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(50, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện năng tiêu thụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(50, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thành tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(50, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng tiền đã có VAT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(99, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tính tiền điện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2.Location = new System.Drawing.Point(243, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tiếp tục";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button3.Location = new System.Drawing.Point(369, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(126, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tính tiền điện sinh hoạt bật thang";
            // 
            // CSC
            // 
            this.CSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.CSC.Location = new System.Drawing.Point(232, 179);
            this.CSC.Name = "CSC";
            this.CSC.Size = new System.Drawing.Size(173, 27);
            this.CSC.TabIndex = 9;
            this.CSC.TextChanged += new System.EventHandler(this.CSC_TextChanged);
            // 
            // CSM
            // 
            this.CSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.CSM.Location = new System.Drawing.Point(232, 221);
            this.CSM.Name = "CSM";
            this.CSM.Size = new System.Drawing.Size(173, 27);
            this.CSM.TabIndex = 10;
            this.CSM.TextChanged += new System.EventHandler(this.CSM_TextChanged);
            // 
            // DN
            // 
            this.DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.DN.Location = new System.Drawing.Point(232, 254);
            this.DN.Name = "DN";
            this.DN.Size = new System.Drawing.Size(173, 27);
            this.DN.TabIndex = 11;
            this.DN.TextChanged += new System.EventHandler(this.DN_TextChanged);
            // 
            // TT
            // 
            this.TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.TT.Location = new System.Drawing.Point(232, 292);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(173, 27);
            this.TT.TabIndex = 12;
            this.TT.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // VAT
            // 
            this.VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.VAT.Location = new System.Drawing.Point(232, 328);
            this.VAT.Name = "VAT";
            this.VAT.Size = new System.Drawing.Size(173, 27);
            this.VAT.TabIndex = 13;
            this.VAT.TextChanged += new System.EventHandler(this.VAT_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.VAT);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.DN);
            this.Controls.Add(this.CSM);
            this.Controls.Add(this.CSC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chỉ số cũ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CSC;
        private System.Windows.Forms.TextBox CSM;
        private System.Windows.Forms.TextBox DN;
        private System.Windows.Forms.TextBox TT;
        private System.Windows.Forms.TextBox VAT;
    }
}

