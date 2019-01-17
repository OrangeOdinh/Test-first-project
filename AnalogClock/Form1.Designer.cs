namespace AnalogClock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbHour_Clock = new System.Windows.Forms.Label();
            this.panelClock = new System.Windows.Forms.Panel();
            this.menuStrip_clock = new System.Windows.Forms.MenuStrip();
            this.toolstripBG = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripDN = new System.Windows.Forms.ToolStripMenuItem();
            this.pnellb = new System.Windows.Forms.Panel();
            this.pnelAlarm = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip_clock.SuspendLayout();
            this.pnellb.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbHour_Clock
            // 
            this.lbHour_Clock.AutoSize = true;
            this.lbHour_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour_Clock.Location = new System.Drawing.Point(200, 246);
            this.lbHour_Clock.Name = "lbHour_Clock";
            this.lbHour_Clock.Size = new System.Drawing.Size(110, 20);
            this.lbHour_Clock.TabIndex = 1;
            this.lbHour_Clock.Text = "00:00:00 AM";
            // 
            // panelClock
            // 
            this.panelClock.AutoSize = true;
            this.panelClock.BackgroundImage = global::AnalogClock.Properties.Resources.download1;
            this.panelClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelClock.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelClock.Location = new System.Drawing.Point(156, 43);
            this.panelClock.Name = "panelClock";
            this.panelClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelClock.Size = new System.Drawing.Size(200, 200);
            this.panelClock.TabIndex = 0;
            this.panelClock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClock_Paint);
            // 
            // menuStrip_clock
            // 
            this.menuStrip_clock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripBG,
            this.toolstripDN});
            this.menuStrip_clock.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_clock.Name = "menuStrip_clock";
            this.menuStrip_clock.Size = new System.Drawing.Size(506, 24);
            this.menuStrip_clock.TabIndex = 3;
            this.menuStrip_clock.Text = "menuStrip1";
            // 
            // toolstripBG
            // 
            this.toolstripBG.Name = "toolstripBG";
            this.toolstripBG.Size = new System.Drawing.Size(64, 20);
            this.toolstripBG.Text = "Bấm Giờ";
            this.toolstripBG.Click += new System.EventHandler(this.toolstripBG_Click);
            // 
            // toolstripDN
            // 
            this.toolstripDN.Name = "toolstripDN";
            this.toolstripDN.Size = new System.Drawing.Size(83, 20);
            this.toolstripDN.Text = "Đếm Ngược";
            this.toolstripDN.Click += new System.EventHandler(this.toolstripDN_Click);
            // 
            // pnellb
            // 
            this.pnellb.Controls.Add(this.label9);
            this.pnellb.Controls.Add(this.label8);
            this.pnellb.Controls.Add(this.label7);
            this.pnellb.Controls.Add(this.label6);
            this.pnellb.Controls.Add(this.label5);
            this.pnellb.Controls.Add(this.label4);
            this.pnellb.Controls.Add(this.label3);
            this.pnellb.Controls.Add(this.label2);
            this.pnellb.Controls.Add(this.label1);
            this.pnellb.Location = new System.Drawing.Point(0, 269);
            this.pnellb.Name = "pnellb";
            this.pnellb.Size = new System.Drawing.Size(500, 31);
            this.pnellb.TabIndex = 4;
            // 
            // pnelAlarm
            // 
            this.pnelAlarm.AutoSize = true;
            this.pnelAlarm.Location = new System.Drawing.Point(0, 306);
            this.pnelAlarm.Name = "pnelAlarm";
            this.pnelAlarm.Size = new System.Drawing.Size(500, 285);
            this.pnelAlarm.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phút";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "T2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "T3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "T4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "T5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "T6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "T7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "CN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(506, 603);
            this.Controls.Add(this.pnelAlarm);
            this.Controls.Add(this.pnellb);
            this.Controls.Add(this.lbHour_Clock);
            this.Controls.Add(this.panelClock);
            this.Controls.Add(this.menuStrip_clock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồng hồ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip_clock.ResumeLayout(false);
            this.menuStrip_clock.PerformLayout();
            this.pnellb.ResumeLayout(false);
            this.pnellb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbHour_Clock;
        private System.Windows.Forms.MenuStrip menuStrip_clock;
        private System.Windows.Forms.ToolStripMenuItem toolstripBG;
        private System.Windows.Forms.ToolStripMenuItem toolstripDN;
        private System.Windows.Forms.Panel pnellb;
        private System.Windows.Forms.Panel pnelAlarm;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

