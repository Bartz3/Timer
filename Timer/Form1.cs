using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {

        Time time = new Time();

        private bool isWorking=false;
        private bool isStopped=false;
        private static string startSoundPath= @"C:\Users\Bartek\source\repos\Timer\Timer\bin\Debug\start.wav";
        private static string endSoundPath= @"C:\Users\Bartek\source\repos\Timer\Timer\bin\Debug\end.wav";
        public Form1()
        {
            InitializeComponent();

        }
        public void setTimmer()
        {
            time.minutes = (int)minNumeric.Value;
            time.seconds = (int)secNumeric.Value;
            time.breakTime = (int)breakNumeric.Value;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(!isWorking)
            {
                setTimmer();
                countdownTimer.Start();
                isWorking = true;
                hideElements(true);
            }
            
        }
        public void hideElements(bool hide)
        {
            hide = !hide;
          minLabel.Visible = hide;
          secondLabel.Visible = hide;
          breakLabel.Visible = hide;

          minNumeric.Visible = hide;
          secNumeric.Visible = hide;
          breakNumeric.Visible = hide;
          startButton.Visible = hide;

        }
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            showTimerLabel.ForeColor = Color.Black;
            showTimerLabel.Text = time.ToString();
            time.seconds--;
            if (time.seconds == -1 && time.minutes > 0)
            {
                time.minutes--;
                time.seconds = 59;
            }
            if (time.minutes == 0 && time.seconds == 1)
            {
                SoundPlayer endSound = new SoundPlayer(endSoundPath);
                endSound.Play();
            }
            if (time.minutes == 0 && time.seconds == -1)
            {
                countdownTimer.Stop();
                breakTimer.Start();
            }
        }

        private void breakTimer_Tick(object sender, EventArgs e)
        {

            showTimerLabel.ForeColor = Color.Green;
            showTimerLabel.Text = time.breakString(time.breakTime);
            time.breakTime--;

            if (time.breakTime <= 0)
            {
                breakTimer.Stop();
                setTimmer();

                countdownTimer.Start();

                SoundPlayer startSound = new SoundPlayer(startSoundPath);
                startSound.Play();
            }
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            int  min = time.minutes, sec = time.seconds, breakT = time.breakTime;
            if (isWorking)
            {
                //showTimerLabel.Text = time.ToString();
                isWorking = false;
                countdownTimer.Stop();
                             
                stopButton.Text = "Wznów";
            }
            else
            {
                isWorking = true;
                time.minutes = min; time.seconds = sec; time.breakTime = breakT;
                countdownTimer.Start();
                
                stopButton.Text = "Stop";

            }

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            hideElements(false);
            isWorking = false;
            countdownTimer.Stop();
            breakTimer.Stop();
            setTimmer();
            showTimerLabel.Text = time.ToString();
        }

        private void minNumeric_ValueChanged(object sender, EventArgs e)
        {
            time.seconds = (int)secNumeric.Value;
        }

        private void secNumeric_ValueChanged(object sender, EventArgs e)
        {
            time.minutes = (int)minNumeric.Value;
        }

        private void breakNumeric_ValueChanged(object sender, EventArgs e)
        {
            time.breakTime = (int)breakNumeric.Value;
        }


    }
}
