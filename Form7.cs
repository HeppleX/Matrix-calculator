using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 大作业
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[10];
            a[1] = Convert.ToInt32(textBox1.Text);
            a[2] = Convert.ToInt32(textBox7.Text);
            a[3] = Convert.ToInt32(textBox5.Text);
            a[4] = Convert.ToInt32(textBox4.Text);      
            int[] b = new int[10];
            b[1] = Convert.ToInt32(textBox8.Text);
            b[2] = Convert.ToInt32(textBox2.Text);
            b[3] = Convert.ToInt32(textBox3.Text);
            b[4] = Convert.ToInt32(textBox6.Text);
            Form3 form3 = new Form3(a,b,22);
            form3.ShowDialog();
        }
    }
}
