namespace AnalogClock
{
    partial class ALarmControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbHour_AC = new System.Windows.Forms.TextBox();
            this.tbMin_AC = new System.Windows.Forms.TextBox();
            this.cboxT2 = new System.Windows.Forms.CheckBox();
            this.cboxT3 = new System.Windows.Forms.CheckBox();
            this.cboxT4 = new System.Windows.Forms.CheckBox();
            this.cboxT5 = new System.Windows.Forms.CheckBox();
            this.cboxT6 = new System.Windows.Forms.CheckBox();
            this.cboxT7 = new System.Windows.Forms.CheckBox();
            this.cboxCN = new System.Windows.Forms.CheckBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHour_AC
            // 
            this.tbHour_AC.Location = new System.Drawing.Point(3, 3);
            this.tbHour_AC.Name = "tbHour_AC";
            this.tbHour_AC.Size = new System.Drawing.Size(40, 20);
            this.tbHour_AC.TabIndex = 0;
            // 
            // tbMin_AC
            // 
            this.tbMin_AC.Location = new System.Drawing.Point(49, 3);
            this.tbMin_AC.Name = "tbMin_AC";
            this.tbMin_AC.Size = new System.Drawing.Size(40, 20);
            this.tbMin_AC.TabIndex = 1;
            // 
            // cboxT2
            // 
            this.cboxT2.AutoSize = true;
            this.cboxT2.Location = new System.Drawing.Point(106, 6);
            this.cboxT2.Name = "cboxT2";
            this.cboxT2.Size = new System.Drawing.Size(15, 14);
            this.cboxT2.TabIndex = 1;
            this.cboxT2.UseVisualStyleBackColor = true;
            // 
            // cboxT3
            // 
            this.cboxT3.AutoSize = true;
            this.cboxT3.Location = new System.Drawing.Point(127, 6);
            this.cboxT3.Name = "cboxT3";
            this.cboxT3.Size = new System.Drawing.Size(15, 14);
            this.cboxT3.TabIndex = 1;
            this.cboxT3.UseVisualStyleBackColor = true;
            // 
            // cboxT4
            // 
            this.cboxT4.AutoSize = true;
            this.cboxT4.Location = new System.Drawing.Point(148, 6);
            this.cboxT4.Name = "cboxT4";
            this.cboxT4.Size = new System.Drawing.Size(15, 14);
            this.cboxT4.TabIndex = 1;
            this.cboxT4.UseVisualStyleBackColor = true;
            // 
            // cboxT5
            // 
            this.cboxT5.AutoSize = true;
            this.cboxT5.Location = new System.Drawing.Point(169, 6);
            this.cboxT5.Name = "cboxT5";
            this.cboxT5.Size = new System.Drawing.Size(15, 14);
            this.cboxT5.TabIndex = 1;
            this.cboxT5.UseVisualStyleBackColor = true;
            // 
            // cboxT6
            // 
            this.cboxT6.AutoSize = true;
            this.cboxT6.Location = new System.Drawing.Point(190, 6);
            this.cboxT6.Name = "cboxT6";
            this.cboxT6.Size = new System.Drawing.Size(15, 14);
            this.cboxT6.TabIndex = 1;
            this.cboxT6.UseVisualStyleBackColor = true;
            // 
            // cboxT7
            // 
            this.cboxT7.AutoSize = true;
            this.cboxT7.Location = new System.Drawing.Point(211, 6);
            this.cboxT7.Name = "cboxT7";
            this.cboxT7.Size = new System.Drawing.Size(15, 14);
            this.cboxT7.TabIndex = 1;
            this.cboxT7.UseVisualStyleBackColor = true;
            // 
            // cboxCN
            // 
            this.cboxCN.AutoSize = true;
            this.cboxCN.Location = new System.Drawing.Point(232, 6);
            this.cboxCN.Name = "cboxCN";
            this.cboxCN.Size = new System.Drawing.Size(15, 14);
            this.cboxCN.TabIndex = 1;
            this.cboxCN.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(437, 0);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(60, 25);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // ALarmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.cboxCN);
            this.Controls.Add(this.cboxT7);
            this.Controls.Add(this.cboxT6);
            this.Controls.Add(this.cboxT5);
            this.Controls.Add(this.cboxT4);
            this.Controls.Add(this.cboxT3);
            this.Controls.Add(this.cboxT2);
            this.Controls.Add(this.tbMin_AC);
            this.Controls.Add(this.tbHour_AC);
            this.Name = "ALarmControl";
            this.Size = new System.Drawing.Size(500, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHour_AC;
        private System.Windows.Forms.TextBox tbMin_AC;
        private System.Windows.Forms.CheckBox cboxT2;
        private System.Windows.Forms.CheckBox cboxT3;
        private System.Windows.Forms.CheckBox cboxT4;
        private System.Windows.Forms.CheckBox cboxT5;
        private System.Windows.Forms.CheckBox cboxT6;
        private System.Windows.Forms.CheckBox cboxT7;
        private System.Windows.Forms.CheckBox cboxCN;
        private System.Windows.Forms.Button btDelete;
    }
}
