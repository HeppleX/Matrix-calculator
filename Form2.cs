using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 大作业
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked && radioButton3.Checked)
            {
                Form8 form8 = new Form8();
                form8.ShowDialog();
            }
            else if (radioButton1.Checked && radioButton4.Checked)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
            }
            else if (radioButton2.Checked && radioButton3.Checked)
            {
                Form7 form7 = new Form7();
                form7.ShowDialog();
            }
            else if (radioButton2.Checked && radioButton4.Checked)
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
