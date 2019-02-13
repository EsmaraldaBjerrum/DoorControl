using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DoorControl;

namespace DoorControl.Unit.Test
{
   [TestFixture]
    public class DoorControlUnitTest
    {
        
       
       private AlarmFake _alarm = new AlarmFake();
        private DoorControlClass _uut;
        private DoorFake doorFake;
        private UserValidationFake userValidationFake;

        [SetUp]
        public void SetUp()
        {
            _uut = new DoorControlClass(_alarm);
            doorFake = new DoorFake();
            userValidationFake = new UserValidationFake();
        }
     
        [Test]
        public void Alarm_RaiseAlarm_Called()
        {
            _uut.RaiseAlarm();
            Assert.That(_alarm.);
        }
   
       [Test]
       public void 
      
   }
}
