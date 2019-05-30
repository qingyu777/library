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
