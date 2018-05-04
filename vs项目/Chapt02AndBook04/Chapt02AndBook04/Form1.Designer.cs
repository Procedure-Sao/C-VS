namespace Chapt02AndBook04
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rdoman = new System.Windows.Forms.RadioButton();
            this.rdowoman = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lblstuNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtstuNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btoLogin = new System.Windows.Forms.Button();
            this.btoResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rdoman
            // 
            this.rdoman.AutoSize = true;
            this.rdoman.BackColor = System.Drawing.Color.Transparent;
            this.rdoman.Location = new System.Drawing.Point(263, 186);
            this.rdoman.Name = "rdoman";
            this.rdoman.Size = new System.Drawing.Size(43, 19);
            this.rdoman.TabIndex = 0;
            this.rdoman.TabStop = true;
            this.rdoman.Text = "男";
            this.rdoman.UseVisualStyleBackColor = false;
            // 
            // rdowoman
            // 
            this.rdowoman.AutoSize = true;
            this.rdowoman.BackColor = System.Drawing.Color.Transparent;
            this.rdowoman.Location = new System.Drawing.Point(395, 186);
            this.rdowoman.Name = "rdowoman";
            this.rdowoman.Size = new System.Drawing.Size(43, 19);
            this.rdowoman.TabIndex = 1;
            this.rdowoman.TabStop = true;
            this.rdowoman.Text = "女";
            this.rdowoman.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(127, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(127, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "出生日期：";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(274, 337);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 23);
            this.cboClass.TabIndex = 5;
            // 
            // lblstuNo
            // 
            this.lblstuNo.AutoSize = true;
            this.lblstuNo.BackColor = System.Drawing.Color.Transparent;
            this.lblstuNo.Location = new System.Drawing.Point(127, 47);
            this.lblstuNo.Name = "lblstuNo";
            this.lblstuNo.Size = new System.Drawing.Size(52, 15);
            this.lblstuNo.TabIndex = 6;
            this.lblstuNo.Text = "学号：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(127, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "姓名：";
            // 
            // txtstuNo
            // 
            this.txtstuNo.Location = new System.Drawing.Point(263, 44);
            this.txtstuNo.Name = "txtstuNo";
            this.txtstuNo.Size = new System.Drawing.Size(100, 25);
            this.txtstuNo.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(263, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 9;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Location = new System.Drawing.Point(127, 340);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(52, 15);
            this.lblClass.TabIndex = 10;
            this.lblClass.Text = "班级：";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblpwd.Location = new System.Drawing.Point(127, 144);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(52, 15);
            this.lblpwd.TabIndex = 11;
            this.lblpwd.Text = "密码：";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(263, 141);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(100, 25);
            this.txtpwd.TabIndex = 12;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(127, 239);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(45, 15);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "电话:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(263, 229);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 25);
            this.txtPhone.TabIndex = 14;
            // 
            // btoLogin
            // 
            this.btoLogin.BackColor = System.Drawing.Color.Transparent;
            this.btoLogin.Location = new System.Drawing.Point(150, 394);
            this.btoLogin.Name = "btoLogin";
            this.btoLogin.Size = new System.Drawing.Size(75, 23);
            this.btoLogin.TabIndex = 15;
            this.btoLogin.Text = "提交";
            this.btoLogin.UseVisualStyleBackColor = false;
            this.btoLogin.Click += new System.EventHandler(this.btoLogin_Click);
            // 
            // btoResult
            // 
            this.btoResult.Location = new System.Drawing.Point(395, 394);
            this.btoResult.Name = "btoResult";
            this.btoResult.Size = new System.Drawing.Size(75, 23);
            this.btoResult.TabIndex = 16;
            this.btoResult.Text = "取消";
            this.btoResult.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 17;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(263, 277);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 25);
            this.dtp1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 438);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btoResult);
            this.Controls.Add(this.btoLogin);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtstuNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblstuNo);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdowoman);
            this.Controls.Add(this.rdoman);
            this.Name = "Form1";
            this.Text = "新建学生信息界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoman;
        private System.Windows.Forms.RadioButton rdowoman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblstuNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtstuNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btoLogin;
        private System.Windows.Forms.Button btoResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp1;
    }
}

