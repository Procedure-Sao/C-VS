namespace FrmStudent
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("男", 3, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("女", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("1", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("男", 3, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("女", 2, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("2", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("男", 3, 3);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("女", 2, 2);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("3", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("4");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("5");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode10,
            treeNode11});
            this.txt1 = new System.Windows.Forms.TextBox();
            this.but1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(238, 38);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(176, 21);
            this.txt1.TabIndex = 0;
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(587, 32);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(81, 30);
            this.but1.TabIndex = 1;
            this.but1.Text = "查询";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
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
            this.Column5,
            this.Column6});
            this.dgv1.Location = new System.Drawing.Point(142, 68);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(546, 343);
            this.dgv1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserId";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserName";
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UserPwd";
            this.Column3.HeaderText = "密码";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LevelId";
            this.Column4.HeaderText = "等级";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "邮箱";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "OnLineDay";
            this.Column6.HeaderText = "天数";
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(139, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "查询";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01.gif");
            this.imageList1.Images.SetKeyName(1, "02.gif");
            this.imageList1.Images.SetKeyName(2, "03.gif");
            this.imageList1.Images.SetKeyName(3, "04.gif");
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "节点4";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "男";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "节点5";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "女";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "节点1";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "1";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "节点6";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "男";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "节点7";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "女";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "节点2";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "2";
            treeNode7.ImageIndex = 3;
            treeNode7.Name = "节点8";
            treeNode7.SelectedImageIndex = 3;
            treeNode7.Text = "男";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "节点9";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "女";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "节点3";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "3";
            treeNode10.Name = "节点0";
            treeNode10.Text = "4";
            treeNode11.Name = "节点1";
            treeNode11.Text = "5";
            treeNode12.Name = "节点0";
            treeNode12.Text = "全部";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(133, 445);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 445);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.txt1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}