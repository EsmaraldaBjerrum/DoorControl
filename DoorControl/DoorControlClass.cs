using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class DoorControlClass
    {
        private IAlarm _alarm;
        public DoorControlClass(IAlarm alarm)
        {
            _alarm = alarm;
        }

        public void RaiseAlarm()
        {
            _alarm.RaiseAlarm();
        }
    }
}
