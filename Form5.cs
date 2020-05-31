using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 大作业
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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
            int[] b = new int[10];
            b[1] = Convert.ToInt32(textBox18.Text);
            b[2] = Convert.ToInt32(textBox12.Text);
            b[3] = Convert.ToInt32(textBox13.Text);
            b[4] = Convert.ToInt32(textBox14.Text);
            b[5] = Convert.ToInt32(textBox15.Text);
            b[6] = Convert.ToInt32(textBox16.Text);
            b[7] = Convert.ToInt32(textBox17.Text);
            b[8] = Convert.ToInt32(textBox10.Text);
            b[9] = Convert.ToInt32(textBox11.Text);
            Form3 form3 = new Form3(a,b,23);
            form3.ShowDialog();
        }
    }
}
