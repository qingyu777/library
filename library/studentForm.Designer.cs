﻿using System.Windows.Forms;

namespace library
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.修改密码 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewUserSearchBookResult = new System.Windows.Forms.DataGridView();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuForUserSearchedBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.借阅书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTypeInput = new System.Windows.Forms.TextBox();
            this.bookAuthorInput = new System.Windows.Forms.TextBox();
            this.bookNameInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.刷新 = new System.Windows.Forms.Button();
            this.dataGridView_bookBorrowed = new System.Windows.Forms.DataGridView();
            this.book_name_Borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_author_Borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_type_Borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_location_Borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentUsername = new System.Windows.Forms.Label();
            this.修改密码.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserSearchBookResult)).BeginInit();
            this.menuForUserSearchedBooks.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookBorrowed)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // 修改密码
            // 
            this.修改密码.Controls.Add(this.tabPage1);
            this.修改密码.Controls.Add(this.tabPage2);
            this.修改密码.Controls.Add(this.tabPage3);
            this.修改密码.Location = new System.Drawing.Point(-6, 22);
            this.修改密码.Name = "修改密码";
            this.修改密码.SelectedIndex = 0;
            this.修改密码.Size = new System.Drawing.Size(806, 545);
            this.修改密码.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.dataGridViewUserSearchBookResult);
            this.tabPage1.Controls.Add(this.bookTypeInput);
            this.tabPage1.Controls.Add(this.bookAuthorInput);
            this.tabPage1.Controls.Add(this.bookNameInput);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.searchBookButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查找书籍";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // dataGridViewUserSearchBookResult
            // 
            this.dataGridViewUserSearchBookResult.AllowUserToAddRows = false;
            this.dataGridViewUserSearchBookResult.AllowUserToOrderColumns = true;
            this.dataGridViewUserSearchBookResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserSearchBookResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_name,
            this.book_author,
            this.book_type,
            this.book_location,
            this.book_number});
            this.dataGridViewUserSearchBookResult.ContextMenuStrip = this.menuForUserSearchedBooks;
            this.dataGridViewUserSearchBookResult.Location = new System.Drawing.Point(34, 70);
            this.dataGridViewUserSearchBookResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUserSearchBookResult.Name = "dataGridViewUserSearchBookResult";
            this.dataGridViewUserSearchBookResult.ReadOnly = true;
            this.dataGridViewUserSearchBookResult.RowTemplate.Height = 27;
            this.dataGridViewUserSearchBookResult.Size = new System.Drawing.Size(670, 431);
            this.dataGridViewUserSearchBookResult.TabIndex = 18;
            this.dataGridViewUserSearchBookResult.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUserSearchBookResult_CellMouseDown);
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
            this.book_number.HeaderText = "剩余可借数量";
            this.book_number.Name = "book_number";
            this.book_number.ReadOnly = true;
            this.book_number.Width = 89;
            // 
            // menuForUserSearchedBooks
            // 
            this.menuForUserSearchedBooks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuForUserSearchedBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借阅书籍ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuForUserSearchedBooks.Name = "menuForUserSearchedBooks";
            this.menuForUserSearchedBooks.Size = new System.Drawing.Size(139, 52);
            this.menuForUserSearchedBooks.Opening += new System.ComponentModel.CancelEventHandler(this.MenuForUserSearchedBooks_Opening);
            // 
            // 借阅书籍ToolStripMenuItem
            // 
            this.借阅书籍ToolStripMenuItem.Name = "借阅书籍ToolStripMenuItem";
            this.借阅书籍ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.借阅书籍ToolStripMenuItem.Text = "借阅书籍";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem2.Text = "123";
            // 
            // bookTypeInput
            // 
            this.bookTypeInput.Location = new System.Drawing.Point(455, 14);
            this.bookTypeInput.Name = "bookTypeInput";
            this.bookTypeInput.Size = new System.Drawing.Size(136, 25);
            this.bookTypeInput.TabIndex = 20;
            // 
            // bookAuthorInput
            // 
            this.bookAuthorInput.Location = new System.Drawing.Point(129, 40);
            this.bookAuthorInput.Name = "bookAuthorInput";
            this.bookAuthorInput.Size = new System.Drawing.Size(149, 25);
            this.bookAuthorInput.TabIndex = 19;
            this.bookAuthorInput.TextChanged += new System.EventHandler(this.BookAutherInput_TextChanged);
            // 
            // bookNameInput
            // 
            this.bookNameInput.Location = new System.Drawing.Point(129, 7);
            this.bookNameInput.Name = "bookNameInput";
            this.bookNameInput.Size = new System.Drawing.Size(149, 25);
            this.bookNameInput.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "书籍作者：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "书籍类型：";
            // 
            // searchBookButton
            // 
            this.searchBookButton.Location = new System.Drawing.Point(636, 17);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(94, 38);
            this.searchBookButton.TabIndex = 5;
            this.searchBookButton.Text = "查询";
            this.searchBookButton.UseVisualStyleBackColor = true;
            this.searchBookButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "书籍名：";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.刷新);
            this.tabPage2.Controls.Add(this.dataGridView_bookBorrowed);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "已借阅书籍";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // 刷新
            // 
            this.刷新.Location = new System.Drawing.Point(34, 17);
            this.刷新.Name = "刷新";
            this.刷新.Size = new System.Drawing.Size(75, 30);
            this.刷新.TabIndex = 19;
            this.刷新.Text = "刷新";
            this.刷新.UseVisualStyleBackColor = true;
            // 
            // dataGridView_bookBorrowed
            // 
            this.dataGridView_bookBorrowed.AllowUserToAddRows = false;
            this.dataGridView_bookBorrowed.AllowUserToOrderColumns = true;
            this.dataGridView_bookBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bookBorrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_name_Borrowed,
            this.book_author_Borrowed,
            this.book_type_Borrowed,
            this.book_location_Borrowed,
            this.borrowedDatetime});
            this.dataGridView_bookBorrowed.Location = new System.Drawing.Point(34, 70);
            this.dataGridView_bookBorrowed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_bookBorrowed.Name = "dataGridView_bookBorrowed";
            this.dataGridView_bookBorrowed.ReadOnly = true;
            this.dataGridView_bookBorrowed.RowTemplate.Height = 27;
            this.dataGridView_bookBorrowed.Size = new System.Drawing.Size(745, 429);
            this.dataGridView_bookBorrowed.TabIndex = 18;
            // 
            // book_name_Borrowed
            // 
            this.book_name_Borrowed.HeaderText = "书名";
            this.book_name_Borrowed.Name = "book_name_Borrowed";
            this.book_name_Borrowed.ReadOnly = true;
            // 
            // book_author_Borrowed
            // 
            this.book_author_Borrowed.HeaderText = "书籍作者";
            this.book_author_Borrowed.Name = "book_author_Borrowed";
            this.book_author_Borrowed.ReadOnly = true;
            // 
            // book_type_Borrowed
            // 
            this.book_type_Borrowed.HeaderText = "书籍类型";
            this.book_type_Borrowed.Name = "book_type_Borrowed";
            this.book_type_Borrowed.ReadOnly = true;
            // 
            // book_location_Borrowed
            // 
            this.book_location_Borrowed.HeaderText = "书籍位置";
            this.book_location_Borrowed.Name = "book_location_Borrowed";
            this.book_location_Borrowed.ReadOnly = true;
            // 
            // borrowedDatetime
            // 
            this.borrowedDatetime.HeaderText = "借阅时间";
            this.borrowedDatetime.Name = "borrowedDatetime";
            this.borrowedDatetime.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(798, 516);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "修改密码";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "确认修改";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(179, 108);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(201, 25);
            this.textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(179, 73);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(201, 25);
            this.textBox7.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "新密码：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "账号：";
            // 
            // studentUsername
            // 
            this.studentUsername.AutoSize = true;
            this.studentUsername.Location = new System.Drawing.Point(610, 22);
            this.studentUsername.Name = "studentUsername";
            this.studentUsername.Size = new System.Drawing.Size(63, 15);
            this.studentUsername.TabIndex = 8;
            this.studentUsername.Text = "label12";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(807, 579);
            this.Controls.Add(this.studentUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.修改密码);
            this.Name = "StudentForm";
            this.Text = "用户界面";
            this.修改密码.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserSearchBookResult)).EndInit();
            this.menuForUserSearchedBooks.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookBorrowed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl 修改密码;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label studentUsername;
        private System.Windows.Forms.TextBox bookTypeInput;
        private System.Windows.Forms.TextBox bookAuthorInput;
        private System.Windows.Forms.TextBox bookNameInput;
        private System.Windows.Forms.DataGridView dataGridViewUserSearchBookResult;
        private System.Windows.Forms.DataGridView dataGridView_bookBorrowed;
        private DataGridViewTextBoxColumn book_name_Borrowed;
        private DataGridViewTextBoxColumn book_author_Borrowed;
        private DataGridViewTextBoxColumn book_type_Borrowed;
        private DataGridViewTextBoxColumn book_location_Borrowed;
        private DataGridViewTextBoxColumn borrowedDatetime;
        private Button 刷新;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn book_author;
        private DataGridViewTextBoxColumn book_type;
        private DataGridViewTextBoxColumn book_location;
        private DataGridViewTextBoxColumn book_number;
        private ContextMenuStrip menuForUserSearchedBooks;
        private ToolStripMenuItem 借阅书籍ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}