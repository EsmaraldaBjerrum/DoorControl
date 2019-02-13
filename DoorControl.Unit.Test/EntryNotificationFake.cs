using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Unit.Test
{
    public class EntryNotificationFake : IEntryNotification
    {
        public bool EntryGrantedIsCalled = false;
        public bool EntryDeniedIsCalled = false;

        public void NotifyEntryGranted()
        {
            EntryGrantedIsCalled = true;
        }

        public void NotifyEntryDenied()
        {
            EntryDeniedIsCalled = true;
        }
    }
}
