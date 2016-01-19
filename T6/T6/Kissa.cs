using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Kissa
    {
        // properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Kissa(string name)
        {
            Name = name;
        }

        public void PrintData()
        {
            Console.WriteLine("Cat details: ");
            Console.WriteLine("-Name: " + Name);
            Console.WriteLine("-Age: " + Age);
            Console.WriteLine("-Color: " + Color);
        }
        
    }


}
