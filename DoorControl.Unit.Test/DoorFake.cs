using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Unit.Test
{
   public class DoorFake : IDoor
   {
      public bool Tjek { get; set; }
      public void Open()
      {
         Tjek = true;
      }

      public void Close()
      {
         Tjek = false;
      }
   }
}
