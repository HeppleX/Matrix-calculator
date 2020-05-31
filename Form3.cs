using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 大作业
{
    public partial class Form3 : Form
    {
        private int[] a;
        private int[] b;
        int c;
        public Form3(int[] a,int[]b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Boolean b1, b2, b3, b4, b5;
            b1 = b2 = b3 = b4 = b5 = false;
            if (checkBox1.Checked)
                b1 = true;
            if (checkBox2.Checked)
                b2 = true;
            if (checkBox3.Checked)
                b3 = true;
            if (checkBox4.Checked)
                b4 = true;
            if (checkBox5.Checked)
                b5 = true;
            Form9 form9 = new Form9(a, b,b1,b2,b3,b4,b5,c);
            form9.ShowDialog();
        }
    }
}
