using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Abstractions
{
    public class Vehicle
    {
        public string VehicleType { get; set; }

        public string Frame { get; set; }

        public string Engine { get; set; }

        public int Wheels { get; set; }

        public int Doors { get; set; }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Vehicle Type: {this.VehicleType}");
            Console.WriteLine($" Frame : {this.Frame}");
            Console.WriteLine($" Engine : {this.Engine}");
            Console.WriteLine($" Number of wheels: {this.Wheels}");
            Console.WriteLine($" Number of doors : {this.Doors}");
        }
    }
}
