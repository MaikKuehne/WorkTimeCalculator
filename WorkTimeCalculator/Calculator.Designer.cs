namespace WorkTimeCalculator
{
    partial class Calculator
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btnhoursDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTenHoursDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHoursUp = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTenHoursUp = new Bunifu.Framework.UI.BunifuImageButton();
            this.lHours = new System.Windows.Forms.Label();
            this.lTenHours = new System.Windows.Forms.Label();
            this.lMinutes = new System.Windows.Forms.Label();
            this.lpunkt = new System.Windows.Forms.Label();
            this.lTenMinutes = new System.Windows.Forms.Label();
            this.btnMinutesDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTenMinutesDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinutesUp = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTenMinutesUp = new Bunifu.Framework.UI.BunifuImageButton();
            this.lTimeOPutputHeader = new System.Windows.Forms.Label();
            this.lCheckinHeader = new System.Windows.Forms.Label();
            this.lEndTimeHeader = new System.Windows.Forms.Label();
            this.lEndTime = new System.Windows.Forms.Label();
            this.lWorkTime = new System.Windows.Forms.Label();
            this.lWorkTimeHeader = new System.Windows.Forms.Label();
            this.lPausetime = new System.Windows.Forms.Label();
            this.lPausetimeHeader = new System.Windows.Forms.Label();
            this.CircleProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lTimeOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnhoursDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTenHoursDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHoursUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTenHoursUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinutesDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTenMinutesDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinutesUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTenMinutesUp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhoursDown
            // 
            this.btnhoursDown.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_ArrowDown;
            this.btnhoursDown.ImageActive = null;
            this.btnhoursDown.Location = new System.Drawing.Point(55, 130);
            this.btnhoursDown.Name = "btnhoursDown";
            this.btnhoursDown.Size = new System.Drawing.Size(24, 24);
            this.btnhoursDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnhoursDown.TabIndex = 8;
            this.btnhoursDown.TabStop = false;
            this.btnhoursDown.Zoom = 10;
            this.btnhoursDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnhoursDown_MouseDown);
            // 
            // btnTenHoursDown
            // 
            this.btnTenHoursDown.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_ArrowDown;
            this.btnTenHoursDown.ImageActive = null;
            this.btnTenHoursDown.Location = new System.Drawing.Point(31, 130);
            this.btnTenHoursDown.Name = "btnTenHoursDown";
            this.btnTenHoursDown.Size = new System.Drawing.Size(24, 24);
            this.btnTenHoursDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTenHoursDown.TabIndex = 7;
            this.btnTenHoursDown.TabStop = false;
            this.btnTenHoursDown.Zoom = 10;
            this.btnTenHoursDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnTenHoursDown_MouseDown);
            // 
            // btnHoursUp
            // 
            this.btnHoursUp.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_ArrowUp;
            this.btnHoursUp.ImageActive = null;
            this.btnHoursUp.Location = new System.Drawing.Point(55, 62);
            this.btnHoursUp.Name = "btnHoursUp";
            this.btnHoursUp.Size = new System.Drawing.Size(24, 24);
            this.btnHoursUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHoursUp.TabIndex = 6;
            this.btnHoursUp.TabStop = false;
            this.btnHoursUp.Zoom = 10;
            this.btnHoursUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnHoursUp_MouseDown);
            // 
            // btnTenHoursUp
            // 
            this.btnTenHoursUp.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_ArrowUp;
            this.btnTenHoursUp.ImageActive = null;
            this.btnTenHoursUp.Location = new System.Drawing.Point(31, 62);
            this.btnTenHoursUp.Name = "btnTenHoursUp";
            this.btnTenHoursUp.Size = new System.Drawing.Size(24, 24);
            this.btnTenHoursUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTenHoursUp.TabIndex = 5;
            this.btnTenHoursUp.TabStop = false;
            this.btnTenHoursUp.Zoom = 10;
            this.btnTenHoursUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnTenHoursUp_MouseDown);
            // 
            // lHours
            // 
            this.lHours.AutoSize = true;
            this.lHours.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHours.ForeColor = System.Drawing.Color.White;
            this.lHours.Location = new System.Drawing.Point(51, 89);
            this.lHours.Name = "lHours";
            this.lHours.Size = new System.Drawing.Size(35, 38);
            this.lHours.TabIndex = 18;
            this.lHours.Text = "0";
            // 
            // lTenHours
            // 
            this.lTenHours.AutoSize = true;
            this.lTenHours.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTenHours.ForeColor = System.Drawing.Color.White;
            this.lTenHours.Location = new System.Drawing.Point(27, 89);
            this.lTenHours.Name = "lTenHours";
            this.lTenHours.Size = new System.Drawing.Size(35, 38);
            this.lTenHours.TabIndex = 17;
            this.lTenHours.Text = "0";
            // 
            // lMinutes
            // 
            this.lMinutes.AutoSize = true;
            this.lMinutes.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMinutes.ForeColor = System.Drawing.Color.White;
            this.lMinutes.Location = new System.Drawing.Point(118, 89);
            this.lMinutes.Name = "lMinutes";
            this.lMinutes.Size = new System.Drawing.Size(35, 38);
            this.lMinutes.TabIndex = 16;
            this.lMinutes.Text = "0";
            // 
            // lpunkt
            // 
            this.lpunkt.AutoSize = true;
            this.lpunkt.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpunkt.ForeColor = System.Drawing.Color.White;
            this.lpunkt.Location = new System.Drawing.Point(76, 87);
            this.lpunkt.Name = "lpunkt";
            this.lpunkt.Size = new System.Drawing.Size(26, 38);
            this.lpunkt.TabIndex = 15;
            this.lpunkt.Text = ":";
            // 
            // lTenMinutes
            // 
            this.lTenMinutes.AutoSize = true;
            this.lTenMinutes.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTenMinutes.ForeColor = System.Drawing.Color.White;
            this.lTenMinutes.Location = new System.Drawing.Point(94, 89);
            this.lTenMinutes.Name = "lTenMinutes";
            this.lTenMinutes.Size = new System.Drawing.Size(35, 38);
            this.lTenMinutes.TabIndex = 14;
            this.lTenMinutes.Text = "0";
            // 
            // btnMinutesDown
            // 
            this.btnMinutesDown.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_ArrowDown;
            this.btnMinutesDown.ImageActive = null;
            this.btnMinutesDown.Location = new System.Drawing.Point(125, 130);
            this.btnMinutesDown.Name = "btnMinutesDown";
            this.btnMinutesDown.Size = new System.Drawing.Size(24, 24);
            this.btnMinutesDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinutesDown.TabIndex = 20;
            this.btnMinutesDown.TabStop = false;
            this.btnMinutesDown.Zoom = 10;
            this.btnMinutesDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMinutesDown_MouseDown);
            // 
            // btnTenMinutesDown
            // 
            this.btnTenMinutesDown.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_ArrowDown;
            this.btnTenMinutesDown.ImageActive = null;
            this.btnTenMinutesDown.Location = new System.Drawing.Point(101, 130);
            this.btnTenMinutesDown.Name = "btnTenMinutesDown";
            this.btnTenMinutesDown.Size = new System.Drawing.Size(24, 24);
            this.btnTenMinutesDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTenMinutesDown.TabIndex = 19;
            this.btnTenMinutesDown.TabStop = false;
            this.btnTenMinutesDown.Zoom = 10;
            this.btnTenMinutesDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnTenMinutesDown_MouseDown);
            // 
            // btnMinutesUp
            // 
            this.btnMinutesUp.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_ArrowUp;
            this.btnMinutesUp.ImageActive = null;
            this.btnMinutesUp.Location = new System.Drawing.Point(125, 62);
            this.btnMinutesUp.Name = "btnMinutesUp";
            this.btnMinutesUp.Size = new System.Drawing.Size(24, 24);
            this.btnMinutesUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinutesUp.TabIndex = 22;
            this.btnMinutesUp.TabStop = false;
            this.btnMinutesUp.Zoom = 10;
            this.btnMinutesUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnMinutesUp_MouseDown);
            // 
            // btnTenMinutesUp
            // 
            this.btnTenMinutesUp.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_ArrowUp;
            this.btnTenMinutesUp.ImageActive = null;
            this.btnTenMinutesUp.Location = new System.Drawing.Point(101, 62);
            this.btnTenMinutesUp.Name = "btnTenMinutesUp";
            this.btnTenMinutesUp.Size = new System.Drawing.Size(24, 24);
            this.btnTenMinutesUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTenMinutesUp.TabIndex = 21;
            this.btnTenMinutesUp.TabStop = false;
            this.btnTenMinutesUp.Zoom = 10;
            this.btnTenMinutesUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnTenMinutesUp_MouseDown);
            // 
            // lTimeOPutputHeader
            // 
            this.lTimeOPutputHeader.AutoSize = true;
            this.lTimeOPutputHeader.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimeOPutputHeader.ForeColor = System.Drawing.Color.White;
            this.lTimeOPutputHeader.Location = new System.Drawing.Point(15, 202);
            this.lTimeOPutputHeader.Name = "lTimeOPutputHeader";
            this.lTimeOPutputHeader.Size = new System.Drawing.Size(155, 25);
            this.lTimeOPutputHeader.TabIndex = 24;
            this.lTimeOPutputHeader.Text = "Überstunden";
            // 
            // lCheckinHeader
            // 
            this.lCheckinHeader.AutoSize = true;
            this.lCheckinHeader.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCheckinHeader.ForeColor = System.Drawing.Color.White;
            this.lCheckinHeader.Location = new System.Drawing.Point(15, 15);
            this.lCheckinHeader.Name = "lCheckinHeader";
            this.lCheckinHeader.Size = new System.Drawing.Size(157, 23);
            this.lCheckinHeader.TabIndex = 25;
            this.lCheckinHeader.Text = "Begin der Arbeit";
            // 
            // lEndTimeHeader
            // 
            this.lEndTimeHeader.AutoSize = true;
            this.lEndTimeHeader.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEndTimeHeader.ForeColor = System.Drawing.Color.White;
            this.lEndTimeHeader.Location = new System.Drawing.Point(191, 15);
            this.lEndTimeHeader.Name = "lEndTimeHeader";
            this.lEndTimeHeader.Size = new System.Drawing.Size(109, 19);
            this.lEndTimeHeader.TabIndex = 26;
            this.lEndTimeHeader.Text = "Arbeitsende";
            // 
            // lEndTime
            // 
            this.lEndTime.AutoSize = true;
            this.lEndTime.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEndTime.ForeColor = System.Drawing.Color.White;
            this.lEndTime.Location = new System.Drawing.Point(193, 45);
            this.lEndTime.Name = "lEndTime";
            this.lEndTime.Size = new System.Drawing.Size(66, 25);
            this.lEndTime.TabIndex = 27;
            this.lEndTime.Text = "00:00";
            // 
            // lWorkTime
            // 
            this.lWorkTime.AutoSize = true;
            this.lWorkTime.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWorkTime.ForeColor = System.Drawing.Color.White;
            this.lWorkTime.Location = new System.Drawing.Point(193, 107);
            this.lWorkTime.Name = "lWorkTime";
            this.lWorkTime.Size = new System.Drawing.Size(66, 25);
            this.lWorkTime.TabIndex = 29;
            this.lWorkTime.Text = "00:00";
            // 
            // lWorkTimeHeader
            // 
            this.lWorkTimeHeader.AutoSize = true;
            this.lWorkTimeHeader.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWorkTimeHeader.ForeColor = System.Drawing.Color.White;
            this.lWorkTimeHeader.Location = new System.Drawing.Point(191, 81);
            this.lWorkTimeHeader.Name = "lWorkTimeHeader";
            this.lWorkTimeHeader.Size = new System.Drawing.Size(100, 19);
            this.lWorkTimeHeader.TabIndex = 28;
            this.lWorkTimeHeader.Text = "Arbeitszeit";
            // 
            // lPausetime
            // 
            this.lPausetime.AutoSize = true;
            this.lPausetime.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPausetime.ForeColor = System.Drawing.Color.White;
            this.lPausetime.Location = new System.Drawing.Point(193, 151);
            this.lPausetime.Name = "lPausetime";
            this.lPausetime.Size = new System.Drawing.Size(66, 25);
            this.lPausetime.TabIndex = 31;
            this.lPausetime.Text = "00:00";
            // 
            // lPausetimeHeader
            // 
            this.lPausetimeHeader.AutoSize = true;
            this.lPausetimeHeader.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPausetimeHeader.ForeColor = System.Drawing.Color.White;
            this.lPausetimeHeader.Location = new System.Drawing.Point(191, 132);
            this.lPausetimeHeader.Name = "lPausetimeHeader";
            this.lPausetimeHeader.Size = new System.Drawing.Size(59, 19);
            this.lPausetimeHeader.TabIndex = 30;
            this.lPausetimeHeader.Text = "Pause";
            // 
            // CircleProgressBar
            // 
            this.CircleProgressBar.animated = false;
            this.CircleProgressBar.animationIterval = 5;
            this.CircleProgressBar.animationSpeed = 300;
            this.CircleProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleProgressBar.BackgroundImage")));
            this.CircleProgressBar.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleProgressBar.ForeColor = System.Drawing.Color.White;
            this.CircleProgressBar.LabelVisible = true;
            this.CircleProgressBar.LineProgressThickness = 8;
            this.CircleProgressBar.LineThickness = 5;
            this.CircleProgressBar.Location = new System.Drawing.Point(305, 19);
            this.CircleProgressBar.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.CircleProgressBar.MaxValue = 100;
            this.CircleProgressBar.Name = "CircleProgressBar";
            this.CircleProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CircleProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.CircleProgressBar.Size = new System.Drawing.Size(225, 225);
            this.CircleProgressBar.TabIndex = 32;
            this.CircleProgressBar.Value = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(176, 19);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(9, 157);
            this.bunifuSeparator1.TabIndex = 33;
            this.bunifuSeparator1.TabStop = false;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // lTimeOutput
            // 
            this.lTimeOutput.AutoSize = true;
            this.lTimeOutput.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimeOutput.ForeColor = System.Drawing.Color.White;
            this.lTimeOutput.Location = new System.Drawing.Point(14, 236);
            this.lTimeOutput.Name = "lTimeOutput";
            this.lTimeOutput.Size = new System.Drawing.Size(104, 28);
            this.lTimeOutput.TabIndex = 34;
            this.lTimeOutput.Text = "00:00:00";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.lTimeOutput);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.CircleProgressBar);
            this.Controls.Add(this.lPausetime);
            this.Controls.Add(this.lPausetimeHeader);
            this.Controls.Add(this.lWorkTime);
            this.Controls.Add(this.lWorkTimeHeader);
            this.Controls.Add(this.lEndTime);
            this.Controls.Add(this.lEndTimeHeader);
            this.Controls.Add(this.lCheckinHeader);
            this.Controls.Add(this.lTimeOPutputHeader);
            this.Controls.Add(this.btnMinutesUp);
            this.Controls.Add(this.btnTenMinutesUp);
            this.Controls.Add(this.btnMinutesDown);
            this.Controls.Add(this.btnTenMinutesDown);
            this.Controls.Add(this.lHours);
            this.Controls.Add(this.lTenHours);
            this.Controls.Add(this.lMinutes);
            this.Controls.Add(this.lpunkt);
            this.Controls.Add(this.lTenMinutes);
            this.Controls.Add(this.btnhoursDown);
            this.Controls.Add(this.btnTenHoursDown);
            this.Controls.Add(this.btnHoursUp);
            this.Controls.Add(this.btnTenHoursUp);
            this.Name = "Calculator";
            this.Size = new System.Drawing.Size(552, 301);
            ((System.ComponentModel.ISupportInitialize)(this.btnhoursDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTenHoursDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHoursUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTenHoursUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinutesDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTenMinutesDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinutesUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTenMinutesUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnTenHoursUp;
        private Bunifu.Framework.UI.BunifuImageButton btnHoursUp;
        private Bunifu.Framework.UI.BunifuImageButton btnTenHoursDown;
        private Bunifu.Framework.UI.BunifuImageButton btnhoursDown;
        private System.Windows.Forms.Label lHours;
        private System.Windows.Forms.Label lTenHours;
        private System.Windows.Forms.Label lMinutes;
        private System.Windows.Forms.Label lpunkt;
        private System.Windows.Forms.Label lTenMinutes;
        private Bunifu.Framework.UI.BunifuImageButton btnMinutesDown;
        private Bunifu.Framework.UI.BunifuImageButton btnTenMinutesDown;
        private Bunifu.Framework.UI.BunifuImageButton btnMinutesUp;
        private Bunifu.Framework.UI.BunifuImageButton btnTenMinutesUp;
        private System.Windows.Forms.Label lTimeOPutputHeader;
        private System.Windows.Forms.Label lCheckinHeader;
        private System.Windows.Forms.Label lEndTimeHeader;
        private System.Windows.Forms.Label lEndTime;
        private System.Windows.Forms.Label lWorkTime;
        private System.Windows.Forms.Label lWorkTimeHeader;
        private System.Windows.Forms.Label lPausetime;
        private System.Windows.Forms.Label lPausetimeHeader;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleProgressBar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lTimeOutput;
    }
}
