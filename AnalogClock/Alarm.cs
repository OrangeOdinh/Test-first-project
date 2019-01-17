using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogClock
{
    public class Alarm
    {

        #region properties
        private Point timeAlarm;
        private int[] dayAlarm = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        #endregion

        #region methods
        public Point TimeAlarm { get => timeAlarm; set => timeAlarm = value; }
        public int[] DayAlarm { get => dayAlarm; set => dayAlarm = value; }
        #endregion
    }
}
