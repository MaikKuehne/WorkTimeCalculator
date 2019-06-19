using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeCalculator
{
    public partial class Calculator : UserControl
    {
        Options options;
        int hours = 0;
        int minutes = 0;
        DateTime startTime = new DateTime();
        TimeSpan timeToWork = new TimeSpan(0,0,0);
        TimeSpan pauseTime = new TimeSpan(0,0,0);
        DateTime endTime = new DateTime();
        Timer timer = new Timer();
        Timer timer_ReloadUI = new Timer();
       
        public Calculator(Options _options)
        {
            InitializeComponent();
            options = _options;
            LoadConfig();

            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 125;
            timer.Start();

            timer_ReloadUI.Tick += new EventHandler(TimerReloadUI_Tick);
            timer_ReloadUI.Interval = 1000;
            timer_ReloadUI.Start();
        }

        private void Timer_Tick(object Sender, EventArgs e)
        {
            CalculateTimeLeftToWork();
        }

        private void TimerReloadUI_Tick(object Sender, EventArgs e)
        {             
            int timeDone = (int)(DateTime.Now - startTime).TotalMinutes;
            if (startTime > DateTime.Now)
            {
                timeDone = Math.Abs((int)(startTime.TimeOfDay - DateTime.Now.TimeOfDay).TotalMinutes - 1440);
            }
            if (timeDone <= CircleProgressBar.MaxValue && timeDone >= 0)
                CircleProgressBar.Value = timeDone;
        }

        private void LoadConfig()
        {            
            options.week.SetDayData(DateTime.Now.DayOfWeek);

            timeToWork = new TimeSpan(options.week.workHour, options.week.workMinutes, 0);
            pauseTime = new TimeSpan(options.week.pauseHour, options.week.pauseMinute, 0);

            hours = options.week.hours;
            minutes = options.week.minutes;                        

            CircleProgressBar.MaxValue = (int)(timeToWork + pauseTime).TotalMinutes;
                        
            SetStartTime();
            OutputHours();
            OutputMinutes();

            lWorkTime.Text = string.Format("{0}:{1}", GetNumberString(timeToWork.Hours), GetNumberString(timeToWork.Minutes));
            lPausetime.Text = string.Format("{0}:{1}", GetNumberString(pauseTime.Hours), GetNumberString(pauseTime.Minutes));
        }

        private void CalculateTimeLeftToWork()
        {            
            if (startTime > DateTime.Now)
                startTime = startTime.AddDays(-1);

            TimeSpan timeLeft = timeToWork + pauseTime - (DateTime.Now - startTime);            
            
            StringBuilder sb = new StringBuilder();

            if (timeLeft.TotalMinutes > 0)
            {                
                lTimeOPutputHeader.Text = "Arbeitszeit";

                sb.Append($"{GetNumberString(timeLeft.Hours)}");
                sb.Append(" : ");
                sb.Append($"{GetNumberString(timeLeft.Minutes)}");
                sb.Append(" : ");
                sb.Append($"{GetNumberString(timeLeft.Seconds)}");
                lTimeOutput.Text = sb.ToString();
            }
            else
            {
                CircleProgressBar.Value = CircleProgressBar.MaxValue;
                lTimeOPutputHeader.Text = "Überstunden";
                
                sb.Append($"{GetNumberString(Math.Abs(timeLeft.Hours))}");
                sb.Append(" : ");
                sb.Append($"{GetNumberString(Math.Abs(timeLeft.Minutes))}");
                sb.Append(" : ");
                sb.Append($"{GetNumberString(Math.Abs(timeLeft.Seconds))}");
                lTimeOutput.Text = sb.ToString();
            }
        }

        private void OutputHours()
        {
            int one = hours % 10;
            int ten = hours - one;
            lTenHours.Text = ten.ToString();
            lHours.Text = one.ToString();
        }

        private void OutputMinutes()
        {
            int one = minutes % 10;
            int ten = minutes - one;
            lTenMinutes.Text = ten.ToString();
            lMinutes.Text = one.ToString();
        }

        private string GetNumberString(int number)
        {
            string output = "";
            if (number < 10)
                output = "0";
            output += number;  

            return output;
        }

        private void CheckHours()
        {
            if (hours == 0)
            {
            }
            else if (hours > 0)
            {
                if (hours == 24)
                    hours = 0;

                if (hours > 23)                
                    hours -= 24;                
            }
            else            
                hours += 24;            
        }

        private void CheckMinutes()
        {
            if (minutes == 0)
            {
            }
            else if (minutes > 0)
            {
                if (minutes == 60)
                    minutes = 0;

                if (minutes > 59)                
                    minutes -= 60;                
            }
            else            
                minutes += 60;            
        }

        private void SetStartTime()
        {
            startTime = DateTime.Parse(string.Format("{0}:{1}",hours, minutes));
            CalculateEndtime();
            Timer_Tick(null, null);
            TimerReloadUI_Tick(null, null);
        }

        private void CalculateEndtime()
        {
            endTime = startTime + timeToWork + pauseTime;
            lEndTime.Text = string.Format("{0}:{1}", GetNumberString(endTime.Hour), GetNumberString(endTime.Minute));
        }

        #region Arrow Buttons
        private void BtnHoursUp_MouseDown(object sender, MouseEventArgs e)
        {
            hours++;
            CheckHours();
            OutputHours();
            SetStartTime();
        }

        private void BtnTenHoursUp_MouseDown(object sender, MouseEventArgs e)
        {      
            hours += 10;
            CheckHours();
            OutputHours();
            SetStartTime();
        }

        private void BtnhoursDown_MouseDown(object sender, MouseEventArgs e)
        {
            hours--;
            CheckHours();
            OutputHours();
            SetStartTime();
        }

        private void BtnTenHoursDown_MouseDown(object sender, MouseEventArgs e)
        {
            hours -= 10;
            CheckHours();
            OutputHours();
            SetStartTime();
        }

        private void BtnTenMinutesUp_MouseDown(object sender, MouseEventArgs e)
        {
            minutes += 10;
            CheckMinutes();
            OutputMinutes();
            SetStartTime();
        }

        private void BtnMinutesUp_MouseDown(object sender, MouseEventArgs e)
        {
            minutes++;
            CheckMinutes();
            OutputMinutes();
            SetStartTime();
        }

        private void BtnTenMinutesDown_MouseDown(object sender, MouseEventArgs e)
        {
            minutes -= 10;
            CheckMinutes();
            OutputMinutes();
            SetStartTime();
        }

        private void BtnMinutesDown_MouseDown(object sender, MouseEventArgs e)
        {
            minutes--;
            CheckMinutes();
            OutputMinutes();
            SetStartTime();
        }
        #endregion
    }
}
