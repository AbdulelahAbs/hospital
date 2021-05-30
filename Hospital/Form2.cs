using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    
    public partial class Form2 : Form
    {
        Form3 f2 = new Form3();

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void llll(object sender, DragEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (f2 == null)
            {
                f2 = new Form3();
                f2.Show();

            }
            else
            {
                f2.Show();
                f2.Focus();

            }
        }
    }
}
