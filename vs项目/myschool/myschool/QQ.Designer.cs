namespace myschool
{
    partial class QQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QQ));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Q号 = new System.Windows.Forms.Label();
            this.Q密 = new System.Windows.Forms.Label();
            this.登方 = new System.Windows.Forms.Label();
            this.tet1 = new System.Windows.Forms.TextBox();
            this.tet2 = new System.Windows.Forms.TextBox();
            this.登方1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(144, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(340, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Q号
            // 
            this.Q号.AutoSize = true;
            this.Q号.BackColor = System.Drawing.Color.Transparent;
            this.Q号.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Q号.ForeColor = System.Drawing.Color.Gainsboro;
            this.Q号.Location = new System.Drawing.Point(140, 126);
            this.Q号.Name = "Q号";
            this.Q号.Size = new System.Drawing.Size(48, 19);
            this.Q号.TabIndex = 2;
            this.Q号.Text = "QQ号";
            this.Q号.Click += new System.EventHandler(this.Q号_Click);
            // 
            // Q密
            // 
            this.Q密.AutoSize = true;
            this.Q密.BackColor = System.Drawing.Color.Transparent;
            this.Q密.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Q密.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Q密.Location = new System.Drawing.Point(140, 165);
            this.Q密.Name = "Q密";
            this.Q密.Size = new System.Drawing.Size(47, 19);
            this.Q密.TabIndex = 3;
            this.Q密.Text = "密码";
            this.Q密.Click += new System.EventHandler(this.label2_Click);
            // 
            // 登方
            // 
            this.登方.AutoSize = true;
            this.登方.BackColor = System.Drawing.Color.Transparent;
            this.登方.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.登方.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.登方.Location = new System.Drawing.Point(132, 203);
            this.登方.Name = "登方";
            this.登方.Size = new System.Drawing.Size(85, 19);
            this.登方.TabIndex = 4;
            this.登方.Text = "登录方式";
            this.登方.Click += new System.EventHandler(this.登方_Click);
            // 
            // tet1
            // 
            this.tet1.Location = new System.Drawing.Point(228, 124);
            this.tet1.Name = "tet1";
            this.tet1.Size = new System.Drawing.Size(175, 21);
            this.tet1.TabIndex = 5;
            // 
            // tet2
            // 
            this.tet2.Location = new System.Drawing.Point(228, 162);
            this.tet2.Name = "tet2";
            this.tet2.PasswordChar = '*';
            this.tet2.Size = new System.Drawing.Size(175, 21);
            this.tet2.TabIndex = 6;
            // 
            // 登方1
            // 
            this.登方1.FormattingEnabled = true;
            this.登方1.Items.AddRange(new object[] {
            "在线",
            "隐身",
            "忙碌"});
            this.登方1.Location = new System.Drawing.Point(228, 203);
            this.登方1.Name = "登方1";
            this.登方1.Size = new System.Drawing.Size(175, 20);
            this.登方1.TabIndex = 7;
            // 
            // QQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 368);
            this.Controls.Add(this.登方1);
            this.Controls.Add(this.tet2);
            this.Controls.Add(this.tet1);
            this.Controls.Add(this.登方);
            this.Controls.Add(this.Q密);
            this.Controls.Add(this.Q号);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QQ登录";
            this.Load += new System.EventHandler(this.QQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Q号;
        private System.Windows.Forms.Label Q密;
        private System.Windows.Forms.Label 登方;
        private System.Windows.Forms.TextBox tet1;
        private System.Windows.Forms.TextBox tet2;
        private System.Windows.Forms.ComboBox 登方1;
    }
}

