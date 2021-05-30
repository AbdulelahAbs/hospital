using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        Form3 f = new Form3();
        Form2 f1 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (f== null)
            {
                f = new Form3();
                f.Show();

            }
            else
            {
                f.Show();
                f.Focus();

            }

           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           
           

            if (f1 == null)
            {
                f1 = new Form2();
                f1.Show();
            }
            else
            {
                f1.Show();
                f1.Focus();

            }


        }
    }
}
