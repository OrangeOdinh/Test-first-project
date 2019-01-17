using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogClock
{
    [Serializable]
    public class ListAlarm
    {
        private List<Alarm> lAlarms;

        public List<Alarm> LAlarms { get => lAlarms; set => lAlarms = value; }
    }
}
