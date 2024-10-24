using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisplayInfo
{
    public class Airplane : Vehicle
    {
        // Implementing DisplayInfo for Airplane
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a plane and I have a winds and wheels :P");
        }
    }
}
