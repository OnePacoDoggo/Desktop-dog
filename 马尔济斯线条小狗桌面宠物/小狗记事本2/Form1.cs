using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小狗记事本2
{
    public partial class 小狗记事本 : Form
    {
        public 小狗记事本()
        {
            InitializeComponent();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是小狗专用记事本 有问题联系主人qq2695496809");
        }
        private void label2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.BlueViolet;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color .Pink ;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Orange ;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1 .ShowDialog () == DialogResult.OK)
            {
                richTextBox1 .Font = fontDialog1.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionFont = new Font("幼圆",richTextBox1 .SelectionFont .Size );//字体不变
        }

        private void button2_Click(object sender, EventArgs e)
        {

            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionFont = new Font("隶书", richTextBox1.SelectionFont.Size);//字体不变
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionFont = new Font("宋体", richTextBox1.SelectionFont.Size);//字体不变
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1 .ShowDialog()== DialogResult.OK)
            {
                richTextBox1 .ForeColor = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(DateTime.Now.ToString("yyyyMMddHHmmss") + ".rtf");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
