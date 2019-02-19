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
       private IDoor _door;
       private IUserValidation _userValidation;
       private IEntryNotification _entryNotification;
        public DoorControlClass(IAlarm alarm, IDoor door, IEntryNotification entryNotification, IUserValidation userValidation)
        {
            _alarm = alarm;
           _door = door;
           _entryNotification = entryNotification;
           _userValidation = userValidation;
        }

        public void RaiseAlarm()
        {
            _alarm.RaiseAlarm();
        }

       public void RequestEntry(string id)
       {
          if (_userValidation.ValidateEntryRequest(id))
          {
             _door.Open();
             _entryNotification.NotifyEntryGranted();
          }
          else
          {
            _entryNotification.NotifyEntryDenied();
          }
       }
    }
}
