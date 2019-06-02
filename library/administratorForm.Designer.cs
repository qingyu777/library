using System.Drawing;
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewForAdminSearchBook = new System.Windows.Forms.DataGridView();
            this.admin_search_book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_search_book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_search_book_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_search_book_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_search_book_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_search_book_borrow_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_search_book_left_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookLocationInput = new System.Windows.Forms.TextBox();
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
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.updateBookNumberInput = new System.Windows.Forms.TextBox();
            this.updateBookLocationInput = new System.Windows.Forms.TextBox();
            this.updateBookAuthorInput = new System.Windows.Forms.TextBox();
            this.updateBookNameInput = new System.Windows.Forms.TextBox();
            this.updateBookIdIput = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.insertBookAuthorInput = new System.Windows.Forms.TextBox();
            this.insertBookNumberInput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.insertBookLocationInput = new System.Windows.Forms.TextBox();
            this.insertBookNameInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewForAdminSearchBorrow = new System.Windows.Forms.DataGridView();
            dataGridViewForAdminSearchBorrow.ForeColor = Color.Black;
            this.admin_search_borrow_record_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_search_borrow_book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_search_borrow_student_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_search_borrow_time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.borrowRecordBookNameInput = new System.Windows.Forms.TextBox();
            this.borrowRecordStudentUsernameInput = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.studentPasswardInput = new System.Windows.Forms.TextBox();
            this.studentIdInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.newAdminPasswardInput = new System.Windows.Forms.TextBox();
            this.oldAdminPasswardInput = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adminUsername = new System.Windows.Forms.Label();
            this.menuForAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bookTypeInput = new System.Windows.Forms.ComboBox();
            this.insertBookTypeInput = new System.Windows.Forms.ComboBox();
            this.updateBookTypeInput = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForAdminSearchBook)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForAdminSearchBorrow)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "账号：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(-3, 62);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 622);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.bookTypeInput);
            this.tabPage1.Controls.Add(this.dataGridViewForAdminSearchBook);
            this.tabPage1.Controls.Add(this.bookLocationInput);
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(885, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查找书籍";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // dataGridViewForAdminSearchBook
            // 
            this.dataGridViewForAdminSearchBook.AllowUserToAddRows = false;
            this.dataGridViewForAdminSearchBook.AllowUserToOrderColumns = true;
            this.dataGridViewForAdminSearchBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForAdminSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForAdminSearchBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admin_search_book_id,
            this.admin_search_book_name,
            this.admin_search_book_type,
            this.admin_search_book_author,
            this.admin_search_book_location,
            this.admin_search_book_borrow_number,
            this.admin_search_book_left_number});
            this.dataGridViewForAdminSearchBook.Location = new System.Drawing.Point(3, 102);
            this.dataGridViewForAdminSearchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewForAdminSearchBook.Name = "dataGridViewForAdminSearchBook";
            this.dataGridViewForAdminSearchBook.ReadOnly = true;
            this.dataGridViewForAdminSearchBook.RowTemplate.Height = 27;
            this.dataGridViewForAdminSearchBook.Size = new System.Drawing.Size(880, 486);
            this.dataGridViewForAdminSearchBook.TabIndex = 18;
            this.dataGridViewForAdminSearchBook.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewUserSearchBookResult_CellMouseDown);
            // 
            // admin_search_book_id
            // 
            this.admin_search_book_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.admin_search_book_id.HeaderText = "书籍编号";
            this.admin_search_book_id.Name = "admin_search_book_id";
            this.admin_search_book_id.ReadOnly = true;
            this.admin_search_book_id.Width = 75;
            // 
            // admin_search_book_name
            // 
            this.admin_search_book_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.admin_search_book_name.HeaderText = "书名";
            this.admin_search_book_name.Name = "admin_search_book_name";
            this.admin_search_book_name.ReadOnly = true;
            this.admin_search_book_name.Width = 62;
            // 
            // admin_search_book_type
            // 
            this.admin_search_book_type.HeaderText = "书籍类型";
            this.admin_search_book_type.Name = "admin_search_book_type";
            this.admin_search_book_type.ReadOnly = true;
            // 
            // admin_search_book_author
            // 
            this.admin_search_book_author.HeaderText = "书籍作者";
            this.admin_search_book_author.Name = "admin_search_book_author";
            this.admin_search_book_author.ReadOnly = true;
            // 
            // admin_search_book_location
            // 
            this.admin_search_book_location.HeaderText = "书籍位置";
            this.admin_search_book_location.Name = "admin_search_book_location";
            this.admin_search_book_location.ReadOnly = true;
            // 
            // admin_search_book_borrow_number
            // 
            this.admin_search_book_borrow_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.admin_search_book_borrow_number.HeaderText = "书籍总数";
            this.admin_search_book_borrow_number.Name = "admin_search_book_borrow_number";
            this.admin_search_book_borrow_number.ReadOnly = true;
            this.admin_search_book_borrow_number.Width = 75;
            // 
            // admin_search_book_left_number
            // 
            this.admin_search_book_left_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.admin_search_book_left_number.HeaderText = "剩余可借数量";
            this.admin_search_book_left_number.Name = "admin_search_book_left_number";
            this.admin_search_book_left_number.ReadOnly = true;
            this.admin_search_book_left_number.Width = 89;
            // 
            // bookLocationInput
            // 
            this.bookLocationInput.Location = new System.Drawing.Point(451, 39);
            this.bookLocationInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookLocationInput.Name = "bookLocationInput";
            this.bookLocationInput.Size = new System.Drawing.Size(185, 25);
            this.bookLocationInput.TabIndex = 25;
            // 
            // bookAuthorInput
            // 
            this.bookAuthorInput.Location = new System.Drawing.Point(117, 72);
            this.bookAuthorInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookAuthorInput.Name = "bookAuthorInput";
            this.bookAuthorInput.Size = new System.Drawing.Size(185, 25);
            this.bookAuthorInput.TabIndex = 22;
            // 
            // bookNameInput
            // 
            this.bookNameInput.Location = new System.Drawing.Point(117, 39);
            this.bookNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookNameInput.Name = "bookNameInput";
            this.bookNameInput.Size = new System.Drawing.Size(185, 25);
            this.bookNameInput.TabIndex = 21;
            // 
            // bookIdInput
            // 
            this.bookIdInput.Location = new System.Drawing.Point(117, 4);
            this.bookIdInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookIdInput.Name = "bookIdInput";
            this.bookIdInput.Size = new System.Drawing.Size(185, 25);
            this.bookIdInput.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "书籍作者：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 84);
            this.button1.TabIndex = 15;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "书籍类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "书籍位置：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "书籍名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "书籍id：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.updateBookTypeInput);
            this.tabPage2.Controls.Add(this.insertBookTypeInput);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.updateBookNumberInput);
            this.tabPage2.Controls.Add(this.updateBookLocationInput);
            this.tabPage2.Controls.Add(this.updateBookAuthorInput);
            this.tabPage2.Controls.Add(this.updateBookNameInput);
            this.tabPage2.Controls.Add(this.updateBookIdIput);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.insertBookAuthorInput);
            this.tabPage2.Controls.Add(this.insertBookNumberInput);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.insertBookLocationInput);
            this.tabPage2.Controls.Add(this.insertBookNameInput);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(885, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "添加/更改书籍信息";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(768, 69);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 40);
            this.button7.TabIndex = 26;
            this.button7.Text = "查询";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(527, 312);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 36);
            this.button5.TabIndex = 25;
            this.button5.Text = "更改";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // updateBookNumberInput
            // 
            this.updateBookNumberInput.Location = new System.Drawing.Point(548, 251);
            this.updateBookNumberInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBookNumberInput.Name = "updateBookNumberInput";
            this.updateBookNumberInput.Size = new System.Drawing.Size(159, 25);
            this.updateBookNumberInput.TabIndex = 24;
            // 
            // updateBookLocationInput
            // 
            this.updateBookLocationInput.Location = new System.Drawing.Point(548, 215);
            this.updateBookLocationInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBookLocationInput.Name = "updateBookLocationInput";
            this.updateBookLocationInput.Size = new System.Drawing.Size(159, 25);
            this.updateBookLocationInput.TabIndex = 23;
            // 
            // updateBookAuthorInput
            // 
            this.updateBookAuthorInput.Location = new System.Drawing.Point(548, 179);
            this.updateBookAuthorInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBookAuthorInput.Name = "updateBookAuthorInput";
            this.updateBookAuthorInput.Size = new System.Drawing.Size(159, 25);
            this.updateBookAuthorInput.TabIndex = 22;
            // 
            // updateBookNameInput
            // 
            this.updateBookNameInput.Location = new System.Drawing.Point(548, 106);
            this.updateBookNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBookNameInput.Name = "updateBookNameInput";
            this.updateBookNameInput.Size = new System.Drawing.Size(159, 25);
            this.updateBookNameInput.TabIndex = 20;
            // 
            // updateBookIdIput
            // 
            this.updateBookIdIput.Location = new System.Drawing.Point(548, 70);
            this.updateBookIdIput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBookIdIput.Name = "updateBookIdIput";
            this.updateBookIdIput.Size = new System.Drawing.Size(159, 25);
            this.updateBookIdIput.TabIndex = 19;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(447, 256);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 15);
            this.label22.TabIndex = 18;
            this.label22.Text = "书籍数量：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(447, 220);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 15);
            this.label21.TabIndex = 17;
            this.label21.Text = "书籍位置：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(447, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 15);
            this.label20.TabIndex = 16;
            this.label20.Text = "书籍作者：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(447, 148);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 15);
            this.label19.TabIndex = 15;
            this.label19.Text = "书籍类型：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(461, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 14;
            this.label18.Text = "书籍名：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(460, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "书籍id：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "书籍作者：";
            // 
            // insertBookAuthorInput
            // 
            this.insertBookAuthorInput.Location = new System.Drawing.Point(140, 144);
            this.insertBookAuthorInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertBookAuthorInput.Name = "insertBookAuthorInput";
            this.insertBookAuthorInput.Size = new System.Drawing.Size(180, 25);
            this.insertBookAuthorInput.TabIndex = 11;
            // 
            // insertBookNumberInput
            // 
            this.insertBookNumberInput.Location = new System.Drawing.Point(140, 219);
            this.insertBookNumberInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertBookNumberInput.Name = "insertBookNumberInput";
            this.insertBookNumberInput.Size = new System.Drawing.Size(180, 25);
            this.insertBookNumberInput.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "书籍数量：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 259);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // insertBookLocationInput
            // 
            this.insertBookLocationInput.Location = new System.Drawing.Point(140, 181);
            this.insertBookLocationInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertBookLocationInput.Name = "insertBookLocationInput";
            this.insertBookLocationInput.Size = new System.Drawing.Size(180, 25);
            this.insertBookLocationInput.TabIndex = 7;
            // 
            // insertBookNameInput
            // 
            this.insertBookNameInput.Location = new System.Drawing.Point(140, 69);
            this.insertBookNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertBookNameInput.Name = "insertBookNameInput";
            this.insertBookNameInput.Size = new System.Drawing.Size(180, 25);
            this.insertBookNameInput.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "书籍位置：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "书籍类型：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "书籍名：";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage3.Controls.Add(this.dataGridViewForAdminSearchBorrow);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.borrowRecordBookNameInput);
            this.tabPage3.Controls.Add(this.borrowRecordStudentUsernameInput);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(885, 593);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "书籍借阅情况";
            // 
            // dataGridViewForAdminSearchBorrow
            // 
            this.dataGridViewForAdminSearchBorrow.AllowUserToAddRows = false;
            this.dataGridViewForAdminSearchBorrow.AllowUserToOrderColumns = true;
            this.dataGridViewForAdminSearchBorrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForAdminSearchBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForAdminSearchBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admin_search_borrow_record_id,
            this.admin_search_borrow_book_name,
            this.admin_search_borrow_student_username,
            this.admin_search_borrow_time1});
            this.dataGridViewForAdminSearchBorrow.Location = new System.Drawing.Point(3, 102);
            this.dataGridViewForAdminSearchBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewForAdminSearchBorrow.Name = "dataGridViewForAdminSearchBorrow";
            this.dataGridViewForAdminSearchBorrow.ReadOnly = true;
            this.dataGridViewForAdminSearchBorrow.RowTemplate.Height = 27;
            this.dataGridViewForAdminSearchBorrow.Size = new System.Drawing.Size(880, 486);
            this.dataGridViewForAdminSearchBorrow.TabIndex = 18;
            // 
            // admin_search_borrow_record_id
            // 
            this.admin_search_borrow_record_id.HeaderText = "借阅记录id";
            this.admin_search_borrow_record_id.Name = "admin_search_borrow_record_id";
            this.admin_search_borrow_record_id.ReadOnly = true;
            // 
            // admin_search_borrow_book_name
            // 
            this.admin_search_borrow_book_name.HeaderText = "书名";
            this.admin_search_borrow_book_name.Name = "admin_search_borrow_book_name";
            this.admin_search_borrow_book_name.ReadOnly = true;
            // 
            // admin_search_borrow_student_username
            // 
            this.admin_search_borrow_student_username.HeaderText = "借书者账号";
            this.admin_search_borrow_student_username.Name = "admin_search_borrow_student_username";
            this.admin_search_borrow_student_username.ReadOnly = true;
            // 
            // admin_search_borrow_time1
            // 
            this.admin_search_borrow_time1.HeaderText = "书籍借阅时间";
            this.admin_search_borrow_time1.Name = "admin_search_borrow_time1";
            this.admin_search_borrow_time1.ReadOnly = true;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(736, 28);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 38);
            this.button6.TabIndex = 6;
            this.button6.Text = "查询";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(53, 39);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 15);
            this.label24.TabIndex = 5;
            this.label24.Text = "书名：";
            // 
            // borrowRecordBookNameInput
            // 
            this.borrowRecordBookNameInput.Location = new System.Drawing.Point(112, 34);
            this.borrowRecordBookNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowRecordBookNameInput.Name = "borrowRecordBookNameInput";
            this.borrowRecordBookNameInput.Size = new System.Drawing.Size(204, 25);
            this.borrowRecordBookNameInput.TabIndex = 4;
            // 
            // borrowRecordStudentUsernameInput
            // 
            this.borrowRecordStudentUsernameInput.Location = new System.Drawing.Point(461, 34);
            this.borrowRecordStudentUsernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowRecordStudentUsernameInput.Name = "borrowRecordStudentUsernameInput";
            this.borrowRecordStudentUsernameInput.Size = new System.Drawing.Size(204, 25);
            this.borrowRecordStudentUsernameInput.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(373, 39);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 15);
            this.label23.TabIndex = 1;
            this.label23.Text = "学生账号：";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.studentPasswardInput);
            this.tabPage4.Controls.Add(this.studentIdInput);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(885, 593);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "修改学生密码";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 182);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "修改密码";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // studentPasswardInput
            // 
            this.studentPasswardInput.Location = new System.Drawing.Point(141, 101);
            this.studentPasswardInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentPasswardInput.Name = "studentPasswardInput";
            this.studentPasswardInput.PasswordChar = '*';
            this.studentPasswardInput.Size = new System.Drawing.Size(187, 25);
            this.studentPasswardInput.TabIndex = 3;
            // 
            // studentIdInput
            // 
            this.studentIdInput.Location = new System.Drawing.Point(141, 48);
            this.studentIdInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentIdInput.Name = "studentIdInput";
            this.studentIdInput.Size = new System.Drawing.Size(187, 25);
            this.studentIdInput.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "学生密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "学生账号：";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage5.Controls.Add(this.newAdminPasswardInput);
            this.tabPage5.Controls.Add(this.oldAdminPasswardInput);
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(885, 593);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "修改管理员密码";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // newAdminPasswardInput
            // 
            this.newAdminPasswardInput.Location = new System.Drawing.Point(132, 115);
            this.newAdminPasswardInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newAdminPasswardInput.Name = "newAdminPasswardInput";
            this.newAdminPasswardInput.PasswordChar = '*';
            this.newAdminPasswardInput.Size = new System.Drawing.Size(200, 25);
            this.newAdminPasswardInput.TabIndex = 5;
            // 
            // oldAdminPasswardInput
            // 
            this.oldAdminPasswardInput.Location = new System.Drawing.Point(132, 62);
            this.oldAdminPasswardInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oldAdminPasswardInput.Name = "oldAdminPasswardInput";
            this.oldAdminPasswardInput.PasswordChar = '*';
            this.oldAdminPasswardInput.Size = new System.Drawing.Size(200, 25);
            this.oldAdminPasswardInput.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(132, 186);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "修改密码";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "新密码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "原密码：";
            // 
            // adminUsername
            // 
            this.adminUsername.AutoSize = true;
            this.adminUsername.Location = new System.Drawing.Point(780, 22);
            this.adminUsername.Name = "adminUsername";
            this.adminUsername.Size = new System.Drawing.Size(63, 15);
            this.adminUsername.TabIndex = 7;
            this.adminUsername.Text = "label14";
            // 
            // menuForAdmin
            // 
            this.menuForAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuForAdmin.Name = "menuForAdmin";
            this.menuForAdmin.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bookTypeInput
            // 
            this.bookTypeInput.FormattingEnabled = true;
            this.bookTypeInput.Location = new System.Drawing.Point(451, 7);
            this.bookTypeInput.Name = "bookTypeInput";
            this.bookTypeInput.Size = new System.Drawing.Size(185, 23);
            this.bookTypeInput.TabIndex = 28;
            // 
            // insertBookTypeInput
            // 
            this.insertBookTypeInput.FormattingEnabled = true;
            this.insertBookTypeInput.Location = new System.Drawing.Point(140, 109);
            this.insertBookTypeInput.Name = "insertBookTypeInput";
            this.insertBookTypeInput.Size = new System.Drawing.Size(180, 23);
            this.insertBookTypeInput.TabIndex = 27;
            // 
            // updateBookTypeInput
            // 
            this.updateBookTypeInput.FormattingEnabled = true;
            this.updateBookTypeInput.Location = new System.Drawing.Point(548, 144);
            this.updateBookTypeInput.Name = "updateBookTypeInput";
            this.updateBookTypeInput.Size = new System.Drawing.Size(159, 23);
            this.updateBookTypeInput.TabIndex = 28;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 688);
            this.Controls.Add(this.adminUsername);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdministratorForm";
            this.Text = "管理员界面";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForAdminSearchBook)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForAdminSearchBorrow)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
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
        private System.Windows.Forms.TextBox insertBookLocationInput;
        private System.Windows.Forms.TextBox insertBookNameInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label adminUsername;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox updateBookNumberInput;
        private System.Windows.Forms.TextBox updateBookLocationInput;
        private System.Windows.Forms.TextBox updateBookAuthorInput;
        private System.Windows.Forms.TextBox updateBookNameInput;
        private System.Windows.Forms.TextBox updateBookIdIput;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox insertBookAuthorInput;
        private System.Windows.Forms.TextBox insertBookNumberInput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox bookLocationInput;
        private System.Windows.Forms.TextBox bookAuthorInput;
        private System.Windows.Forms.TextBox bookNameInput;
        private System.Windows.Forms.TextBox bookIdInput;
        private DataGridView dataGridViewForAdminSearchBook;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private ContextMenuStrip menuForAdmin;

        private DataGridViewTextBoxColumn admin_search_borrow_record_id;
        private DataGridViewTextBoxColumn admin_search_borrow_book_name;
        private DataGridViewTextBoxColumn admin_search_borrow_student_username;
        private DataGridViewTextBoxColumn admin_search_borrow_time1;
        private Button button3;
        private TextBox studentPasswardInput;
        private TextBox studentIdInput;
        private Label label6;
        private Label label3;
        private TextBox newAdminPasswardInput;
        private TextBox oldAdminPasswardInput;
        private Button button4;
        private Label label9;
        private Label label7;
        private DataGridView dataGridViewForAdminSearchBorrow;
        private Button button6;
        private Label label24;
        private TextBox borrowRecordBookNameInput;
        private TextBox borrowRecordStudentUsernameInput;
        private Label label23;
        private DataGridViewTextBoxColumn admin_search_book_id;
        private DataGridViewTextBoxColumn admin_search_book_name;
        private DataGridViewTextBoxColumn admin_search_book_author;
        private DataGridViewTextBoxColumn admin_search_book_type;
        private DataGridViewTextBoxColumn admin_search_book_location;
        private DataGridViewTextBoxColumn admin_search_book_borrow_number;
        private DataGridViewTextBoxColumn admin_search_book_left_number;
        private Button button7;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox bookTypeInput;
        private ComboBox updateBookTypeInput;
        private ComboBox insertBookTypeInput;
    }
}