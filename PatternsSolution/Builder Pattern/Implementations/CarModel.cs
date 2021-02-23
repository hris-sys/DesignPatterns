using Builder_Pattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Implementations
{
    public class CarModel : IVehicleBuilder
    {
        private Vehicle vehicle;

        public CarModel()
        {
            this.vehicle = new Vehicle();
        }

        public void SetDoors()
        {
            this.vehicle.Doors = 4;
        }

        public void SetEngine()
        {
            this.vehicle.Engine = "Electric";
        }

        public void SetFrame()
        {
            this.vehicle.Frame = "Metalic";
        }

        public void SetWheels()
        {
            this.vehicle.Wheels = 4;
        }

        public void GetVehicle()
        {
            this.vehicle.Show();
        }

        public void SetVehicleType()
        {
            this.vehicle.VehicleType = "Car";
        }
    }
}
