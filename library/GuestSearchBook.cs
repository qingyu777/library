using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using MySql.Data.MySqlClient;

namespace library
{
    public partial class GuestSearchBook : Form
    {
        private Main anotherForm1;
        public GuestSearchBook()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            anotherForm1 = new Main();
            this.Hide();
            anotherForm1.ShowDialog();
            Application.ExitThread();
        }

        private void Form1_1_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnect c = new SqlConnect();
            //richTextBox1.Text = c.GetSerchResult(c.ExcuteOrder("select book_name FROM book where book_type = '" + textBox6.Text + "'", c.myCon));
            //c.CloseMySqlConnection();

            //String[] mm = c.GetArraySerchResult(c.ExcuteOrder("select book_name FROM book where book_type = '" + textBox6.Text + "'", c.myCon), i);


            //string[] row = { "12", "123", "1234","12345"};
            //dataGridView_search.Rows.Add(row);
            //
            dataGridViewForGuast.Rows.Clear();

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
                    dataGridViewForGuast.Rows.Add(bookinfo);
                }
            }
            else
            {
                MessageBox.Show("查询结果为空");
            }

            
            c.CloseMySqlConnection();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ContextMenuStripForBooks_Opening(object sender, CancelEventArgs e)
        {

        }

        //在右键点击时，将当前行选中
        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.RowIndex >= 0)
            {
                if (!dataGridViewForGuast.Rows[e.RowIndex].Selected)
                {
                    dataGridViewForGuast.ClearSelection();
                    dataGridViewForGuast.Rows[e.RowIndex].Selected = true;
                }
                contextMenuStripForBooks.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void TextBox1222_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
