namespace AnalogClock
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbHour_DG = new System.Windows.Forms.TextBox();
            this.tbMin_DG = new System.Windows.Forms.TextBox();
            this.tbSec_DG = new System.Windows.Forms.TextBox();
            this.btStart_DG = new System.Windows.Forms.Button();
            this.btStop_DG = new System.Windows.Forms.Button();
            this.btReset_DG = new System.Windows.Forms.Button();
            this.btReturn_DG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHour_DG = new System.Windows.Forms.Label();
            this.lbMin_DG = new System.Windows.Forms.Label();
            this.lbSec_DG = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer_DG = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnalogClock.Properties.Resources._41145020_455981238246457_4218501841450696704_n;
            this.pictureBox1.Location = new System.Drawing.Point(441, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbHour_DG
            // 
            this.tbHour_DG.Location = new System.Drawing.Point(12, 30);
            this.tbHour_DG.Name = "tbHour_DG";
            this.tbHour_DG.Size = new System.Drawing.Size(40, 20);
            this.tbHour_DG.TabIndex = 1;
            this.tbHour_DG.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbHour_DG_KeyUp);
            // 
            // tbMin_DG
            // 
            this.tbMin_DG.Location = new System.Drawing.Point(67, 30);
            this.tbMin_DG.Name = "tbMin_DG";
            this.tbMin_DG.Size = new System.Drawing.Size(40, 20);
            this.tbMin_DG.TabIndex = 2;
            this.tbMin_DG.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbMin_DG_KeyUp);
            // 
            // tbSec_DG
            // 
            this.tbSec_DG.Location = new System.Drawing.Point(119, 30);
            this.tbSec_DG.Name = "tbSec_DG";
            this.tbSec_DG.Size = new System.Drawing.Size(40, 20);
            this.tbSec_DG.TabIndex = 3;
            this.tbSec_DG.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSec_DN_KeyUp);
            // 
            // btStart_DG
            // 
            this.btStart_DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart_DG.Location = new System.Drawing.Point(15, 182);
            this.btStart_DG.Name = "btStart_DG";
            this.btStart_DG.Size = new System.Drawing.Size(60, 40);
            this.btStart_DG.TabIndex = 4;
            this.btStart_DG.Text = "Start";
            this.btStart_DG.UseVisualStyleBackColor = true;
            this.btStart_DG.Click += new System.EventHandler(this.btStart_DG_Click);
            // 
            // btStop_DG
            // 
            this.btStop_DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop_DG.Location = new System.Drawing.Point(91, 182);
            this.btStop_DG.Name = "btStop_DG";
            this.btStop_DG.Size = new System.Drawing.Size(60, 40);
            this.btStop_DG.TabIndex = 5;
            this.btStop_DG.Text = "Stop";
            this.btStop_DG.UseVisualStyleBackColor = true;
            this.btStop_DG.Click += new System.EventHandler(this.btStop_DG_Click);
            // 
            // btReset_DG
            // 
            this.btReset_DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset_DG.Location = new System.Drawing.Point(167, 182);
            this.btReset_DG.Name = "btReset_DG";
            this.btReset_DG.Size = new System.Drawing.Size(60, 40);
            this.btReset_DG.TabIndex = 6;
            this.btReset_DG.Text = "Reset";
            this.btReset_DG.UseVisualStyleBackColor = true;
            this.btReset_DG.Click += new System.EventHandler(this.btReset_DG_Click);
            // 
            // btReturn_DG
            // 
            this.btReturn_DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn_DG.Location = new System.Drawing.Point(252, 182);
            this.btReturn_DG.Name = "btReturn_DG";
            this.btReturn_DG.Size = new System.Drawing.Size(60, 40);
            this.btReturn_DG.TabIndex = 7;
            this.btReturn_DG.Text = "Return";
            this.btReturn_DG.UseVisualStyleBackColor = true;
            this.btReturn_DG.Click += new System.EventHandler(this.btReturn_DG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phút";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giây";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 55);
            this.label4.TabIndex = 11;
            this.label4.Text = ":";
            // 
            // lbHour_DG
            // 
            this.lbHour_DG.AutoSize = true;
            this.lbHour_DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour_DG.Location = new System.Drawing.Point(12, 79);
            this.lbHour_DG.Name = "lbHour_DG";
            this.lbHour_DG.Size = new System.Drawing.Size(104, 73);
            this.lbHour_DG.TabIndex = 11;
            this.lbHour_DG.Text = "00";
            // 
            // lbMin_DG
            // 
            this.lbMin_DG.AutoSize = true;
            this.lbMin_DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin_DG.Location = new System.Drawing.Point(165, 79);
            this.lbMin_DG.Name = "lbMin_DG";
            this.lbMin_DG.Size = new System.Drawing.Size(104, 73);
            this.lbMin_DG.TabIndex = 11;
            this.lbMin_DG.Text = "00";
            // 
            // lbSec_DG
            // 
            this.lbSec_DG.AutoSize = true;
            this.lbSec_DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec_DG.Location = new System.Drawing.Point(318, 79);
            this.lbSec_DG.Name = "lbSec_DG";
            this.lbSec_DG.Size = new System.Drawing.Size(104, 73);
            this.lbSec_DG.TabIndex = 11;
            this.lbSec_DG.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 55);
            this.label5.TabIndex = 11;
            this.label5.Text = ":";
            // 
            // timer_DG
            // 
            this.timer_DG.Tick += new System.EventHandler(this.timer_DG_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(625, 245);
            this.Controls.Add(this.lbSec_DG);
            this.Controls.Add(this.lbMin_DG);
            this.Controls.Add(this.lbHour_DG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturn_DG);
            this.Controls.Add(this.btReset_DG);
            this.Controls.Add(this.btStop_DG);
            this.Controls.Add(this.btStart_DG);
            this.Controls.Add(this.tbSec_DG);
            this.Controls.Add(this.tbMin_DG);
            this.Controls.Add(this.tbHour_DG);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Đếm Ngược";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbHour_DG;
        private System.Windows.Forms.TextBox tbMin_DG;
        private System.Windows.Forms.TextBox tbSec_DG;
        private System.Windows.Forms.Button btStart_DG;
        private System.Windows.Forms.Button btStop_DG;
        private System.Windows.Forms.Button btReset_DG;
        private System.Windows.Forms.Button btReturn_DG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHour_DG;
        private System.Windows.Forms.Label lbMin_DG;
        private System.Windows.Forms.Label lbSec_DG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer_DG;
    }
}