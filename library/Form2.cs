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
    public partial class Form2 : Form
    {
        Form4 anotherForm4;
        Form5 anotherForm5;
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace("'", " ").Trim();   //防止sql注入
            textBox2.Text = textBox2.Text.Replace("'", " ").Trim();
            sqlconnect c = new sqlconnect();

            //"select * FROM admin where admin_username = '" + textBox1.Text + "'and admin_passward ='' or 'jjj'='jjj'"

            if (c.isSerchResult(c.ExcuteOrder("select * FROM admin where admin_username = '" + textBox1.Text + "'and admin_passward ='" + textBox2.Text + "'", c.myCon))>0)
            {
                anotherForm4 = new Form4();
                this.Hide();
                anotherForm4.ShowDialog();
                Application.ExitThread();
            }
            else if (c.isSerchResult(c.ExcuteOrder("select * FROM admin where admin_username = '" + textBox1.Text + "'", c.myCon))>0)
            {
                MessageBox.Show("密码错误");
            }
            else
            {
                MessageBox.Show("账号错误");
            }
            c.CloseMySqlConnection();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace("'", " ").Trim();   //防止sql注入
            textBox2.Text = textBox2.Text.Replace("'", " ").Trim();
            sqlconnect c = new sqlconnect();

            //"select * FROM admin where admin_username = '" + textBox1.Text + "'and admin_passward ='' or 'jjj'='jjj'"

            if (c.isSerchResult(c.ExcuteOrder("select * FROM student where student_username = '" + textBox1.Text + "'and student_passward ='" + textBox2.Text + "'", c.myCon)) > 0)
            {
                anotherForm5 = new Form5();
                this.Hide();
                anotherForm5.ShowDialog();
                Application.ExitThread();
            }
            else if (c.isSerchResult(c.ExcuteOrder("select * FROM student where student_username = '" + textBox1.Text + "'", c.myCon)) > 0)
            {
                MessageBox.Show("密码错误");
            }
            else
            {
                MessageBox.Show("账号错误");
            }
            c.CloseMySqlConnection();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
