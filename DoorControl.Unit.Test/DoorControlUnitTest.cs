using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DoorControl.Unit.Test
{
   [TestFixture]
    public class DoorControlUnitTest
   {
      private IDoor doorFake;
      private IUserValidation userValidationFake;

      [SetUp]
      public void Setup()
      {
         doorFake = new DoorFake();
         userValidationFake = new UserValidationFake();

         doorFake.
      }
   }
}
