namespace WorkTimeCalculator
{
    partial class FormMain
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pTop = new System.Windows.Forms.Panel();
            this.lHeader = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pSide = new System.Windows.Forms.Panel();
            this.pbBtnAbout = new System.Windows.Forms.PictureBox();
            this.pbBtnOptions = new System.Windows.Forms.PictureBox();
            this.pbBtnCalculator = new System.Windows.Forms.PictureBox();
            this.bunifuElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pMain = new System.Windows.Forms.Panel();
            this.pTop.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.pSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnCalculator)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.lHeader);
            this.pTop.Controls.Add(this.bunifuSeparator1);
            this.pTop.Controls.Add(this.pLogo);
            this.pTop.Controls.Add(this.pbMinimize);
            this.pTop.Controls.Add(this.pbClose);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(600, 49);
            this.pTop.TabIndex = 10;
            this.pTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.pTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            // 
            // lHeader
            // 
            this.lHeader.AutoSize = true;
            this.lHeader.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader.Location = new System.Drawing.Point(54, 13);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(197, 23);
            this.lHeader.TabIndex = 12;
            this.lHeader.Text = "Arbeitszeitrechner";
            this.lHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.lHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(48, 48);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(552, 1);
            this.bunifuSeparator1.TabIndex = 11;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.pLogo.Controls.Add(this.pbLogo);
            this.pLogo.Controls.Add(this.bunifuSeparator2);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(48, 49);
            this.pLogo.TabIndex = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_AlarmClock;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(48, 48);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 48);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(48, 1);
            this.bunifuSeparator2.TabIndex = 12;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimize.Image = global::WorkTimeCalculator.Properties.Resources.iconMinimize;
            this.pbMinimize.Location = new System.Drawing.Point(540, 0);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(30, 30);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 9;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = global::WorkTimeCalculator.Properties.Resources.iconClose;
            this.pbClose.Location = new System.Drawing.Point(570, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 8;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            // 
            // pSide
            // 
            this.pSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(100)))));
            this.pSide.Controls.Add(this.pbBtnAbout);
            this.pSide.Controls.Add(this.pbBtnOptions);
            this.pSide.Controls.Add(this.pbBtnCalculator);
            this.pSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSide.Location = new System.Drawing.Point(0, 49);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(48, 301);
            this.pSide.TabIndex = 11;
            // 
            // pbBtnAbout
            // 
            this.pbBtnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBtnAbout.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_Info;
            this.pbBtnAbout.Location = new System.Drawing.Point(0, 96);
            this.pbBtnAbout.Name = "pbBtnAbout";
            this.pbBtnAbout.Size = new System.Drawing.Size(48, 48);
            this.pbBtnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnAbout.TabIndex = 16;
            this.pbBtnAbout.TabStop = false;
            this.pbBtnAbout.Click += new System.EventHandler(this.PbBtnAbout_Click);
            this.pbBtnAbout.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.pbBtnAbout.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // pbBtnOptions
            // 
            this.pbBtnOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBtnOptions.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_Sliders;
            this.pbBtnOptions.Location = new System.Drawing.Point(0, 48);
            this.pbBtnOptions.Name = "pbBtnOptions";
            this.pbBtnOptions.Size = new System.Drawing.Size(48, 48);
            this.pbBtnOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnOptions.TabIndex = 15;
            this.pbBtnOptions.TabStop = false;
            this.pbBtnOptions.Click += new System.EventHandler(this.PbBtnOptions_Click);
            this.pbBtnOptions.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.pbBtnOptions.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // pbBtnCalculator
            // 
            this.pbBtnCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBtnCalculator.Image = global::WorkTimeCalculator.Properties.Resources.UI_Icon_Stopwatch;
            this.pbBtnCalculator.Location = new System.Drawing.Point(0, 0);
            this.pbBtnCalculator.Name = "pbBtnCalculator";
            this.pbBtnCalculator.Size = new System.Drawing.Size(48, 48);
            this.pbBtnCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnCalculator.TabIndex = 14;
            this.pbBtnCalculator.TabStop = false;
            this.pbBtnCalculator.Click += new System.EventHandler(this.PbBtnCalculator_Click);
            this.pbBtnCalculator.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.pbBtnCalculator.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // bunifuElipseForm
            // 
            this.bunifuElipseForm.ElipseRadius = 5;
            this.bunifuElipseForm.TargetControl = this;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(48, 49);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(552, 301);
            this.pMain.TabIndex = 12;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pSide);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.pSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnCalculator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel pTop;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel pSide;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseForm;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.PictureBox pbBtnOptions;
        private System.Windows.Forms.PictureBox pbBtnCalculator;
        private System.Windows.Forms.PictureBox pbBtnAbout;
    }
}

