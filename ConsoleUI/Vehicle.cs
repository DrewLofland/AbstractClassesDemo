using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        { }

        public string Year { get; set; } = "default";
        public string Make { get; set; } = "default";
        public string Model { get; set; } = "default";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("default drive");
        }

        
       

    }
}
