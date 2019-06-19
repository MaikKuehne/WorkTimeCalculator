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
    public partial class About : UserControl
    {
        Timer timer = new Timer();
        public About()
        {
            InitializeComponent();
            timer.Interval = 2500;
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pbLlama.Visible = false;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            pbLlama.Visible = true;
            pbLlama.Image = Properties.Resources.llama;
            timer.Start();
        }
    }
}
