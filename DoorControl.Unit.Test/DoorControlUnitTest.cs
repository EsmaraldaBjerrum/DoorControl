using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DoorControl;
using NSubstitute;

namespace DoorControl.Unit.Test
{
   [TestFixture]
    public class DoorControlUnitTest
    {
      private DoorControlClass _uut;
       private IDoor _door;
       private IAlarm _alarm;
       private IEntryNotification _entryNotification;
       private IUserValidation _userValidation;
       
        [SetUp]
        public void SetUp()
        {
           _door = Substitute.For<IDoor>();
           _alarm = Substitute.For<IAlarm>();
           _entryNotification = Substitute.For<IEntryNotification>();
           _userValidation = Substitute.For<IUserValidation>();
            _uut = new DoorControlClass(_alarm,_door,_entryNotification,_userValidation);
          
        }
     
        [Test]
        public void Alarm_RaiseAlarm_Called()
        {
         _uut.RaiseAlarm();
           _alarm.Received(1).RaiseAlarm();
        }

       [Test]
       public void DoorControl_RequestEntry_EntryGranted()
       {
          _userValidation.ValidateEntryRequest("12").Returns(true);
          _uut.RequestEntry("12");
          _door.Received(1).Open();
          _entryNotification.Received(1).NotifyEntryGranted();
       }

       [Test]
       public void DoorControl_RequestEntry_EntryDenied()
       {
          _userValidation.ValidateEntryRequest("ab").Returns(false);
          _uut.RequestEntry("ab");
          _entryNotification.Received(1).NotifyEntryDenied();
       }
   }
}
