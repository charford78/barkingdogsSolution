using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkingdogs
{
    class Boxer : Ibark
    {
        public string Name { get; set; } = "Rocky";
        public string Color { get; set; } = "Tan";
        public string BarkSound { get; set; } = "Ruff!";

        public string Bark()
        {
            return BarkSound;
        }
    }
}
