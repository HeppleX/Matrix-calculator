using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 大作业
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[10];
            a[1] = Convert.ToInt32(textBox1.Text);
            a[2] = Convert.ToInt32(textBox7.Text);
            a[3] = Convert.ToInt32(textBox5.Text);
            a[4] = Convert.ToInt32(textBox4.Text);
            Form4 form4 = new Form4(a, 12);
            form4.ShowDialog();
        }
    }
}
