using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace StopWatch
{
    public partial class Form1 : Form
    {
        int centiseconds, seconds, minutes;
        bool IsActive;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                IsActive = false;    
        }
        private void button2_Click(object sender, EventArgs e)
        {
            IsActive = true;  
        }
        private void button3_Click(object sender, EventArgs e)
        {
            IsActive = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsActive)
            {
                centiseconds++;
                if (centiseconds >= 100)
                {
                    seconds++;
                    centiseconds = 0;
                    if (seconds >= 60)
                    {
                        minutes++;
                        seconds = 0;
                    }
                }
             
            }
            DrawTime();
        }
        private void DrawTime()
        {
            label6.Text = String.Format("{0:00}",centiseconds);
            label5.Text = String.Format("{0:00}", seconds);
            label2.Text = String.Format("{0:00}", minutes);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IsActive = false;
            centiseconds = 0;
            seconds = 0;
            minutes = 0;
        }
    }
}
