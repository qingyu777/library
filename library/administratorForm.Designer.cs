using System.Windows.Forms;

namespace library
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewForAdmin = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_left_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookLocationInput = new System.Windows.Forms.TextBox();
            this.bookTypeInput = new System.Windows.Forms.TextBox();
            this.bookAuthorInput = new System.Windows.Forms.TextBox();
            this.bookNameInput = new System.Windows.Forms.TextBox();
            this.bookIdInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.adminUsername = new System.Windows.Forms.Label();
            this.menuForAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除书籍信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForAdmin)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.menuForAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "账号：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 623);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.dataGridViewForAdmin);
            this.tabPage1.Controls.Add(this.bookLocationInput);
            this.tabPage1.Controls.Add(this.bookTypeInput);
            this.tabPage1.Controls.Add(this.bookAuthorInput);
            this.tabPage1.Controls.Add(this.bookNameInput);
            this.tabPage1.Controls.Add(this.bookIdInput);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查找书籍";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // dataGridViewForAdmin
            // 
            this.dataGridViewForAdmin.AllowUserToAddRows = false;
            this.dataGridViewForAdmin.AllowUserToOrderColumns = true;
            this.dataGridViewForAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.book_name,
            this.book_author,
            this.book_type,
            this.book_location,
            this.book_number,
            this.book_left_number});
            this.dataGridViewForAdmin.ContextMenuStrip = this.menuForAdmin;
            this.dataGridViewForAdmin.Location = new System.Drawing.Point(3, 133);
            this.dataGridViewForAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewForAdmin.Name = "dataGridViewForAdmin";
            this.dataGridViewForAdmin.ReadOnly = true;
            this.dataGridViewForAdmin.RowTemplate.Height = 27;
            this.dataGridViewForAdmin.Size = new System.Drawing.Size(880, 455);
            this.dataGridViewForAdmin.TabIndex = 18;
            this.dataGridViewForAdmin.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewUserSearchBookResult_CellMouseDown);
            // 
            // book_id
            // 
            this.book_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.book_id.HeaderText = "书籍编号";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Width = 75;
            // 
            // book_name
            // 
            this.book_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.book_name.HeaderText = "书名";
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            this.book_name.Width = 62;
            // 
            // book_author
            // 
            this.book_author.HeaderText = "书籍作者";
            this.book_author.Name = "book_author";
            this.book_author.ReadOnly = true;
            // 
            // book_type
            // 
            this.book_type.HeaderText = "书籍类型";
            this.book_type.Name = "book_type";
            this.book_type.ReadOnly = true;
            // 
            // book_location
            // 
            this.book_location.HeaderText = "书籍位置";
            this.book_location.Name = "book_location";
            this.book_location.ReadOnly = true;
            // 
            // book_number
            // 
            this.book_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.book_number.HeaderText = "书籍总数";
            this.book_number.Name = "book_number";
            this.book_number.ReadOnly = true;
            this.book_number.Width = 75;
            // 
            // book_left_number
            // 
            this.book_left_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.book_left_number.HeaderText = "剩余可借数量";
            this.book_left_number.Name = "book_left_number";
            this.book_left_number.ReadOnly = true;
            this.book_left_number.Width = 89;
            // 
            // bookLocationInput
            // 
            this.bookLocationInput.Location = new System.Drawing.Point(450, 41);
            this.bookLocationInput.Name = "bookLocationInput";
            this.bookLocationInput.Size = new System.Drawing.Size(185, 25);
            this.bookLocationInput.TabIndex = 25;
            // 
            // bookTypeInput
            // 
            this.bookTypeInput.Location = new System.Drawing.Point(450, 4);
            this.bookTypeInput.Name = "bookTypeInput";
            this.bookTypeInput.Size = new System.Drawing.Size(185, 25);
            this.bookTypeInput.TabIndex = 24;
            // 
            // bookAuthorInput
            // 
            this.bookAuthorInput.Location = new System.Drawing.Point(117, 72);
            this.bookAuthorInput.Name = "bookAuthorInput";
            this.bookAuthorInput.Size = new System.Drawing.Size(185, 25);
            this.bookAuthorInput.TabIndex = 22;
            // 
            // bookNameInput
            // 
            this.bookNameInput.Location = new System.Drawing.Point(117, 41);
            this.bookNameInput.Name = "bookNameInput";
            this.bookNameInput.Size = new System.Drawing.Size(185, 25);
            this.bookNameInput.TabIndex = 21;
            // 
            // bookIdInput
            // 
            this.bookIdInput.Location = new System.Drawing.Point(117, 4);
            this.bookIdInput.Name = "bookIdInput";
            this.bookIdInput.Size = new System.Drawing.Size(185, 25);
            this.bookIdInput.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "书籍作者：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "书籍类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "书籍位置：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "书籍名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "书籍id：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox19);
            this.tabPage2.Controls.Add(this.textBox18);
            this.tabPage2.Controls.Add(this.textBox17);
            this.tabPage2.Controls.Add(this.textBox16);
            this.tabPage2.Controls.Add(this.textBox15);
            this.tabPage2.Controls.Add(this.textBox14);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.textBox13);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "添加/更改书籍信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(439, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 36);
            this.button5.TabIndex = 25;
            this.button5.Text = "更改：";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(523, 219);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(158, 25);
            this.textBox19.TabIndex = 24;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(523, 182);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(158, 25);
            this.textBox18.TabIndex = 23;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(523, 138);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(158, 25);
            this.textBox17.TabIndex = 22;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(523, 105);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(158, 25);
            this.textBox16.TabIndex = 21;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(523, 72);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(158, 25);
            this.textBox15.TabIndex = 20;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(523, 35);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(158, 25);
            this.textBox14.TabIndex = 19;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(421, 222);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 15);
            this.label22.TabIndex = 18;
            this.label22.Text = "书籍数量：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(421, 182);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 15);
            this.label21.TabIndex = 17;
            this.label21.Text = "书籍位置：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(421, 141);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 15);
            this.label20.TabIndex = 16;
            this.label20.Text = "书籍作者：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(421, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 15);
            this.label19.TabIndex = 15;
            this.label19.Text = "书籍类型：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(436, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 14;
            this.label18.Text = "书籍名：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(435, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "书籍id：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(75, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "书籍作者：";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(170, 141);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(180, 25);
            this.textBox13.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 25);
            this.textBox1.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(75, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "书籍数量：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "添加：";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(170, 182);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(180, 25);
            this.textBox11.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(170, 102);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(180, 25);
            this.textBox10.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(170, 69);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(180, 25);
            this.textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(170, 35);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(180, 25);
            this.textBox8.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "书籍位置：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "书籍类型：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "书籍名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "书籍id：";
            // 
            // adminUsername
            // 
            this.adminUsername.AutoSize = true;
            this.adminUsername.Location = new System.Drawing.Point(95, 23);
            this.adminUsername.Name = "adminUsername";
            this.adminUsername.Size = new System.Drawing.Size(63, 15);
            this.adminUsername.TabIndex = 7;
            this.adminUsername.Text = "label14";
            // 
            // menuForAdmin
            // 
            this.menuForAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuForAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除书籍信息ToolStripMenuItem});
            this.menuForAdmin.Name = "menuForAdmin";
            this.menuForAdmin.Size = new System.Drawing.Size(169, 28);
            // 
            // 删除书籍信息ToolStripMenuItem
            // 
            this.删除书籍信息ToolStripMenuItem.Name = "删除书籍信息ToolStripMenuItem";
            this.删除书籍信息ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.删除书籍信息ToolStripMenuItem.Text = "删除书籍信息";
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 687);
            this.Controls.Add(this.adminUsername);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "AdministratorForm";
            this.Text = "管理员界面";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForAdmin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuForAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label adminUsername;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox bookLocationInput;
        private System.Windows.Forms.TextBox bookTypeInput;
        private System.Windows.Forms.TextBox bookAuthorInput;
        private System.Windows.Forms.TextBox bookNameInput;
        private System.Windows.Forms.TextBox bookIdInput;
        private System.Windows.Forms.DataGridView dataGridViewForAdmin;
        private DataGridViewTextBoxColumn admin_search_book_id;
        private DataGridViewTextBoxColumn admin_search_book_name;
        private DataGridViewTextBoxColumn admin_search_book_author;
        private DataGridViewTextBoxColumn admin_search_book_type;
        private DataGridViewTextBoxColumn admin_search_book_location;
        private DataGridViewTextBoxColumn admin_search_book_number;
        private DataGridViewTextBoxColumn admin_search_book_borrow_number;
        private DataGridViewTextBoxColumn book_id;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn book_author;
        private DataGridViewTextBoxColumn book_type;
        private DataGridViewTextBoxColumn book_location;
        private DataGridViewTextBoxColumn book_left_number;
        private DataGridViewTextBoxColumn book_number;
        private ContextMenuStrip menuForAdmin;
        private ToolStripMenuItem 删除书籍信息ToolStripMenuItem;
    }
}