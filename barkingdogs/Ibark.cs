using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barkingdogs
{
    //Any class that implements this interface must have implement the Bark method.
    interface Ibark
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string BarkSound { get; set; }

        string Bark();
    }
}
