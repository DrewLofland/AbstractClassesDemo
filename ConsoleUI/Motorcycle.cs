﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle() { }
        
        public bool HasSideCar { get; set; }
        
        public override void DriveAbstract()
        {
            Console.WriteLine("drives fast");
        }

        public override void DriveVirtual()
        {
            
        }
    }
}
