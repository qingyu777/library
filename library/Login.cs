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
    public partial class Login : Form
    {
        AdministratorForm anotherForm4;
        StudentForm anotherForm5;
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usernameInput.Text = usernameInput.Text.Replace("'", " ").Trim();   //防止sql注入
            passwardInput.Text = passwardInput.Text.Replace("'", " ").Trim();
            SqlConnect c = new SqlConnect();

            //"select * FROM admin where admin_username = '" + textBox1.Text + "'and admin_passward ='' or 'jjj'='jjj'"

            if (c.IsSerchResult(c.ExcuteOrder("select * FROM admin where admin_username = '" + usernameInput.Text + "'and admin_passward ='" + passwardInput.Text + "'", c.myCon))>0)
            {
                anotherForm4 = new AdministratorForm(usernameInput.Text);
                this.Hide();
                anotherForm4.ShowDialog();
                Application.ExitThread();
            }
            else if (c.IsSerchResult(c.ExcuteOrder("select * FROM admin where admin_username = '" + usernameInput.Text + "'", c.myCon))>0)
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
            usernameInput.Text = usernameInput.Text.Replace("'", " ").Trim();   //防止sql注入
            passwardInput.Text = passwardInput.Text.Replace("'", " ").Trim();
            SqlConnect c = new SqlConnect();

            //"select * FROM admin where admin_username = '" + textBox1.Text + "'and admin_passward ='' or 'jjj'='jjj'"

            if (c.IsSerchResult(c.ExcuteOrder("select * FROM student where student_username = '" + usernameInput.Text + "'and student_passward ='" + passwardInput.Text + "'", c.myCon)) > 0)
            {
                anotherForm5 = new StudentForm(usernameInput.Text);
                this.Hide();
                anotherForm5.ShowDialog();
                Application.ExitThread();
            }
            else if (c.IsSerchResult(c.ExcuteOrder("select * FROM student where student_username = '" + usernameInput.Text + "'", c.myCon)) > 0)
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
