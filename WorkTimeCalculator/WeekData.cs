using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeCalculator
{
    public class WeekData
    {
        public int monWorkHour = 8;
        public int monWorkMinutes = 0;
        public int monPauseHour = 0;
        public int monPauseMinutes = 30;

        public int dieWorkHour = 8;
        public int dieWorkMinutes = 0;
        public int diePauseHour = 0;
        public int diePauseMinutes = 30;

        public int mitWorkHour = 8;
        public int mitWorkMinutes = 0;
        public int mitPauseHour = 0;
        public int mitPauseMinutes = 30;

        public int donWorkHour = 8;
        public int donWorkMinutes = 0;
        public int donPauseHour = 0;
        public int donPauseMinutes = 30;

        public int freWorkHour = 8;
        public int freWorkMinutes = 0;
        public int frePauseHour = 0;
        public int frePauseMinutes = 30;

        public int samWorkHour = 8;
        public int samWorkMinutes = 0;
        public int samPauseHour = 0;
        public int samPauseMinutes = 30;

        public int sonWorkHour = 8;
        public int sonWorkMinutes = 0;
        public int sonPauseHour = 0;
        public int sonPauseMinutes = 30;

        public int hours = 6;
        public int minutes = 0;

        public int workHour = 0;
        public int workMinutes = 0;
        public int pauseHour = 0;
        public int pauseMinute = 0;

        public WeekData()
        {

        }

        public WeekData(WeekData weekData)
        {
            monWorkHour = weekData.monWorkHour;
            monWorkMinutes = weekData.monWorkMinutes;
            monPauseHour = weekData.monPauseHour;
            monPauseMinutes = weekData.monPauseMinutes;

            dieWorkHour = weekData.dieWorkHour;
            dieWorkMinutes = weekData.dieWorkMinutes;
            diePauseHour = weekData.diePauseHour;
            diePauseMinutes = weekData.diePauseMinutes;

            mitWorkHour = weekData.mitWorkHour;
            mitWorkMinutes = weekData.mitWorkMinutes;
            mitPauseHour = weekData.mitPauseHour;
            mitPauseMinutes = weekData.mitPauseMinutes;

            donWorkHour = weekData.donWorkHour;
            donWorkMinutes = weekData.donWorkMinutes;
            donPauseHour = weekData.donPauseHour;
            donPauseMinutes = weekData.donPauseMinutes;

            freWorkHour = weekData.freWorkHour;
            freWorkMinutes = weekData.freWorkMinutes;
            frePauseHour = weekData.frePauseHour;
            frePauseMinutes = weekData.frePauseMinutes;

            samWorkHour = weekData.samWorkHour;
            samWorkMinutes = weekData.samWorkMinutes;
            samPauseHour = weekData.samPauseHour;
            samPauseMinutes = weekData.samPauseMinutes;

            sonWorkHour = weekData.sonWorkHour;
            sonWorkMinutes = weekData.sonWorkMinutes;
            sonPauseHour = weekData.sonPauseHour;
            sonPauseMinutes = weekData.sonPauseMinutes;

            hours = weekData.hours;
            minutes = weekData.minutes;
        }

        public void SetDayData(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday:
                    {
                        workHour = sonWorkHour;
                        workMinutes = sonWorkMinutes;
                        pauseHour = sonPauseHour;
                        pauseMinute = sonPauseMinutes;
                    }
                    break;
                case DayOfWeek.Monday:
                    {
                        workHour = monWorkHour;
                        workMinutes = monWorkMinutes;
                        pauseHour = monPauseHour;
                        pauseMinute = monPauseMinutes;
                    }
                    break;
                case DayOfWeek.Tuesday:
                    {
                        workHour = dieWorkHour;
                        workMinutes = dieWorkMinutes;
                        pauseHour = diePauseHour;
                        pauseMinute = diePauseMinutes;
                    }
                    break;
                case DayOfWeek.Wednesday:
                    {
                        workHour = mitWorkHour;
                        workMinutes = mitWorkMinutes;
                        pauseHour = mitPauseHour;
                        pauseMinute = mitPauseMinutes;
                    }
                    break;
                case DayOfWeek.Thursday:
                    {
                        workHour = donWorkHour;
                        workMinutes = donWorkMinutes;
                        pauseHour = donPauseHour;
                        pauseMinute = donPauseMinutes;
                    }
                    break;
                case DayOfWeek.Friday:
                    {
                        workHour = freWorkHour;
                        workMinutes = freWorkMinutes;
                        pauseHour = frePauseHour;
                        pauseMinute = frePauseMinutes;
                    }
                    break;
                case DayOfWeek.Saturday:
                    {
                        workHour = samWorkHour;
                        workMinutes = samWorkMinutes;
                        pauseHour = samPauseHour;
                        pauseMinute = samPauseMinutes;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
