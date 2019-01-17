using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class ALarmControl : UserControl
    {
        #region properties
        private Alarm alarms;
        public Alarm Alarms { get => alarms; set => alarms = value; }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        #endregion

        #region methods

        public ALarmControl()
        {
            InitializeComponent();
        }
        public ALarmControl(Alarm alarm)
        {
            InitializeComponent();
            this.Alarms = alarm;
            show();
        }
        public void show()
        {
            this.tbHour_AC.Text = (this.Alarms.TimeAlarm.X).ToString();
            this.tbMin_AC.Text = (this.Alarms.TimeAlarm.Y).ToString();
            //Sunday
            if (this.Alarms.DayAlarm[0] == 1)
            {
                this.cboxCN.Checked = true;
            }
            //Monday
            if (this.Alarms.DayAlarm[1] == 1)
            {
                this.cboxT2.Checked = true;
            }
            //tuesday
            if (this.Alarms.DayAlarm[2] == 1)
            {
                this.cboxT3.Checked = true;
            }
            //wednesday
            if (this.Alarms.DayAlarm[3] == 1)
            {
                this.cboxT4.Checked = true;
            }
            //thusday
            if (this.Alarms.DayAlarm[4] == 1)
            {
                this.cboxT5.Checked = true;
            }
            //friday
            if (this.Alarms.DayAlarm[5] == 1)
            {
                this.cboxT6.Checked = true;
            }
            //saturday
            if (this.Alarms.DayAlarm[6] == 1)
            {
                this.cboxT7.Checked = true;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
            {
                deleted(this, new EventArgs());
            }
        }
        #endregion
    }
}
