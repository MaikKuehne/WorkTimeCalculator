using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace WorkTimeCalculator
{
    public partial class Options : UserControl
    {
        public WeekData week = new WeekData();
        WeekData weekLastSave = new WeekData();
        string saveFile = @".\Save.json";

        int hours = 6;
        int minutes = 0;

        Timer timer = new Timer();
        public Options()
        {
            InitializeComponent();
            timer.Interval = 1500;
            timer.Tick += new EventHandler(Timer_Tick);

            if (File.Exists(saveFile))
                LoadCfg();
            AddDataToUI();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SaveCfg();
        }        

        private bool ChangedWeekValue(WeekData week1, WeekData week2)
        {
            bool change = false;

            #region Check for a change
            if (week1.monWorkHour != week2.monWorkHour)
                change = true;
            else if (week1.monWorkMinutes != week2.monWorkMinutes)
                change = true;
            else if (week1.monPauseHour != week2.monPauseHour)
                change = true;
            else if (week1.monPauseMinutes != week2.monPauseMinutes)
                change = true;
            else if (week1.dieWorkHour != week2.dieWorkHour)
                change = true;
            else if (week1.dieWorkMinutes != week2.dieWorkMinutes)
                change = true;
            else if (week1.diePauseHour != week2.diePauseHour)
                change = true;
            else if (week1.diePauseMinutes != week2.diePauseMinutes)
                change = true;
            else if (week1.mitWorkHour != week2.mitWorkHour)
                change = true;
            else if (week1.mitWorkMinutes != week2.mitWorkMinutes)
                change = true;
            else if (week1.mitPauseHour != week2.mitPauseHour)
                change = true;
            else if (week1.mitPauseMinutes != week2.mitPauseMinutes)
                change = true;
            else if (week1.donWorkHour != week2.donWorkHour)
                change = true;
            else if (week1.donWorkMinutes != week2.donWorkMinutes)
                change = true;
            else if (week1.donPauseHour != week2.donPauseHour)
                change = true;
            else if (week1.donPauseMinutes != week2.donPauseMinutes)
                change = true;
            else if (week1.freWorkHour != week2.freWorkHour)
                change = true;
            else if (week1.freWorkMinutes != week2.freWorkMinutes)
                change = true;
            else if (week1.frePauseHour != week2.frePauseHour)
                change = true;
            else if (week1.frePauseMinutes != week2.frePauseMinutes)
                change = true;
            else if (week1.samWorkHour != week2.samWorkHour)
                change = true;
            else if (week1.samWorkMinutes != week2.samWorkMinutes)
                change = true;
            else if (week1.samPauseHour != week2.samPauseHour)
                change = true;
            else if (week1.samPauseMinutes != week2.samPauseMinutes)
                change = true;
            else if (week1.sonWorkHour != week2.sonWorkHour)
                change = true;
            else if (week1.sonWorkMinutes != week2.sonWorkMinutes)
                change = true;
            else if (week1.sonPauseHour != week2.sonPauseHour)
                change = true;
            else if (week1.sonPauseMinutes != week2.sonPauseMinutes)
                change = true;
            else if (week1.hours != week2.hours)
                change = true;
            else if (week1.minutes != week2.minutes)
                change = true;
            #endregion

            return change;
        }

        private void SaveCfg()
        {
            if (ChangedWeekValue(week, weekLastSave))
            {
                using (StreamWriter file = File.CreateText(saveFile))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, week);
                }
                weekLastSave = new WeekData(week);
            }
        }

        private void LoadCfg()
        {
            using (StreamReader file = File.OpenText(saveFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                WeekData weekLoaded = (WeekData)serializer.Deserialize(file, typeof(WeekData));
                if (ChangedWeekValue(weekLoaded, week))
                {
                    week = weekLoaded;
                    hours = weekLoaded.hours;
                    minutes = weekLoaded.minutes;                    
                }
            }
        }

        private void AddDataToUI()
        {
            #region AddDataToUI
            tbMonWorkHour.Text = GetNumberString(week.monWorkHour);
            tbMonWorkMinute.Text = GetNumberString(week.monWorkMinutes);
            tbMonPauseHour.Text = GetNumberString(week.monPauseHour);
            tbMonPauseMinute.Text = GetNumberString(week.monPauseMinutes);

            tbDieWorkHour.Text = GetNumberString(week.dieWorkHour);
            tbDieWorkMinute.Text = GetNumberString(week.dieWorkMinutes);
            tbDiePauseHour.Text = GetNumberString(week.diePauseHour);
            tbDiePauseMinute.Text = GetNumberString(week.diePauseMinutes);

            tbMitWorkHour.Text = GetNumberString(week.mitWorkHour);
            tbMitWorkMinute.Text = GetNumberString(week.mitWorkMinutes);
            tbMitPauseHour.Text = GetNumberString(week.mitPauseHour);
            tbMitPauseMinute.Text = GetNumberString(week.mitPauseMinutes);

            tbDonWorkHour.Text = GetNumberString(week.donWorkHour);
            tbDonWorkMinute.Text = GetNumberString(week.donWorkMinutes);
            tbDonPauseHour.Text = GetNumberString(week.donPauseHour);
            tbDonPauseMinute.Text = GetNumberString(week.donPauseMinutes);

            tbFreWorkHour.Text = GetNumberString(week.freWorkHour);
            tbFreWorkMinute.Text = GetNumberString(week.freWorkMinutes);
            tbFrePauseHour.Text = GetNumberString(week.frePauseHour);
            tbFrePauseMinute.Text = GetNumberString(week.frePauseMinutes);

            tbSamWorkHour.Text = GetNumberString(week.samWorkHour);
            tbSamWorkMinute.Text = GetNumberString(week.samWorkMinutes);
            tbSamPauseHour.Text = GetNumberString(week.samPauseHour);
            tbSamPauseMinute.Text = GetNumberString(week.samPauseMinutes);

            tbSonWorkHour.Text = GetNumberString(week.sonWorkHour);
            tbSonWorkMinute.Text = GetNumberString(week.sonWorkMinutes);
            tbSonPauseHour.Text = GetNumberString(week.sonPauseHour);
            tbSonPauseMinute.Text = GetNumberString(week.sonPauseMinutes);

            OutputHours();
            OutputMinutes();
            #endregion
        }

        private string GetNumberString(int number)
        {
            string output = "";
            if (number < 10)
                output = "0";
            output += number;

            return output;
        }

        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))            
                e.Handled = true;
        }

        #region Wochentage
        #region Montag
        private void TbMonWorkHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.monWorkHour = int.Parse(tbMonWorkHour.Text);
        }

        private void TbMonWorkMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.monWorkMinutes = int.Parse(tbMonWorkMinute.Text);
        }

        private void TbMonPauseHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.monPauseHour = int.Parse(tbMonPauseHour.Text);
        }

        private void TbMonPauseMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.monPauseMinutes = int.Parse(tbMonPauseMinute.Text);
        }
        #endregion

        #region Dienstag
        private void TbDiePauseMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.diePauseMinutes = int.Parse(tbDiePauseMinute.Text);
        }

        private void TbDiePauseHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.diePauseHour = int.Parse(tbDiePauseHour.Text);
        }

        private void TbDieWorkHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.dieWorkHour = int.Parse(tbDieWorkHour.Text);
        }

        private void TbDieWorkMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.dieWorkMinutes = int.Parse(tbDieWorkMinute.Text);
        }
        #endregion

        #region Mittwoch
        private void TbMitWorkHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.mitWorkHour = int.Parse(tbMitWorkHour.Text);
        }

        private void TbMitWorkMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.mitWorkMinutes = int.Parse(tbMitWorkMinute.Text);
        }

        private void TbMitPauseMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.mitPauseMinutes = int.Parse(tbMitPauseMinute.Text);
        }

        private void TbMitPauseHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.mitPauseHour = int.Parse(tbMitPauseHour.Text);
        }

        #endregion

        #region Donnerstag
        private void TbDonPauseHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.donPauseHour = int.Parse(tbDonPauseHour.Text);
        }

        private void TbDonPauseMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.donPauseMinutes = int.Parse(tbDonPauseMinute.Text);
        }

        private void TbDonWorkMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.donWorkMinutes = int.Parse(tbDonWorkMinute.Text);
        }

        private void TbDonWorkHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.donWorkHour = int.Parse(tbDonWorkHour.Text);
        }

        #endregion

        #region Freitag
        private void TbFreWorkHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.freWorkHour = int.Parse(tbFreWorkHour.Text);
        }

        private void TbFreWorkMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.freWorkMinutes = int.Parse(tbFreWorkMinute.Text);
        }

        private void TbFrePauseHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.frePauseHour = int.Parse(tbFrePauseHour.Text);
        }

        private void TbFrePauseMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.frePauseMinutes = int.Parse(tbFrePauseMinute.Text);
        }

        #endregion

        #region Samstag
        private void TbSamWorkHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.samWorkHour = int.Parse(tbSamWorkHour.Text);
        }

        private void TbSamWorkMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.samWorkMinutes = int.Parse(tbSamWorkMinute.Text);
        }

        private void TbSamPauseHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.samPauseHour = int.Parse(tbSamPauseHour.Text);
        }

        private void TbSamPauseMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.samPauseMinutes = int.Parse(tbSamPauseMinute.Text);
        }

        #endregion

        #region Sonntag
        private void TbSonWorkHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.sonWorkHour = int.Parse(tbSonWorkHour.Text);
        }

        private void TbSonWorkMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.sonWorkMinutes = int.Parse(tbSonWorkMinute.Text);
        }

        private void TbSonPauseHour_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.sonPauseHour = int.Parse(tbSonPauseHour.Text);
        }

        private void TbSonPauseMinute_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox tb = sender as Bunifu.Framework.UI.BunifuMaterialTextbox;
            if (tb.Text.Length > 0)
                week.sonPauseMinutes = int.Parse(tbSonPauseMinute.Text);
        }
        #endregion

        #endregion

        #region Arrow Buttons
        private void BtnHoursUp_MouseDown(object sender, MouseEventArgs e)
        {
            hours++;
            CheckHours();
            OutputHours();
        }

        private void BtnTenHoursUp_MouseDown(object sender, MouseEventArgs e)
        {
            hours += 10;
            CheckHours();
            OutputHours();
        }

        private void BtnhoursDown_MouseDown(object sender, MouseEventArgs e)
        {
            hours--;
            CheckHours();
            OutputHours();
        }

        private void BtnTenHoursDown_MouseDown(object sender, MouseEventArgs e)
        {
            hours -= 10;
            CheckHours();
            OutputHours();
        }

        private void BtnTenMinutesUp_MouseDown(object sender, MouseEventArgs e)
        {
            minutes += 10;
            CheckMinutes();
            OutputMinutes();
        }

        private void BtnMinutesUp_MouseDown(object sender, MouseEventArgs e)
        {
            minutes++;
            CheckMinutes();
            OutputMinutes();
        }

        private void BtnTenMinutesDown_MouseDown(object sender, MouseEventArgs e)
        {
            minutes -= 10;
            CheckMinutes();
            OutputMinutes();
        }

        private void BtnMinutesDown_MouseDown(object sender, MouseEventArgs e)
        {
            minutes--;
            CheckMinutes();
            OutputMinutes();
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
                {
                    hours -= 24;
                }
            }
            else
            {
                hours += 24;
            }
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
                {
                    minutes -= 60;
                }
            }
            else
            {
                minutes += 60;
            }
        }

        private void OutputHours()
        {
            int one = hours % 10;
            int ten = hours - one;
            lTenHours.Text = ten.ToString();
            lHours.Text = one.ToString();
            week.hours = hours;
        }

        private void OutputMinutes()
        {
            int one = minutes % 10;
            int ten = minutes - one;
            lTenMinutes.Text = ten.ToString();
            lMinutes.Text = one.ToString();
            week.minutes = minutes;
        }

        #endregion

        private void Options_MouseClick(object sender, MouseEventArgs e)
        {
            lTimeOutput.Focus();
        }

        private void BtnSaveAndReload_Click(object sender, EventArgs e)
        {
            SaveCfg();

            Application.Restart();
        }
    }
}
