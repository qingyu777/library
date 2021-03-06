﻿using MySql.Data.MySqlClient;
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
            InitDropListList();//初始化书籍类别下拉选项
        }

        public void InitDropListList()
        {
            SqlConnect c = new SqlConnect();
            String[] bookType = c.GetArraySerchResult(c.ExcuteOrder("select distinct book_type from book", c.myCon));
            int len = bookType.Length;
            bookTypeInput.Items.Clear();
            insertBookTypeInput.Items.Clear();
            updateBookTypeInput.Items.Clear();
            for (int i = 0; i < len; i++)
            {
                bookTypeInput.Items.Add(bookType[i]);
                insertBookTypeInput.Items.Add(bookType[i]);
                updateBookTypeInput.Items.Add(bookType[i]);
            }
            c.CloseMySqlConnection();
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
            dataGridViewForAdminSearchBook.Rows.Clear();

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
                    dataGridViewForAdminSearchBook.Rows.Add(bookinfo);
                }
            }
            else
            {
                MessageBox.Show("查询结果为空");
            }


            c.CloseMySqlConnection();
        }
        //在右键点击时，将当前行选中
        private void DataGridViewUserSearchBookResult_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.RowIndex >= 0)
            {
                if (!dataGridViewForAdminSearchBook.Rows[e.RowIndex].Selected)
                {
                    dataGridViewForAdminSearchBook.ClearSelection();
                    dataGridViewForAdminSearchBook.Rows[e.RowIndex].Selected = true;
                }
                menuForAdmin.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            SqlConnect c = new SqlConnect();
            if(insertBookNameInput.Text.Length == 0 || insertBookTypeInput.Text.Length == 0 || insertBookAuthorInput.Text.Length == 0|| insertBookLocationInput.Text.Length == 0||insertBookNumberInput.Text.Length ==0)
                MessageBox.Show("请输入完整书籍信息！");
            else
            {
                String sql = "INSERT INTO book VALUES(NULL,'"+ insertBookNameInput.Text+"','"+insertBookTypeInput.Text+"','"+insertBookAuthorInput.Text+"','"+insertBookLocationInput.Text+"','"+insertBookNumberInput.Text+"')";
                MySqlCommand cmd = c.ExcuteOrder(sql, c.myCon);
                if(c.GetDelInsertUpdateResult(cmd) > 0)
                    MessageBox.Show("成功插入书籍！");
                else
                    MessageBox.Show("请输入正确的书籍信息格式！");
            }
            c.CloseMySqlConnection();
            InitDropListList(); //可能修改了书籍类别
        }
        
        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SqlConnect c = new SqlConnect();
            if(c.IsSerchResult(c.ExcuteOrder("select * from book where book_id = '"+updateBookIdIput.Text+"'",c.myCon))>0)
            {
                Console.WriteLine("select * from book where book_id = '" + updateBookIdIput.Text + "'");
                if (updateBookNameInput.Text.Length == 0 || updateBookTypeInput.Text.Length == 0 || updateBookAuthorInput.Text.Length == 0 || updateBookLocationInput.Text.Length == 0 || updateBookNumberInput.Text.Length == 0)
                    MessageBox.Show("请输入完整书籍信息！");
                else
                {
                    String sql = "UPDATE book set book_name = '"+ updateBookNameInput.Text + "',book_type ='"+ updateBookTypeInput.Text + "', book_author = '"+ updateBookAuthorInput.Text + "', book_number = "+ updateBookNumberInput.Text + ", book_location = '"+ updateBookLocationInput.Text + "' where book_id ="+updateBookIdIput.Text;
                    MySqlCommand cmd = c.ExcuteOrder(sql, c.myCon);
                    if (c.GetDelInsertUpdateResult(cmd) > 0)
                        MessageBox.Show("成功更改书籍信息！");
                    else
                        MessageBox.Show("请输入正确的书籍信息格式并输入完整书籍信息！");
                }
                
            }
            else
                MessageBox.Show("不存在该书籍id！");
            c.CloseMySqlConnection();
            InitDropListList(); //可能修改了书籍类别
        }

        private void 删除书籍信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            SqlConnect c = new SqlConnect();
            if(c.IsSerchResult(c.ExcuteOrder("select * from student where student_username = '"+studentIdInput.Text+"'",c.myCon))>0)
            {
                if(studentPasswardInput.Text.Length > 0)
                {
                    if (c.GetDelInsertUpdateResult(c.ExcuteOrder("update student set student_passward = '" + studentPasswardInput.Text + "' where student_username = '" + studentIdInput.Text + "'", c.myCon)) > 0)
                        MessageBox.Show("密码修改成功");
                    else
                        MessageBox.Show("请输入正确的密码格式");
                }
                else
                    MessageBox.Show("请输入密码！");
            }
            else
                MessageBox.Show("不存在该学生id");
            c.CloseMySqlConnection();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            SqlConnect c = new SqlConnect();
            if (c.IsSerchResult(c.ExcuteOrder("select * from admin where admin_username = '"+ admin_username + "' and admin_passward = '"+ oldAdminPasswardInput.Text + "'", c.myCon)) > 0)
            {
                if (newAdminPasswardInput.Text.Length > 0)
                {
                    if (c.GetDelInsertUpdateResult(c.ExcuteOrder("update admin set admin_passward = '" + newAdminPasswardInput.Text + "' where admin_username = '" + admin_username + "'", c.myCon)) > 0)
                        MessageBox.Show("密码修改成功");
                    else
                        MessageBox.Show("请输入正确的密码格式！");
                }
                else
                    MessageBox.Show("请输入密码！");
            }
            else
                MessageBox.Show("原密码输入错误！");
            c.CloseMySqlConnection();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            dataGridViewForAdminSearchBorrow.Rows.Clear();
            SqlConnect c = new SqlConnect();
            String sql = "";
            if(borrowRecordStudentUsernameInput.Text.Length > 0)
                sql = "SELECT id,(SELECT book_name from book where book.book_id = borrowRecord.book_id),(SELECT student_username from student where student.student_id = borrowRecord.student_id),time_borrow from borrowRecord where borrowRecord.student_id IN (SELECT student_id from student WHERE student_username = '" + borrowRecordStudentUsernameInput.Text + "') and borrowRecord.book_id IN (SELECT book_id from book WHERE book_name like '%" + borrowRecordBookNameInput.Text + "%')  and borrowRecord.status_borrow = 'jcwh'";
            else
                sql = "SELECT id,(SELECT book_name from book where book.book_id = borrowRecord.book_id),(SELECT student_username from student where student.student_id = borrowRecord.student_id),time_borrow from borrowRecord where borrowRecord.book_id IN (SELECT book_id from book WHERE book_name like '%" + borrowRecordBookNameInput.Text + "%')  and borrowRecord.status_borrow = 'jcwh'";
            Console.WriteLine(sql);
            MySqlCommand cmd = new MySqlCommand(sql, c.myCon);
            borrowRecord[] borrowResult = c.GetBookBorrowRecordArraySerchResult2(cmd); //c.ExcuteOrder(sql, c.myCon)
            if (borrowResult.Length > 0)
            {
                foreach (borrowRecord aBorrowRecord in borrowResult)
                {
                    String[] borrowRecordArray = { aBorrowRecord.Borrow_record_id.ToString(), aBorrowRecord.Book_name, aBorrowRecord.Student_name, aBorrowRecord.Book_borrow_time };
                    dataGridViewForAdminSearchBorrow.Rows.Add(borrowRecordArray);
                }
            }
            else
            {
                MessageBox.Show("查询结果为空");
            }
            c.CloseMySqlConnection();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SqlConnect c = new SqlConnect();
            String sql = "select *,0 from book where book_id = " + updateBookIdIput.Text;
            MySqlCommand cmd = new MySqlCommand(sql, c.myCon);
            Book[] bookResult = c.GetBookArraySerchResult(cmd); //c.ExcuteOrder(sql, c.myCon)
            if (bookResult.Length > 0)
            {
                updateBookNameInput.Text = bookResult[0].Book_name;
                updateBookTypeInput.Text = bookResult[0].Book_type;
                updateBookAuthorInput.Text = bookResult[0].Book_author;
                updateBookLocationInput.Text = bookResult[0].Book_location;
                updateBookNumberInput.Text = bookResult[0].Book_number.ToString();
            }
            else
                MessageBox.Show("没有这本书，不存在此id");
            c.CloseMySqlConnection();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
