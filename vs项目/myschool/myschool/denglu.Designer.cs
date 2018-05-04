namespace myschool
{
    partial class denglu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(denglu));
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.BackColor = System.Drawing.Color.Transparent;
            this.lab1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab1.Location = new System.Drawing.Point(98, 53);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(40, 16);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "账号";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.BackColor = System.Drawing.Color.Transparent;
            this.lab2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab2.Location = new System.Drawing.Point(98, 101);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(40, 16);
            this.lab2.TabIndex = 1;
            this.lab2.Text = "密码";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.BackColor = System.Drawing.Color.Transparent;
            this.lab3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab3.ForeColor = System.Drawing.Color.Black;
            this.lab3.Location = new System.Drawing.Point(70, 162);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(72, 16);
            this.lab3.TabIndex = 2;
            this.lab3.Text = "登录方式";
            // 
            // but1
            // 
            this.but1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but1.Location = new System.Drawing.Point(67, 251);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(75, 23);
            this.but1.TabIndex = 3;
            this.but1.Text = "登陆";
            this.but1.UseVisualStyleBackColor = true;
            // 
            // but2
            // 
            this.but2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but2.Location = new System.Drawing.Point(257, 251);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(75, 23);
            this.but2.TabIndex = 4;
            this.but2.Text = "退出";
            this.but2.UseVisualStyleBackColor = true;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(202, 48);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(117, 21);
            this.txt1.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(202, 87);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(117, 21);
            this.txt2.TabIndex = 6;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(202, 163);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 20);
            this.cmb1.TabIndex = 7;
            // 
            // denglu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 308);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "denglu";
            this.Text = "登陆";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.denglu_Load);
            this.Click += new System.EventHandler(this.denglu_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.ComboBox cmb1;
    }
}