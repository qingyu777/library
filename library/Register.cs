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
    public partial class Form3 : Form
    {
        private Login anotherForm;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sqlconnect c = new sqlconnect();
            if(userNameInput.Text.Length == 0 || passwardInput.Text.Length == 0)
            {
                MessageBox.Show("请输入完整的注册信息！");
            }
            else if(c.isSerchResult(c.ExcuteOrder("select * from student where student_username = '" + userNameInput.Text + "'", c.myCon)) > 0)
            {
                MessageBox.Show("该账号已被注册");
                userNameInput.Clear();
                passwardInput.Clear();
            }
            else
            {
                MySqlCommand myCom = c.ExcuteOrder("INSERT INTO student VALUES (null,'" + userNameInput.Text + "','" + passwardInput.Text + "')", c.myCon);
                if(c.GetDelInsertUpdateResult(myCom) > 0)
                    MessageBox.Show("注册成功！");
                else
                    MessageBox.Show("请勿输入\"'\"等特殊字符！！！");
            }
            anotherForm = new Login();
            this.Hide();
            anotherForm.ShowDialog();
            Application.ExitThread();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
