namespace FlowerShop
{
    partial class updateflower
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
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(51, 71);
            this.lab1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(88, 16);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "销售编号：";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(208, 71);
            this.lab2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(88, 16);
            this.lab2.TabIndex = 1;
            this.lab2.Text = "销售数量：";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(492, 71);
            this.lab3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(56, 16);
            this.lab3.TabIndex = 2;
            this.lab3.Text = "单价：";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(51, 137);
            this.lab4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(56, 16);
            this.lab4.TabIndex = 3;
            this.lab4.Text = "备注：";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(320, 68);
            this.txt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(132, 26);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(573, 68);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(132, 26);
            this.txt2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(114, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(550, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(221, 263);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(96, 36);
            this.but1.TabIndex = 7;
            this.but1.Text = "保存";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(495, 262);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(89, 37);
            this.but2.TabIndex = 8;
            this.but2.Text = "退出";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateflower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 311);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "updateflower";
            this.Text = "修改鲜花销售信息";
            this.Load += new System.EventHandler(this.updateflower_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
    }
}