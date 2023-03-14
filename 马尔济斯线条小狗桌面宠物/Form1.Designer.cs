namespace WindowsFormsApp2
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.qQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wechatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网易云音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vs2022ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小狗记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小狗草稿本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qQToolStripMenuItem,
            this.wechatToolStripMenuItem,
            this.steamToolStripMenuItem,
            this.网易云音乐ToolStripMenuItem,
            this.vs2022ToolStripMenuItem,
            this.小狗记事本ToolStripMenuItem,
            this.小狗草稿本ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 244);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // qQToolStripMenuItem
            // 
            this.qQToolStripMenuItem.Name = "qQToolStripMenuItem";
            this.qQToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.qQToolStripMenuItem.Text = "QQ";
            this.qQToolStripMenuItem.Click += new System.EventHandler(this.qQToolStripMenuItem_Click);
            // 
            // wechatToolStripMenuItem
            // 
            this.wechatToolStripMenuItem.Name = "wechatToolStripMenuItem";
            this.wechatToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.wechatToolStripMenuItem.Text = "Wechat";
            this.wechatToolStripMenuItem.Click += new System.EventHandler(this.wechatToolStripMenuItem_Click);
            // 
            // steamToolStripMenuItem
            // 
            this.steamToolStripMenuItem.Name = "steamToolStripMenuItem";
            this.steamToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.steamToolStripMenuItem.Text = "Steam";
            this.steamToolStripMenuItem.Click += new System.EventHandler(this.steamToolStripMenuItem_Click);
            // 
            // 网易云音乐ToolStripMenuItem
            // 
            this.网易云音乐ToolStripMenuItem.Name = "网易云音乐ToolStripMenuItem";
            this.网易云音乐ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.网易云音乐ToolStripMenuItem.Text = "网易云音乐";
            this.网易云音乐ToolStripMenuItem.Click += new System.EventHandler(this.网易云音乐ToolStripMenuItem_Click);
            // 
            // vs2022ToolStripMenuItem
            // 
            this.vs2022ToolStripMenuItem.Name = "vs2022ToolStripMenuItem";
            this.vs2022ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.vs2022ToolStripMenuItem.Text = "Microsoft Edge";
            this.vs2022ToolStripMenuItem.Click += new System.EventHandler(this.vs2022ToolStripMenuItem_Click);
            // 
            // 小狗记事本ToolStripMenuItem
            // 
            this.小狗记事本ToolStripMenuItem.Name = "小狗记事本ToolStripMenuItem";
            this.小狗记事本ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.小狗记事本ToolStripMenuItem.Text = "小狗记事本";
            this.小狗记事本ToolStripMenuItem.Click += new System.EventHandler(this.小狗记事本ToolStripMenuItem_Click);
            // 
            // 小狗草稿本ToolStripMenuItem
            // 
            this.小狗草稿本ToolStripMenuItem.Name = "小狗草稿本ToolStripMenuItem";
            this.小狗草稿本ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.小狗草稿本ToolStripMenuItem.Text = "小狗草稿本";
            this.小狗草稿本ToolStripMenuItem.Click += new System.EventHandler(this.小狗草稿本ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.小狗5;
            this.pictureBox1.Location = new System.Drawing.Point(30, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 252);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wechatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网易云音乐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vs2022ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小狗记事本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小狗草稿本ToolStripMenuItem;
    }
}

