namespace Travel
{
    partial class frmshow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.lab3 = new System.Windows.Forms.Label();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(12, 27);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(41, 12);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "日期：";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(279, 33);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(41, 12);
            this.lab2.TabIndex = 1;
            this.lab2.Text = "地点：";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(80, 24);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(111, 21);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(348, 24);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 21);
            this.txt2.TabIndex = 3;
            // 
            // rtb1
            // 
            this.rtb1.Location = new System.Drawing.Point(59, 68);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(412, 262);
            this.rtb1.TabIndex = 4;
            this.rtb1.Text = "";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(12, 71);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(41, 12);
            this.lab3.TabIndex = 5;
            this.lab3.Text = "见闻：";
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(125, 340);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(75, 23);
            this.but1.TabIndex = 6;
            this.but1.Text = "保 存";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(323, 340);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(75, 23);
            this.but2.TabIndex = 7;
            this.but2.Text = "退 出";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 375);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmshow";
            this.Text = "旅行日志";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
    }
}

