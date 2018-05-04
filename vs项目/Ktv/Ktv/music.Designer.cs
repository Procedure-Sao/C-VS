namespace Ktv
{
    partial class music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(music));
            this.zhazha = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zhazha)).BeginInit();
            this.SuspendLayout();
            // 
            // zhazha
            // 
            this.zhazha.Enabled = true;
            this.zhazha.Location = new System.Drawing.Point(-1, 0);
            this.zhazha.Name = "zhazha";
            this.zhazha.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("zhazha.OcxState")));
            this.zhazha.Size = new System.Drawing.Size(285, 264);
            this.zhazha.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.zhazha);
            this.Name = "music";
            this.Text = "music";
            this.Load += new System.EventHandler(this.music_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zhazha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer zhazha;
        private System.Windows.Forms.Timer timer1;
    }
}