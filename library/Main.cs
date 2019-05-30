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
    public partial class Main : Form
    {
        private Login anotherForm2;
        private Form3 anotherForm3;
        private SearchBook anotherForm1_1;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            anotherForm2 = new Login();
            this.Hide();
            anotherForm2.ShowDialog();
            Application.ExitThread();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            anotherForm3 = new Form3();
            this.Hide();
            anotherForm3.ShowDialog();
            Application.ExitThread();
        }

        

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            anotherForm1_1 = new SearchBook();
            this.Hide();
            anotherForm1_1.ShowDialog();
            Application.ExitThread();
        }
    }
}
