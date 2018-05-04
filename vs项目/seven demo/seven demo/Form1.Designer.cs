namespace seven_demo
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
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.but1 = new System.Windows.Forms.Button();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.nup1 = new System.Windows.Forms.NumericUpDown();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.lab11 = new System.Windows.Forms.Label();
            this.lab10 = new System.Windows.Forms.Label();
            this.lab9 = new System.Windows.Forms.Label();
            this.lab8 = new System.Windows.Forms.Label();
            this.lab7 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.gbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.gbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.comboBox2);
            this.gbox1.Controls.Add(this.dgv1);
            this.gbox1.Controls.Add(this.comboBox1);
            this.gbox1.Controls.Add(this.but1);
            this.gbox1.Controls.Add(this.lab2);
            this.gbox1.Controls.Add(this.lab1);
            this.gbox1.Location = new System.Drawing.Point(12, 12);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(715, 208);
            this.gbox1.TabIndex = 0;
            this.gbox1.TabStop = false;
            this.gbox1.Text = "航班信息";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(394, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 18;
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv1.Location = new System.Drawing.Point(0, 52);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(715, 150);
            this.dgv1.TabIndex = 3;
            this.dgv1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FlightNO";
            this.Column1.HeaderText = "航班号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Airways";
            this.Column2.HeaderText = "航空公司";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LeaveTime";
            this.Column3.HeaderText = "出发时间";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LandTime";
            this.Column4.HeaderText = "到达时间";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Price";
            this.Column5.HeaderText = "成人票价";
            this.Column5.Name = "Column5";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 17;
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(534, 15);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(75, 23);
            this.but1.TabIndex = 2;
            this.but1.Text = "查询";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(347, 20);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(41, 12);
            this.lab2.TabIndex = 1;
            this.lab2.Text = "目的地";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(48, 21);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(41, 12);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "出发地";
            // 
            // gbox2
            // 
            this.gbox2.Controls.Add(this.nup1);
            this.gbox2.Controls.Add(this.txt7);
            this.gbox2.Controls.Add(this.txt6);
            this.gbox2.Controls.Add(this.txt5);
            this.gbox2.Controls.Add(this.txt4);
            this.gbox2.Controls.Add(this.txt3);
            this.gbox2.Controls.Add(this.txt2);
            this.gbox2.Controls.Add(this.txt1);
            this.gbox2.Controls.Add(this.dtp1);
            this.gbox2.Controls.Add(this.lab11);
            this.gbox2.Controls.Add(this.lab10);
            this.gbox2.Controls.Add(this.lab9);
            this.gbox2.Controls.Add(this.lab8);
            this.gbox2.Controls.Add(this.lab7);
            this.gbox2.Controls.Add(this.lab6);
            this.gbox2.Controls.Add(this.lab5);
            this.gbox2.Controls.Add(this.lab4);
            this.gbox2.Controls.Add(this.lab3);
            this.gbox2.Location = new System.Drawing.Point(12, 240);
            this.gbox2.Name = "gbox2";
            this.gbox2.Size = new System.Drawing.Size(715, 221);
            this.gbox2.TabIndex = 1;
            this.gbox2.TabStop = false;
            this.gbox2.Text = "航班预订";
            // 
            // nup1
            // 
            this.nup1.Location = new System.Drawing.Point(152, 183);
            this.nup1.Name = "nup1";
            this.nup1.Size = new System.Drawing.Size(120, 21);
            this.nup1.TabIndex = 17;
            this.nup1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(486, 106);
            this.txt7.Name = "txt7";
            this.txt7.ReadOnly = true;
            this.txt7.Size = new System.Drawing.Size(100, 21);
            this.txt7.TabIndex = 16;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(486, 72);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(100, 21);
            this.txt6.TabIndex = 15;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(486, 29);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(100, 21);
            this.txt5.TabIndex = 14;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(152, 143);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(100, 21);
            this.txt4.TabIndex = 13;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(152, 109);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(100, 21);
            this.txt3.TabIndex = 12;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(152, 72);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(100, 21);
            this.txt2.TabIndex = 11;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(152, 32);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(100, 21);
            this.txt1.TabIndex = 10;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(486, 177);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(111, 21);
            this.dtp1.TabIndex = 9;
            // 
            // lab11
            // 
            this.lab11.AutoSize = true;
            this.lab11.Location = new System.Drawing.Point(407, 183);
            this.lab11.Name = "lab11";
            this.lab11.Size = new System.Drawing.Size(53, 12);
            this.lab11.TabIndex = 8;
            this.lab11.Text = "出发时间";
            // 
            // lab10
            // 
            this.lab10.AutoSize = true;
            this.lab10.Location = new System.Drawing.Point(407, 109);
            this.lab10.Name = "lab10";
            this.lab10.Size = new System.Drawing.Size(53, 12);
            this.lab10.TabIndex = 7;
            this.lab10.Text = "到达时间";
            // 
            // lab9
            // 
            this.lab9.AutoSize = true;
            this.lab9.Location = new System.Drawing.Point(419, 75);
            this.lab9.Name = "lab9";
            this.lab9.Size = new System.Drawing.Size(41, 12);
            this.lab9.TabIndex = 6;
            this.lab9.Text = "目的地";
            // 
            // lab8
            // 
            this.lab8.AutoSize = true;
            this.lab8.Location = new System.Drawing.Point(407, 32);
            this.lab8.Name = "lab8";
            this.lab8.Size = new System.Drawing.Size(53, 12);
            this.lab8.TabIndex = 5;
            this.lab8.Text = "航空公司";
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.Location = new System.Drawing.Point(36, 183);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(53, 12);
            this.lab7.TabIndex = 4;
            this.lab7.Text = "预订数量";
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Location = new System.Drawing.Point(36, 146);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(53, 12);
            this.lab6.TabIndex = 3;
            this.lab6.Text = "成人票价";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(38, 109);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(53, 12);
            this.lab5.TabIndex = 2;
            this.lab5.Text = "出发时间";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(50, 75);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(41, 12);
            this.lab4.TabIndex = 1;
            this.lab4.Text = "出发地";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(50, 32);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(41, 12);
            this.lab3.TabIndex = 0;
            this.lab3.Text = "航班号";
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(448, 481);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(75, 23);
            this.but2.TabIndex = 2;
            this.but2.Text = "预订";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(577, 481);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(75, 23);
            this.but3.TabIndex = 3;
            this.but3.Text = "退出";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 516);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.gbox1);
            this.Name = "Form1";
            this.Text = "航班查询及预订";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.gbox2.ResumeLayout(false);
            this.gbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.GroupBox gbox2;
        private System.Windows.Forms.Label lab11;
        private System.Windows.Forms.Label lab10;
        private System.Windows.Forms.Label lab9;
        private System.Windows.Forms.Label lab8;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.NumericUpDown nup1;
    }
}

