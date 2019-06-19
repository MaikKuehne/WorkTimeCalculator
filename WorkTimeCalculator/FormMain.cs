using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeCalculator
{
    public partial class FormMain : Form
    {
        Options options = new Options();
        Calculator calculator;
        About about = new About();

        int activeControl = 0;
        PictureBox activePB;
        public FormMain()
        {
            InitializeComponent();

            calculator = new Calculator(options);
            activePB = pbBtnCalculator;
            pbBtnCalculator.BackColor = Color.FromArgb(31, 43, 55);
            pMain.Controls.Add(calculator);
        }

        #region Drag Form
        private Point MouseDownLocation;
        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new Point(e.X + this.Left - MouseDownLocation.X, e.Y + this.Top - MouseDownLocation.Y);

            }
        }
        #endregion

        #region Button Close / Minimize
        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.IndianRed;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.Transparent;
        }

        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.DarkGray;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.Transparent;
        }
        #endregion

        private void PbBtnCalculator_Click(object sender, EventArgs e)
        {
            if (activeControl != 0)
            {
                RemovePMainControl();
                activeControl = 0;
                pMain.Controls.Add(calculator);
                activePB = pbBtnCalculator;
                pbBtnCalculator.BackColor = Color.FromArgb(31, 43, 55);
            }
        }

        private void PbBtnOptions_Click(object sender, EventArgs e)
        {
            if (activeControl != 1)
            {
                RemovePMainControl();
                activeControl = 1;
                pbBtnOptions.BackColor = Color.FromArgb(31, 43, 55);
                activePB = pbBtnOptions;
               pMain.Controls.Add(options);
            }
        }

        private void PbBtnAbout_Click(object sender, EventArgs e)
        {
            if (activeControl != 2)
            {
                RemovePMainControl();
                activeControl = 2;
                pbBtnAbout.BackColor = Color.FromArgb(31, 43, 55);
                activePB = pbBtnAbout;
               pMain.Controls.Add(about);
            }
        }

        private void RemovePMainControl()
        {
            pMain.Controls.Clear();

            switch (activeControl)
            {
                case 0:
                    pbBtnCalculator.BackColor = Color.FromArgb(73, 85, 100);
                    break;
                case 1:
                    pbBtnOptions.BackColor = Color.FromArgb(73, 85, 100);
                    break;
                case 2:
                    pbBtnAbout.BackColor = Color.FromArgb(73, 85, 100);
                    break;
                default:
                    break;
            }
        }

        private void BtnMouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != activePB)            
                pb.BackColor = Color.FromArgb(56, 68, 80);
        }

        private void BtnMouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != activePB)
                pb.BackColor = Color.FromArgb(73, 85, 100);
        }
    }
}
