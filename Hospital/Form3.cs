using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form3 : Form
    {
        Form4 f3 =new Form4();

        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3=new Form4();
                f3.Show();

            }
            else
            {
                f3.Show();
                f3.Focus();
            }
        }
    }
}
