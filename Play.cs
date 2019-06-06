using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomAndJerry
{
    public partial class Play : Form
    {
        private static readonly int TIME = 60 * 10;

        private int timeElapsed;

        public Play()
        {
            InitializeComponent();
            timeElapsed = 0;
            updateTime();
            timer1.Start();       
        }


        private void updateTime()
        {
            int left = TIME - timeElapsed;
            int min = left / 60;
            int sec = left % 60;
            lblTime.Text = string.Format("{0:00}:{1:00}", min, sec);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            if (timeElapsed == TIME)
            {
                timer1.Stop();
            }
            updateTime();
        }
    }
}
