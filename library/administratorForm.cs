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
    public partial class AdministratorForm : Form
    {
        String admin_username;
        public AdministratorForm(String u)
        {
            admin_username = u;
            InitializeComponent();
            adminUsername.Text = u;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            SqlConnect c = new SqlConnect();
            String sql;
            if(bookIdInput.Text.Length == 0)
            {
                sql = "SELECT *,book_number-(select count(*) from borrowRecord where borrowRecord.book_id = book.book_id and status_borrow = 'jcwh') as leftNumber from book where book_name like '%" + bookNameInput.Text+"%' AND book_type like '%"+bookTypeInput.Text+"%' AND book_author like '%"+bookAuthorInput.Text+"%' AND book_location like '%"+bookLocationInput.Text+"%'";
            }
            else
                sql = "SELECT *,book_number-(select count(*) from borrowRecord where borrowRecord.book_id = book.book_id and status_borrow = 'jcwh') as leftNumber from book where book_id = '" + bookIdInput.Text+ "' AND book_name like '%"+bookNameInput.Text+"%' AND book_type like '%"+bookTypeInput.Text+"%' AND book_author like '%"+bookAuthorInput.Text+"%' AND book_location like '%"+bookLocationInput.Text+"%'";
            Console.WriteLine(sql);
            MySqlCommand cmd = new MySqlCommand(sql, c.myCon);
            Book[] bookResult = c.GetBookArraySerchResult(cmd); //c.ExcuteOrder(sql, c.myCon)
            String book_borrow_number;
            if (bookResult.Length > 0)
            {
                foreach (Book book in bookResult)
                {
                    book_borrow_number = c.GetSerchResult(c.ExcuteOrder("SELECT COUNT(*) FROM borrowRecord where book_id = "+ book.Book_id, c.myCon));
                    String[] bookinfo = { book.Book_id.ToString(), book.Book_name, book.Book_type, book.Book_author, book.Book_location, book.Book_number.ToString(), book.Book_left_number.ToString() };
                    dataGridView1.Rows.Add(bookinfo);
                }
            }
            else
            {
                MessageBox.Show("查询结果为空");
            }


            c.CloseMySqlConnection();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
