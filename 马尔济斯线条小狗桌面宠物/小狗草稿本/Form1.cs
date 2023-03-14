using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小狗草稿本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);

        }

        int x;
        int y;
        Bitmap draft;
        Color linecolor;
        bool beginPaint=false;
        bool beginMove= false;

       
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
         if(beginPaint ==true)
            {
                if(e.Button == MouseButtons.Left)
                {
                    beginMove = true;
                    x= e.X;
                    y= e.Y;
                }
            }
           
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove == true)
            {
                Graphics g = Graphics.FromImage(draft);

                Pen line = new Pen(linecolor, 2);
                g.DrawLine(line, x, y, e.X, e.Y);
                pictureBox1.Image = draft;
                g.Dispose();
                x = e.X;
                y = e.Y;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button ==MouseButtons.Left)
            {
                beginMove = false;
                x = 0;
                y = 0;
            }
           


        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
              linecolor  = colorDialog1.Color;
            }
        }

       

        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎使用小狗草稿本 有问题请联系主人QQ2695496809");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "开始") 
            {
                beginPaint = true;
                button1.Text = "结束";
                
                draft =new Bitmap (pictureBox1 .Width , pictureBox1 .Height);
                Graphics g = Graphics.FromImage(draft);

                pictureBox1.Image = draft;
            }
            
            else
            {
                beginPaint = false;
                button1.Text = "开始";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(beginPaint ==false )
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                   draft.Save (DateTime .Now .ToString ("yyyyMMddHHmmss") + ".jpg");
                }
                else
                {
                    MessageBox.Show("无法保存");
                    return;
                }
            }
        }
    }
}

