namespace library
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.loginBotton = new System.Windows.Forms.Button();
            this.registerBotton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBotton
            // 
            this.loginBotton.Location = new System.Drawing.Point(258, 258);
            this.loginBotton.Name = "loginBotton";
            this.loginBotton.Size = new System.Drawing.Size(90, 35);
            this.loginBotton.TabIndex = 0;
            this.loginBotton.Text = "登陆";
            this.loginBotton.UseVisualStyleBackColor = true;
            this.loginBotton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // registerBotton
            // 
            this.registerBotton.Location = new System.Drawing.Point(441, 258);
            this.registerBotton.Name = "registerBotton";
            this.registerBotton.Size = new System.Drawing.Size(90, 35);
            this.registerBotton.TabIndex = 1;
            this.registerBotton.Text = "注册";
            this.registerBotton.UseVisualStyleBackColor = true;
            this.registerBotton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 33);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(192, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "欢迎使用图书管理系统";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // searchBookButton
            // 
            this.searchBookButton.Location = new System.Drawing.Point(681, 25);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(107, 35);
            this.searchBookButton.TabIndex = 5;
            this.searchBookButton.Text = "游客查询：";
            this.searchBookButton.UseVisualStyleBackColor = true;
            this.searchBookButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBookButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerBotton);
            this.Controls.Add(this.loginBotton);
            this.Name = "Main";
            this.Text = "欢迎使用图书管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBotton;
        private System.Windows.Forms.Button registerBotton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBookButton;
    }
}

