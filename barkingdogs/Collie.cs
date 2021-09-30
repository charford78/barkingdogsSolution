using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkingdogs
{
    class Collie : Ibark
    {
        public string Name { get; set; } = "Doggo";
        public string Color { get; set; } = "Red, White";
        public string BarkSound { get; set; } = "Woof!";

        public string Bark()
        {
            return BarkSound;
        }
    }
}
