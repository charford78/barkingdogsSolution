using System;
using System.Collections.Generic;

namespace barkingdogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<Ibark>()
            {
                new Collie(),
                new Boxer(),
                new Chihuahua()
            };
            foreach (var dog in dogs)
            {
                Console.WriteLine($"The dog {dog.Name} barks like this, {dog.Bark()}");
                var chawawa = dog as Chihuahua;
                if(chawawa != null)
                {
                    Console.WriteLine($"Walking chawawa {chawawa.Walk()}");
                }

            }
        }
    }
}
