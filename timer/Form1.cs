using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        int endTime;
        int nowTime;
        int endTime2;
        int endTime2;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int remaniningTime;
            nowTime++;

            remaniningTime = endTime - nowTime;

            textBox2.Text = remaniningTime.ToString();
            if (endTime == nowTime)
            {
                timer1.Stop();
                MessageBox.Show("時間になりました。");
            }
            else
            {
                //NO判定の処理
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out endTime))
            {
                endTime = 1;
            }//時間設定。
            nowTime = 0;//timerSTart!!
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int remaniningTime2;
            
        }
    }
}
