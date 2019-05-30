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

namespace library
{
    public partial class Form1_1 : Form
    {
        private Form1 anotherForm1;
        public Form1_1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            anotherForm1 = new Form1();
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
            //sqlconnect c = new sqlconnect();
            //richTextBox1.Text = c.GetSerchResult(c.ExcuteOrder("select book_name FROM book where book_type = '" + textBox6.Text + "'", c.myCon));
            //c.CloseMySqlConnection();

            //String[] mm = c.GetArraySerchResult(c.ExcuteOrder("select book_name FROM book where book_type = '" + textBox6.Text + "'", c.myCon), i);

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();

            col1.Name = "book_name";
            col1.HeaderText = "书名";
            col2.Name = "book_author";
            col2.HeaderText = "书籍作者";
            col3.Name = "book_type";
            col3.HeaderText = "书籍类型";
            col4.Name = "book_location";
            col4.HeaderText = "书籍位置";
            col5.Name = "book_status";
            col5.HeaderText = "书籍是否被借阅";
            dataGridView1.Columns.Add(col1);
            dataGridView1.Columns.Add(col2);
            dataGridView1.Columns.Add(col3);
            dataGridView1.Columns.Add(col4);
            dataGridView1.Columns.Add(col5);
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            //string[] row = { "12", "123", "1234","12345"};
            //dataGridView1.Rows.Add(row);
            String sql = "select * from book";
            sqlconnect c = new sqlconnect();
            if(textBox1.Text != null)
            {
                sql = "select * from book where book_name like '%" + textBox1.Text + "%'";
            }
            Book[] bookResult = c.GetBookArraySerchResult(c.ExcuteOrder(sql, c.myCon));
            foreach (Book book in bookResult)
            {
                String[] bookinfo = { book.Book_name, book.Book_type, book.Book_author, book.Book_location, book.Book_number.ToString() };
                dataGridView1.Rows.Add(bookinfo);
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

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        //在右键点击时，将当前行选中
        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.RowIndex >= 0)
            {
                if (!dataGridView1.Rows[e.RowIndex].Selected)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }
                contextMenuStripForBooks.Show(MousePosition.X, MousePosition.Y);
            }
        }

    }
}
