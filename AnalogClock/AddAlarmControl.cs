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
    public partial class AddAlarmControl : UserControl
    {
        #region properties
        private Alarm alarms;
        private event EventHandler added;
        #endregion

        #region methods
        public AddAlarmControl()
        {
            InitializeComponent();
        }

        private void btAdd_AAC_Click(object sender, EventArgs e)
        {
            Alarms = new Alarm();
            int hour, min;
            if(tbHour_AAC.Text == "")
            {
                hour = 0;
            }
            else
            {
                hour = Convert.ToInt32(tbHour_AAC.Text);
            }

            if (tbMin_AAC.Text == "")
            {
                min = 0;
            }
            else
            {
                min = Convert.ToInt32(tbMin_AAC.Text);
            }
            Alarms.TimeAlarm = new Point(hour,min);
            Alarms.DayAlarm[0] = cboxCN.Checked == true ? 1 : 0;
            Alarms.DayAlarm[1] = cboxT2.Checked == true ? 1 : 0;
            Alarms.DayAlarm[2] = cboxT3.Checked == true ? 1 : 0;
            Alarms.DayAlarm[3] = cboxT4.Checked == true ? 1 : 0;
            Alarms.DayAlarm[4] = cboxT5.Checked == true ? 1 : 0;
            Alarms.DayAlarm[5] = cboxT6.Checked == true ? 1 : 0;
            Alarms.DayAlarm[6] = cboxT7.Checked == true ? 1 : 0;
            added(this, new EventArgs());
        }
        public Alarm Alarms { get => alarms; set => alarms = value; }
        public event EventHandler Added
        {
            add { added += value; }
            remove { added -= value; }
        }
        #endregion
    }
}
