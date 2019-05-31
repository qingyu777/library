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
    public partial class studentForm : Form
    {
        public studentForm()
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
            dataGridView1.Rows.Clear();

            SqlConnect c = new SqlConnect();
            Encoding unicode = Encoding.Unicode;
            String sql = "SELECT * from book where book_name like '%" + bookNameInput.Text + "%' and book_type like '%" + bookTypeInput.Text + "%' and book_author like '%" + bookAuthorInput.Text + "%'";
            Console.WriteLine(sql);
            MySqlCommand cmd = new MySqlCommand(sql, c.myCon);
            Book[] bookResult = c.GetBookArraySerchResult(cmd); //c.ExcuteOrder(sql, c.myCon)
            if (bookResult.Length > 0)
            {
                foreach (Book book in bookResult)
                {
                    String[] bookinfo = { book.Book_name, book.Book_type, book.Book_author, book.Book_location, book.Book_number.ToString() };
                    dataGridView1.Rows.Add(bookinfo);
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
    }
}
