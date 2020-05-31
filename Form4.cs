using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 大作业
{
    public partial class Form4 : Form
    {
        private int[] a;
        int c;
        public Form4(int[] a, int c)
        {
            this.a = a;
            this.c = c;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Boolean b1, b2;
            b1 = b2 = false;
            if (checkBox1.Checked)
                b1 = true;
            if (checkBox2.Checked)
                b2 = true;
            Form9 form9 = new Form9(a, b1, b2,c);
            form9.ShowDialog();

        }
    }
}
