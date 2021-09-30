using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkingdogs
{
    class Chihuahua : Ibark
    {
        public string Name { get; set; } = "Carlos";
        public string Color { get; set; } = "White";
        public string BarkSound { get; set; } = "Yap!";

        public string Bark()
        {
            return BarkSound;
        }
        public string Walk()
        {
            return "walking the dog";
        }
    }
}
