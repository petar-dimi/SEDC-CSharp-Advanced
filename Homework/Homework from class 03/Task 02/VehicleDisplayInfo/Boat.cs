using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDisplayInfo
{
    public class Boat : Vehicle
    {
        // Implementing DisplayInfo for Boat
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a boat and I do not have wheels :(");
        }
    }
}
