using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Bitmap[] Resource ={
            Properties .Resources .小狗1 ,
            Properties .Resources .小狗2 ,
            Properties .Resources .小狗3,
           Properties .Resources .小狗4 ,
            Properties .Resources .小狗5 ,


        };

       
        private Point mouseOffset;
        private bool isMourseDown;

       

        public Form1()
        {
            InitializeComponent();

            BackColor = Color.Blue ;
            TransparencyKey = Color.Blue ;

            System .Timers .Timer timer = new System .Timers.Timer();
            timer.Enabled = true;
            timer.Interval = 3000;
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer1_do);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer2_do);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer3_do);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer4_do);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer5_do);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer6_do);


            pictureBox1.MouseUp += Form1_MouseUp;
            pictureBox1 .MouseMove +=Form1_MouseMove;
            pictureBox1.MouseDoubleClick += Form1_MouseDoubleClick;
            pictureBox1.MouseDown += Form1_MouseDown;   
           }

      
        

        private void Form1_MouseDown(object sender, MouseEventArgs mouseEventArgs )
        {
            if( mouseEventArgs.Button == MouseButtons.Left )
            {
                mouseOffset .X = mouseEventArgs.X;
                mouseOffset .Y = mouseEventArgs.Y;
                isMourseDown = true;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs eventArgs)
        {
            if (eventArgs.Button == MouseButtons.Left)
                isMourseDown = false;
        }
        private void Form1_MouseMove(object sender,MouseEventArgs eventArgs )
        {
            if (isMourseDown)
            {
                Point mouseweizhi = Control.MousePosition;
                mouseweizhi.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mouseweizhi;
            }

        }
        
        private void Form1_MouseDoubleClick(object sender,MouseEventArgs eventArgs )
        {
            Close();
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
         int random = new Random().Next(0, 5);
         pictureBox1 .Image = (Image)Properties.Resources.ResourceManager.GetObject($"小狗{random}");
            

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void timer1_do(object sender, System.Timers.ElapsedEventArgs elapsedEventArgs)
        {
            //此时的时间
            int nowhour = elapsedEventArgs.SignalTime.Hour;
            int nowminute = elapsedEventArgs.SignalTime.Minute;
            int nowsecond = elapsedEventArgs.SignalTime.Second;

            //设置时间
            int hour = 08;
            int minute = 00;
            int second = 00;

            if(hour==nowhour && minute==nowminute && second==nowsecond)
            {
                System.Windows.Forms.MessageBox.Show("该起床了懒狗");         
            }
        }

        private void timer2_do(object sender, System.Timers.ElapsedEventArgs elapsedEventArgs)
        {
            //此时的时间
            int nowhour = elapsedEventArgs.SignalTime.Hour;
            int nowminute = elapsedEventArgs.SignalTime.Minute;
            int nowsecond = elapsedEventArgs.SignalTime.Second;

            //设置时间
            int hour = 11;
            int minute = 00;
            int second = 00;

            if (hour == nowhour && minute == nowminute && second == nowsecond)
            {
                System.Windows.Forms.MessageBox.Show("该吃饭了馋鬼");
            }
        }


        private void timer5_do(object sender, System.Timers.ElapsedEventArgs elapsedEventArgs)
        {
            //此时的时间
            int nowhour = elapsedEventArgs.SignalTime.Hour;
            int nowminute = elapsedEventArgs.SignalTime.Minute;
            int nowsecond = elapsedEventArgs.SignalTime.Second;

            //设置时间
            int hour = 14;
            int minute = 30;
            int second = 00;

            if (hour == nowhour && minute == nowminute && second == nowsecond)
            {
                System.Windows.Forms.MessageBox.Show("兄弟们叫你玩ggd");
            }
        }




        private void timer3_do(object sender, System.Timers.ElapsedEventArgs elapsedEventArgs)
        {
            //此时的时间
            int nowhour = elapsedEventArgs.SignalTime.Hour;
            int nowminute = elapsedEventArgs.SignalTime.Minute;
            int nowsecond = elapsedEventArgs.SignalTime.Second;

            //设置时间
            int hour = 15;
            int minute = 00;
            int second = 00;

            if (hour == nowhour && minute == nowminute && second == nowsecond)
            {
                System.Windows.Forms.MessageBox.Show("该锻炼了细狗  记得多喝水 ");
            }
        }


        private void timer4_do(object sender, System.Timers.ElapsedEventArgs elapsedEventArgs)
        {
            //此时的时间
            int nowhour = elapsedEventArgs.SignalTime.Hour;
            int nowminute = elapsedEventArgs.SignalTime.Minute;
            int nowsecond = elapsedEventArgs.SignalTime.Second;

            //设置时间
            int hour = 22;
            int minute = 30;
            int second = 00;

            if (hour == nowhour && minute == nowminute && second == nowsecond)
            {
                System.Windows.Forms.MessageBox.Show("该睡觉了主人  千万别玩网易云");
            }
        }


        private void timer6_do(object sender, System.Timers.ElapsedEventArgs elapsedEventArgs)
        {
            //此时的时间
            int nowhour = elapsedEventArgs.SignalTime.Hour;
            int nowminute = elapsedEventArgs.SignalTime.Minute;
            int nowsecond = elapsedEventArgs.SignalTime.Second;

            //设置时间
            int hour = 17;
            int minute = 00;
            int second = 00;

            if (hour == nowhour && minute == nowminute && second == nowsecond)
            {
                System.Windows.Forms.MessageBox.Show("吃晚饭了");
            }
        }

        private void qQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process1 = null;
            process1 = new Process();
            process1.StartInfo.FileName = @"C:\Users\Public\Desktop\腾讯QQ.lnk";
            process1.Start();
        }

        private void wechatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process2 = null;
            process2 = new Process();
            process2.StartInfo.FileName = @"C:\Users\Public\Desktop\微信.lnk";
            process2.Start();

        }

        private void steamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process3 = null;
            process3 = new Process();
            process3.StartInfo.FileName = @"C:\Users\Public\Desktop\Steam.lnk";
            process3.Start();

        }

        private void 网易云音乐ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Process process4 = null;
            process4 = new Process();
            process4.StartInfo.FileName = @"C:\Users\Public\Desktop\网易云音乐.lnk";
            process4.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vs2022ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process5 = null;
            process5 = new Process();
            process5.StartInfo.FileName = @"C:\Users\Lenovo\Desktop\Microsoft Edge.lnk";
            process5.Start();
        }

        private void 小狗记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process6 = null;
            process6 = new Process();
            process6.StartInfo.FileName = @"小狗记事本2.exe";
            process6.Start();

        } 
        
        
        private void 小狗草稿本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process7 = null;
            process7 = new Process();
            process7.StartInfo.FileName = @"小狗草稿本.exe";
            process7.Start();

        }
        
       

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }



}
