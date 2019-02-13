using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Unit.Test
{
  public class UserValidationFake : IUserValidation
   {
      public bool ValidateEntryRequest(string s)
      {
         if (s == "a")
         {
            return true;
         }
         else
         {
            return false;
         }
      }
   }
}
