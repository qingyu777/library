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
        string username = "";
        int id ;
        public StudentForm(int user_id, string yhm)
        {
            
            InitializeComponent();
            this.id = user_id;
            this.username = yhm;
            studentUsername.Text = yhm;
            studentId.Text = id.ToString();
            
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
            String sql = "SELECT *,book_number-(select count(*) from borrowRecord where borrowRecord.book_id = book.book_id and status_borrow = 'jcwh') as leftNumber from book where book_name like '%" + bookNameInput.Text + "%' and book_type like '%" + bookTypeInput.Text + "%' and book_author like '%" + bookAuthorInput.Text + "%'";
            Console.WriteLine(sql);
            MySqlCommand cmd = new MySqlCommand(sql, c.myCon);
            Book[] bookResult = c.GetBookArraySerchResult(cmd); //c.ExcuteOrder(sql, c.myCon)
            if (bookResult.Length > 0)
            {
                foreach (Book book in bookResult)
                {
                    String[] bookinfo = { book.Book_id.ToString(), book.Book_name, book.Book_author, book.Book_type, book.Book_location, book.Book_left_number.ToString() };
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

        private void StudentUsername_Click(object sender, EventArgs e)
        {

        }

        private void 刷新_Click(object sender, EventArgs e)
        {
            dataGridViewBookBorrowed.Rows.Clear();

            SqlConnect c = new SqlConnect();
            String sql = "SELECT id,(SELECT book_name from book WHERE book.book_id = borrowRecord.book_id),time_borrow from borrowRecord WHERE borrowRecord.student_id = "+ this.id + " and status_borrow = 'jcwh' ";
            Console.WriteLine(sql);
            MySqlCommand cmd = new MySqlCommand(sql, c.myCon);
            borrowRecord[] borrowResult = c.GetBookBorrowRecordArraySerchResult(cmd); //c.ExcuteOrder(sql, c.myCon)
            if (borrowResult.Length > 0)
            {
                foreach (borrowRecord aBorrowRecord in borrowResult)
                {
                    String[] borrowRecordArray = {aBorrowRecord.Borrow_record_id.ToString(), aBorrowRecord.Book_name, aBorrowRecord.Book_borrow_time};
                    dataGridViewBookBorrowed.Rows.Add(borrowRecordArray);
                }
            }
            else
            {
                MessageBox.Show("查询结果为空");
            }
            c.CloseMySqlConnection();
        }
    }
}
