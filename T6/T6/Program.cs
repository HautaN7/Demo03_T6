using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create cat
            Kissa kisu = new Kissa("Kisu");
            kisu.Age = 5;
            kisu.Color = "black";
            kisu.PrintData();
            Console.ReadLine();
        }
    }
}
