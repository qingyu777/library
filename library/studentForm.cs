using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridViewUserSearchBookResult.Rows.Clear();

            SqlConnect c = new SqlConnect();
            String sql = "SELECT * from book where book_name like '%" + bookNameInput.Text + "%' and book_type like '%" + bookTypeInput.Text + "%' and book_author like '%" + bookAuthorInput.Text + "%'";
            Console.WriteLine(sql);
            MySqlCommand cmd = new MySqlCommand(sql, c.myCon);
            Book[] bookResult = c.GetBookArraySerchResult(cmd); //c.ExcuteOrder(sql, c.myCon)
            if (bookResult.Length > 0)
            {
                foreach (Book book in bookResult)
                {
                    String[] bookinfo = { book.Book_id.ToString(), book.Book_name, book.Book_type, book.Book_author, book.Book_location, book.Book_number.ToString() };
                    dataGridViewUserSearchBookResult.Rows.Add(bookinfo);
                }
            }
            else
            {
                MessageBox.Show("查询结果为空");
            }


            c.CloseMySqlConnection();
        }

        private void BookAutherInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuForUserSearchedBooks_Opening(object sender, CancelEventArgs e)
        {

        }

        //在右键点击时，将当前行选中
        private void DataGridViewUserSearchBookResult_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.RowIndex >= 0)
            {
                if (!dataGridViewUserSearchBookResult.Rows[e.RowIndex].Selected)
                {
                    dataGridViewUserSearchBookResult.ClearSelection();
                    dataGridViewUserSearchBookResult.Rows[e.RowIndex].Selected = true;
                }
                menuForUserSearchedBooks.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void 借阅书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
