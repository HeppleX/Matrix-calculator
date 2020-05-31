using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 大作业
{
    public partial class Form9 : Form
    {
        private int[] a;
        private int[] b;
        private Boolean b1;
        private Boolean b2;
        private Boolean b3;
        private Boolean b4;
        private Boolean b5;
        int c;
        public Form9(int[] a, int[] b, Boolean b1, Boolean b2, Boolean b3, Boolean b4,
            Boolean b5, int c)
        {
            this.a = a;
            this.b = b;
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.b4 = b4;
            this.b5 = b5;
            this.c = c;
            InitializeComponent();
        }
        public Form9(int[] a,  Boolean b1, Boolean b2,int c)
        {
            this.a = a;
            this.b1 = b1;
            this.b2 = b2;
            this.c = c;
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (c == 23)
            {
                if (b1 == true)
                {
                    int r1 = a[1] * a[5] * a[9] + a[2] * a[6] * a[7] + a[3] * a[4] * a[8] - a[3] * a[5] * a[7] - a[1] * a[6] * a[8] - a[2] * a[4] * a[9];
                    int r2 = b[1] * b[5] * b[9] + b[2] * b[6] * b[7] + b[3] * b[4] * b[8] - b[3] * b[5] * b[7] - b[1] * b[6] * b[8] - b[2] * b[4] * b[9];
                    richTextBox1.Text = "第一个行列式的值为" + Environment.NewLine + Convert.ToString(r1) + Environment.NewLine
                    + "第二个行列式的值为" + Environment.NewLine + Convert.ToString(r2) + Environment.NewLine;
                }
                if (b2 == true)
                {
                    richTextBox1.AppendText("第一个矩阵的逆矩阵为" + Environment.NewLine + Convert.ToString(a[1]) + " " + Convert.ToString(a[4]) + " " + Convert.ToString(a[7])
                        + Environment.NewLine + Convert.ToString(a[2]) + " " + Convert.ToString(a[5]) + " " + Convert.ToString(a[8])
                        + Environment.NewLine + Convert.ToString(a[3]) + " " + Convert.ToString(a[6]) + " " + Convert.ToString(a[9]) + Environment.NewLine
                        + "第二个矩阵的逆矩阵为" + Environment.NewLine + Convert.ToString(b[1]) + " " + Convert.ToString(b[4]) + " " + Convert.ToString(b[7])
                        + Environment.NewLine + Convert.ToString(b[2]) + " " + Convert.ToString(b[5]) + " " + Convert.ToString(b[8])
                        + Environment.NewLine + Convert.ToString(b[3]) + " " + Convert.ToString(b[6]) + " " + Convert.ToString(b[9]) + Environment.NewLine);
                }
                if (b3 == true)
                {
                    richTextBox1.AppendText("两个矩阵的和为" + Environment.NewLine + Convert.ToString(a[1] + b[1]) + " " + Convert.ToString(a[2] + b[2]) + " " + Convert.ToString(a[3] + b[3])
                        + Environment.NewLine + Convert.ToString(a[4] + b[4]) + " " + Convert.ToString(a[5] + b[5]) + " " + Convert.ToString(a[6] + b[6])
                        + Environment.NewLine + Convert.ToString(a[7] + b[7]) + " " + Convert.ToString(a[8] + b[8]) + " " + Convert.ToString(a[9] + b[9]) + Environment.NewLine);
                }
                if (b4 == true)
                {
                    richTextBox1.AppendText("两个矩阵的差为" + Environment.NewLine + Convert.ToString(a[1] - b[1]) + " " + Convert.ToString(a[2] - b[2]) + " " + Convert.ToString(a[3] - b[3])
                        + Environment.NewLine + Convert.ToString(a[4] - b[4]) + " " + Convert.ToString(a[5] - b[5]) + " " + Convert.ToString(a[6] - b[6])
                        + Environment.NewLine + Convert.ToString(a[7] - b[7]) + " " + Convert.ToString(a[8] - b[8]) + " " + Convert.ToString(a[9] - b[9]) + Environment.NewLine);
                }
                if (b5 == true)
                {
                    richTextBox1.AppendText("两个矩阵的积为" + Environment.NewLine + Convert.ToString(a[1] * b[1] + a[2] * b[4] + a[3] * b[7]) + " " + Convert.ToString(a[1] * b[2] + a[2] * b[5] + a[3] * b[8]) + " " + Convert.ToString(a[1] * b[3] + a[2] * b[6] + a[3] * b[9])
                        + Environment.NewLine + Convert.ToString(a[4] * b[1] + a[5] * b[4] + a[6] * b[7]) + " " + Convert.ToString(a[4] * b[2] + a[5] * b[5] + a[6] * b[8]) + " " + Convert.ToString(a[4] * b[3] + a[5] * b[6] + a[6] * b[9])
                        + Environment.NewLine + Convert.ToString(a[7] * b[1] + a[8] * b[4] + a[9] * b[7]) + " " + Convert.ToString(a[7] * b[2] + a[8] * b[5] + a[9] * b[8]) + " " + Convert.ToString(a[7] * b[3] + a[8] * b[6] + a[9] * b[9]));
                }
            }
            if (c == 22)
            {
                if (b1 == true)
                {
                    int r1 = a[1] * a[4] - a[2] * a[3];
                    int r2 = b[1] * b[4] - b[2] * b[3];
                    richTextBox1.Text = "第一个行列式的值为" + Environment.NewLine + Convert.ToString(r1) + Environment.NewLine
                    + "第二个行列式的值为" + Environment.NewLine + Convert.ToString(r2) + Environment.NewLine;
                }
                if (b2 == true)
                {
                    richTextBox1.AppendText("第一个矩阵的逆矩阵为" + Environment.NewLine + Convert.ToString(a[1]) + " " + Convert.ToString(a[3])
                        + Environment.NewLine + Convert.ToString(a[2]) + " " + Convert.ToString(a[4]) + Environment.NewLine
                        + "第二个矩阵的逆矩阵为" + Environment.NewLine + Convert.ToString(b[1]) + " " + Convert.ToString(b[3])
                        + Environment.NewLine + Convert.ToString(b[2]) + " " + Convert.ToString(b[4]) + Environment.NewLine);
                }
                if (b3 == true)
                {
                    richTextBox1.AppendText("两个矩阵的和为" + Environment.NewLine + Convert.ToString(a[1] + b[1]) + " " + Convert.ToString(a[2] + b[2])
                        + Environment.NewLine + Convert.ToString(a[3] + b[3]) + " " + Convert.ToString(a[4] + b[4]) + Environment.NewLine);
                }
                if (b4 == true)
                {
                    richTextBox1.AppendText("两个矩阵的差为" + Environment.NewLine + Convert.ToString(a[1] - b[1]) + " " + Convert.ToString(a[2] - b[2])
                        + Environment.NewLine + Convert.ToString(a[3] - b[3]) + " " + Convert.ToString(a[4] - b[4]) + Environment.NewLine);
                }
                if (b5 == true)
                {
                    richTextBox1.AppendText("两个矩阵的积为" + Environment.NewLine + Convert.ToString(a[1] * b[1] + a[2] * b[3]) + " " + Convert.ToString(a[1] * b[2] + a[2] * b[4])
                        + Environment.NewLine + Convert.ToString(a[3] * b[1] + a[4] * b[3]) + " " + Convert.ToString(a[3] * b[2] + a[4] * b[4]));
                }
            }
            if (c == 13)
            {
                if (b1 == true)
                {
                    int r1 = a[1] * a[5] * a[9] + a[2] * a[6] * a[7] + a[3] * a[4] * a[8] - a[3] * a[5] * a[7] - a[1] * a[6] * a[8] - a[2] * a[4] * a[9];
                    richTextBox1.Text = "第一个行列式的值为" + Environment.NewLine + Convert.ToString(r1) + Environment.NewLine;
                }
                if (b2 == true)
                {
                    richTextBox1.AppendText("第一个矩阵的逆矩阵为" + Environment.NewLine + Convert.ToString(a[1]) + " " + Convert.ToString(a[4]) + " " + Convert.ToString(a[7])
                        + Environment.NewLine + Convert.ToString(a[2]) + " " + Convert.ToString(a[5]) + " " + Convert.ToString(a[8])
                        + Environment.NewLine + Convert.ToString(a[3]) + " " + Convert.ToString(a[6]) + " " + Convert.ToString(a[9]) + Environment.NewLine);
                }

            }
            if (c == 12)
            {
                if (b1 == true)
                {
                    int r1 = a[1] * a[4] - a[2] * a[3];
                    richTextBox1.Text = "第一个行列式的值为" + Environment.NewLine + Convert.ToString(r1) + Environment.NewLine;
                }
                if (b2 == true)
                {
                    richTextBox1.AppendText("第一个矩阵的逆矩阵为" + Environment.NewLine + Convert.ToString(a[1]) + " " + Convert.ToString(a[3])
                        + Environment.NewLine + Convert.ToString(a[2]) + " " + Convert.ToString(a[4]) + Environment.NewLine);
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void 页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            try
            {
                pageSetupDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "打印出错");
            }
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "打印出错");
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.BackColor = colorDialog1.Color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "大作业：矩阵计算器"+Environment.NewLine+
                                "制作人：席赫璞" + Environment.NewLine +
                                "完成时间：2019年12月26日 星期四" + Environment.NewLine +
                                "版本：Version 1.0.0";
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
