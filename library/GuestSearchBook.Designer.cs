using System.Windows.Forms;

namespace library
{
    partial class GuestSearchBook
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
            this.searchBotton = new System.Windows.Forms.Button();
            this.backBotton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookNameInput = new System.Windows.Forms.TextBox();
            this.bookTypeInput = new System.Windows.Forms.TextBox();
            this.bookAuthorInput = new System.Windows.Forms.TextBox();
            this.dataGridViewForGuast = new System.Windows.Forms.DataGridView();
            this.guest_search_book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guest_search_book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guest_search_book_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guest_search_book_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guest_search_book_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guest_search_book_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripForBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForGuast)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBotton
            // 
            this.searchBotton.Location = new System.Drawing.Point(550, 12);
            this.searchBotton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBotton.Name = "searchBotton";
            this.searchBotton.Size = new System.Drawing.Size(68, 29);
            this.searchBotton.TabIndex = 0;
            this.searchBotton.Text = "查询";
            this.searchBotton.UseVisualStyleBackColor = true;
            this.searchBotton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // backBotton
            // 
            this.backBotton.Location = new System.Drawing.Point(550, 44);
            this.backBotton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBotton.Name = "backBotton";
            this.backBotton.Size = new System.Drawing.Size(68, 30);
            this.backBotton.TabIndex = 1;
            this.backBotton.Text = "返回";
            this.backBotton.UseVisualStyleBackColor = true;
            this.backBotton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "书籍名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "书籍作者：";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "书籍类型：";
            // 
            // bookNameInput
            // 
            this.bookNameInput.Location = new System.Drawing.Point(94, 16);
            this.bookNameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookNameInput.Name = "bookNameInput";
            this.bookNameInput.Size = new System.Drawing.Size(153, 21);
            this.bookNameInput.TabIndex = 10;
            this.bookNameInput.TextChanged += new System.EventHandler(this.TextBox1222_TextChanged);
            // 
            // bookTypeInput
            // 
            this.bookTypeInput.Location = new System.Drawing.Point(360, 16);
            this.bookTypeInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookTypeInput.Name = "bookTypeInput";
            this.bookTypeInput.Size = new System.Drawing.Size(153, 21);
            this.bookTypeInput.TabIndex = 11;
            // 
            // bookAuthorInput
            // 
            this.bookAuthorInput.Location = new System.Drawing.Point(94, 49);
            this.bookAuthorInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookAuthorInput.Name = "bookAuthorInput";
            this.bookAuthorInput.Size = new System.Drawing.Size(153, 21);
            this.bookAuthorInput.TabIndex = 12;
            // 
            // dataGridViewForGuast
            // 
            this.dataGridViewForGuast.AllowUserToAddRows = false;
            this.dataGridViewForGuast.AllowUserToOrderColumns = true;
            this.dataGridViewForGuast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewForGuast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForGuast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guest_search_book_id,
            this.guest_search_book_name,
            this.guest_search_book_author,
            this.guest_search_book_type,
            this.guest_search_book_location,
            this.guest_search_book_number});
            this.dataGridViewForGuast.Location = new System.Drawing.Point(-1, 90);
            this.dataGridViewForGuast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewForGuast.Name = "dataGridViewForGuast";
            this.dataGridViewForGuast.ReadOnly = true;
            this.dataGridViewForGuast.RowTemplate.Height = 27;
            this.dataGridViewForGuast.Size = new System.Drawing.Size(712, 335);
            this.dataGridViewForGuast.TabIndex = 18;
            this.dataGridViewForGuast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // guest_search_book_id
            // 
            this.guest_search_book_id.HeaderText = "书籍编号";
            this.guest_search_book_id.Name = "guest_search_book_id";
            this.guest_search_book_id.ReadOnly = true;
            // 
            // guest_search_book_name
            // 
            this.guest_search_book_name.HeaderText = "书名";
            this.guest_search_book_name.Name = "guest_search_book_name";
            this.guest_search_book_name.ReadOnly = true;
            // 
            // guest_search_book_author
            // 
            this.guest_search_book_author.HeaderText = "书籍作者";
            this.guest_search_book_author.Name = "guest_search_book_author";
            this.guest_search_book_author.ReadOnly = true;
            // 
            // guest_search_book_type
            // 
            this.guest_search_book_type.HeaderText = "书籍类型";
            this.guest_search_book_type.Name = "guest_search_book_type";
            this.guest_search_book_type.ReadOnly = true;
            // 
            // guest_search_book_location
            // 
            this.guest_search_book_location.HeaderText = "书籍位置";
            this.guest_search_book_location.Name = "guest_search_book_location";
            this.guest_search_book_location.ReadOnly = true;
            // 
            // guest_search_book_number
            // 
            this.guest_search_book_number.HeaderText = "剩余可借数量";
            this.guest_search_book_number.Name = "guest_search_book_number";
            this.guest_search_book_number.ReadOnly = true;
            // 
            // contextMenuStripForBooks
            // 
            this.contextMenuStripForBooks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForBooks.Name = "contextMenuStripForBooks";
            this.contextMenuStripForBooks.Size = new System.Drawing.Size(61, 4);
            // 
            // GuestSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(710, 423);
            this.Controls.Add(this.dataGridViewForGuast);
            this.Controls.Add(this.bookAuthorInput);
            this.Controls.Add(this.bookTypeInput);
            this.Controls.Add(this.bookNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backBotton);
            this.Controls.Add(this.searchBotton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GuestSearchBook";
            this.Text = "查找书籍";
            this.Load += new System.EventHandler(this.Form1_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForGuast)).EndInit();
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
        private DataGridView dataGridViewForGuast;
        private ContextMenuStrip contextMenuStripForBooks;
        private DataGridViewTextBoxColumn guest_search_book_id;
        private DataGridViewTextBoxColumn guest_search_book_name;
        private DataGridViewTextBoxColumn guest_search_book_author;
        private DataGridViewTextBoxColumn guest_search_book_type;
        private DataGridViewTextBoxColumn guest_search_book_location;
        private DataGridViewTextBoxColumn guest_search_book_number;
    }
}