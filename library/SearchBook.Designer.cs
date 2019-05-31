using System.Windows.Forms;

namespace library
{
    partial class SearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBook));
            this.searchBotton = new System.Windows.Forms.Button();
            this.backBotton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookNameInput = new System.Windows.Forms.TextBox();
            this.bookTypeInput = new System.Windows.Forms.TextBox();
            this.bookAuthorInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripForBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBotton
            // 
            this.searchBotton.Location = new System.Drawing.Point(757, 16);
            this.searchBotton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBotton.Name = "searchBotton";
            this.searchBotton.Size = new System.Drawing.Size(91, 36);
            this.searchBotton.TabIndex = 0;
            this.searchBotton.Text = "查询";
            this.searchBotton.UseVisualStyleBackColor = true;
            this.searchBotton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // backBotton
            // 
            this.backBotton.Location = new System.Drawing.Point(757, 58);
            this.backBotton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBotton.Name = "backBotton";
            this.backBotton.Size = new System.Drawing.Size(91, 38);
            this.backBotton.TabIndex = 1;
            this.backBotton.Text = "返回";
            this.backBotton.UseVisualStyleBackColor = true;
            this.backBotton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "书籍名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "书籍作者：";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "书籍类型：";
            // 
            // bookNameInput
            // 
            this.bookNameInput.Location = new System.Drawing.Point(149, 18);
            this.bookNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookNameInput.Name = "bookNameInput";
            this.bookNameInput.Size = new System.Drawing.Size(203, 25);
            this.bookNameInput.TabIndex = 10;
            this.bookNameInput.TextChanged += new System.EventHandler(this.TextBox1222_TextChanged);
            // 
            // bookTypeInput
            // 
            this.bookTypeInput.Location = new System.Drawing.Point(504, 18);
            this.bookTypeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookTypeInput.Name = "bookTypeInput";
            this.bookTypeInput.Size = new System.Drawing.Size(203, 25);
            this.bookTypeInput.TabIndex = 11;
            // 
            // bookAuthorInput
            // 
            this.bookAuthorInput.Location = new System.Drawing.Point(149, 55);
            this.bookAuthorInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookAuthorInput.Name = "bookAuthorInput";
            this.bookAuthorInput.Size = new System.Drawing.Size(203, 25);
            this.bookAuthorInput.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_name,
            this.book_author,
            this.book_type,
            this.book_location,
            this.book_number});
            this.dataGridView1.Location = new System.Drawing.Point(55, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(745, 419);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // book_name
            // 
            this.book_name.HeaderText = "书名";
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
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
            this.book_number.HeaderText = "书籍数量";
            this.book_number.Name = "book_number";
            this.book_number.ReadOnly = true;
            // 
            // contextMenuStripForBooks
            // 
            this.contextMenuStripForBooks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForBooks.Name = "contextMenuStripForBooks";
            this.contextMenuStripForBooks.Size = new System.Drawing.Size(61, 4);
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 552);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bookAuthorInput);
            this.Controls.Add(this.bookTypeInput);
            this.Controls.Add(this.bookNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backBotton);
            this.Controls.Add(this.searchBotton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchBook";
            this.Text = "查找书籍";
            this.Load += new System.EventHandler(this.Form1_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBotton;
        private System.Windows.Forms.Button backBotton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookNameInput;
        private System.Windows.Forms.TextBox bookTypeInput;
        private System.Windows.Forms.TextBox bookAuthorInput;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStripForBooks;
        private DataGridViewTextBoxColumn book_name;
        private DataGridViewTextBoxColumn book_author;
        private DataGridViewTextBoxColumn book_type;
        private DataGridViewTextBoxColumn book_location;
        private DataGridViewTextBoxColumn book_number;
    }
}