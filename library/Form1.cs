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
    public partial class Form1 : Form
    {
        private Form2 anotherForm2;
        private Form3 anotherForm3;
        private Form1_1 anotherForm1_1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            anotherForm2 = new Form2();
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
            anotherForm1_1 = new Form1_1();
            this.Hide();
            anotherForm1_1.ShowDialog();
            Application.ExitThread();
        }
    }
}
