using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 大作业
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[10];
            a[1] = Convert.ToInt32(textBox1.Text);
            a[2] = Convert.ToInt32(textBox7.Text);
            a[3] = Convert.ToInt32(textBox6.Text);
            a[4] = Convert.ToInt32(textBox5.Text);
            a[5] = Convert.ToInt32(textBox4.Text);
            a[6] = Convert.ToInt32(textBox3.Text);
            a[7] = Convert.ToInt32(textBox2.Text);
            a[8] = Convert.ToInt32(textBox9.Text);
            a[9] = Convert.ToInt32(textBox8.Text);
            Form4 form4 = new Form4(a,13);
            form4.ShowDialog();
        }
    }
}
