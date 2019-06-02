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
        int row;
        public StudentForm(int user_id, string yhm)
        {
            
            InitializeComponent();
            this.id = user_id;
            this.username = yhm;
            studentUsername.Text = yhm;
            label4.Text = user_id.ToString();
            SqlConnect c = new SqlConnect();
            String[] bookType = c.GetArraySerchResult(c.ExcuteOrder("select distinct book_type from book", c.myCon));
            int len = bookType.Length;
            for (int i = 0; i < len; i++)
            {
                bookTypeInput.Items.Add(bookType[i]);
            }
            c.CloseMySqlConnection();
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
                    row = e.RowIndex;
                }
                menuForUserSearchedBooks.Show(MousePosition.X, MousePosition.Y);
            }
        }
        //在右键点击时，将当前行选中
        private void DataGridViewUserBorrowBookResult_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.RowIndex >= 0)
            {
                if (!dataGridViewBookBorrowed.Rows[e.RowIndex].Selected)
                {
                    dataGridViewBookBorrowed.ClearSelection();
                    dataGridViewBookBorrowed.Rows[e.RowIndex].Selected = true;
                    row = e.RowIndex;
                }
                menuForUserSearchedBooks.Show(MousePosition.X, MousePosition.Y);
            }
        }
        private void 借阅书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnect c = new SqlConnect();
            String sql;
            String searchBookId = dataGridViewUserSearchBookResult.Rows[row].Cells[0].Value.ToString();
            if (c.IsSerchResult(c.ExcuteOrder("select * from borrowRecord where book_id = '"+ searchBookId + "' AND student_id = '"+id+"' AND status_borrow = 'jcwh'", c.myCon)) > 0)
                MessageBox.Show("你已借阅该书籍，无法重复借阅");
            else
            {
                sql = "INSERT INTO borrowRecord (book_id,student_id,status_borrow) VALUES ('" + searchBookId + "','" + id + "','jcwh')";
                MySqlCommand m = c.ExcuteOrder("INSERT INTO borrowRecord (book_id,student_id,status_borrow) VALUES ('" + searchBookId + "','" + id + "','jcwh')", c.myCon);
                c.GetDelInsertUpdateResult(m);
                Console.WriteLine(sql);
                MessageBox.Show("借阅成功！");
            }
            Console.WriteLine(dataGridViewUserSearchBookResult.Rows[row].Cells[0].Value.ToString());
            c.CloseMySqlConnection();
        }

        private void StudentUsername_Click(object sender, EventArgs e)
        {

        }

        private void 查询_Click(object sender, EventArgs e)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnect c = new SqlConnect();
            if(c.IsSerchResult(c.ExcuteOrder("select * from student where student_id = "+this.id+" and student_passward = '" + oldPasswardInput .Text+ "'", c.myCon)) > 0)
            {
                MySqlCommand result = c.ExcuteOrder("UPDATE student set student_passward = '"+newPasswardInput.Text+"' where student_id = "+ this.id , c.myCon);
                if(c.GetDelInsertUpdateResult(result) > 0)
                {
                    MessageBox.Show("修改密码成功！");
                }
                else
                    MessageBox.Show("请输入正确的密码格式！");
            }
            else
                MessageBox.Show("密码输入错误！");
        }

        private void 归还书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnect c = new SqlConnect();
            String borrowBookId = dataGridViewBookBorrowed.Rows[row].Cells[0].Value.ToString();
            String sql = "UPDATE borrowRecord set status_borrow = 'yihuan' where id = '"+ borrowBookId + "' AND student_id = '"+id+"'";
            int a = c.GetDelInsertUpdateResult(c.ExcuteOrder(sql, c.myCon));
            MessageBox.Show("归还成功"+a);
            Console.WriteLine(borrowBookId);
            Console.WriteLine(sql);
            c.CloseMySqlConnection();
        }
    }
}
