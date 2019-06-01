namespace library
{
    partial class Login
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
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.studentLoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwardInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Location = new System.Drawing.Point(177, 207);
            this.adminLoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(78, 27);
            this.adminLoginButton.TabIndex = 0;
            this.adminLoginButton.Text = "管理员登陆";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            this.adminLoginButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // studentLoginButton
            // 
            this.studentLoginButton.Location = new System.Drawing.Point(326, 207);
            this.studentLoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentLoginButton.Name = "studentLoginButton";
            this.studentLoginButton.Size = new System.Drawing.Size(72, 27);
            this.studentLoginButton.TabIndex = 1;
            this.studentLoginButton.Text = "用户登陆";
            this.studentLoginButton.UseVisualStyleBackColor = true;
            this.studentLoginButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号：";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(218, 74);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(168, 21);
            this.usernameInput.TabIndex = 4;
            this.usernameInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // passwardInput
            // 
            this.passwardInput.Location = new System.Drawing.Point(218, 118);
            this.passwardInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwardInput.Name = "passwardInput";
            this.passwardInput.PasswordChar = '*';
            this.passwardInput.Size = new System.Drawing.Size(168, 21);
            this.passwardInput.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.passwardInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentLoginButton);
            this.Controls.Add(this.adminLoginButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "登陆界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.Button studentLoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwardInput;
    }
}