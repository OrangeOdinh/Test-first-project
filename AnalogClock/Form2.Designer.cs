namespace AnalogClock
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHour_BG = new System.Windows.Forms.Label();
            this.lbMin_BG = new System.Windows.Forms.Label();
            this.lbSec_BG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btStart_BG = new System.Windows.Forms.Button();
            this.btReset_BG = new System.Windows.Forms.Button();
            this.lbResult_BG = new System.Windows.Forms.Label();
            this.timer_BG = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnalogClock.Properties.Resources._41145020_455981238246457_4218501841450696704_n;
            this.pictureBox1.Location = new System.Drawing.Point(428, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbHour_BG
            // 
            this.lbHour_BG.AutoSize = true;
            this.lbHour_BG.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour_BG.Location = new System.Drawing.Point(12, 9);
            this.lbHour_BG.Name = "lbHour_BG";
            this.lbHour_BG.Size = new System.Drawing.Size(104, 73);
            this.lbHour_BG.TabIndex = 1;
            this.lbHour_BG.Text = "00";
            // 
            // lbMin_BG
            // 
            this.lbMin_BG.AutoSize = true;
            this.lbMin_BG.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin_BG.Location = new System.Drawing.Point(165, 9);
            this.lbMin_BG.Name = "lbMin_BG";
            this.lbMin_BG.Size = new System.Drawing.Size(104, 73);
            this.lbMin_BG.TabIndex = 2;
            this.lbMin_BG.Text = "00";
            // 
            // lbSec_BG
            // 
            this.lbSec_BG.AutoSize = true;
            this.lbSec_BG.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSec_BG.Location = new System.Drawing.Point(318, 9);
            this.lbSec_BG.Name = "lbSec_BG";
            this.lbSec_BG.Size = new System.Drawing.Size(104, 73);
            this.lbSec_BG.TabIndex = 2;
            this.lbSec_BG.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // btStart_BG
            // 
            this.btStart_BG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart_BG.Location = new System.Drawing.Point(83, 136);
            this.btStart_BG.Name = "btStart_BG";
            this.btStart_BG.Size = new System.Drawing.Size(85, 35);
            this.btStart_BG.TabIndex = 4;
            this.btStart_BG.Text = "Start";
            this.btStart_BG.UseVisualStyleBackColor = true;
            this.btStart_BG.Click += new System.EventHandler(this.btStart_BG_Click);
            // 
            // btReset_BG
            // 
            this.btReset_BG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset_BG.Location = new System.Drawing.Point(227, 136);
            this.btReset_BG.Name = "btReset_BG";
            this.btReset_BG.Size = new System.Drawing.Size(85, 35);
            this.btReset_BG.TabIndex = 5;
            this.btReset_BG.Text = "Reset";
            this.btReset_BG.UseVisualStyleBackColor = true;
            this.btReset_BG.Click += new System.EventHandler(this.btReset_BG_Click);
            // 
            // lbResult_BG
            // 
            this.lbResult_BG.AutoSize = true;
            this.lbResult_BG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult_BG.Location = new System.Drawing.Point(412, 190);
            this.lbResult_BG.Name = "lbResult_BG";
            this.lbResult_BG.Size = new System.Drawing.Size(0, 20);
            this.lbResult_BG.TabIndex = 6;
            // 
            // timer_BG
            // 
            this.timer_BG.Tick += new System.EventHandler(this.timer_BG_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(616, 231);
            this.Controls.Add(this.lbResult_BG);
            this.Controls.Add(this.btReset_BG);
            this.Controls.Add(this.btStart_BG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSec_BG);
            this.Controls.Add(this.lbMin_BG);
            this.Controls.Add(this.lbHour_BG);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Bấm Giờ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHour_BG;
        private System.Windows.Forms.Label lbMin_BG;
        private System.Windows.Forms.Label lbSec_BG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btStart_BG;
        private System.Windows.Forms.Button btReset_BG;
        private System.Windows.Forms.Label lbResult_BG;
        private System.Windows.Forms.Timer timer_BG;
    }
}