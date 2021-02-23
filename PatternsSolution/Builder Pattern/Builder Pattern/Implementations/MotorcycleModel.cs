using Builder_Pattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Implementations
{
    public class MotorcycleModel : IVehicleBuilder
    {
        private Vehicle _motorcycle;

        public MotorcycleModel()
        {
            this._motorcycle = new Vehicle();
        }
        public void GetVehicle()
        {
            this._motorcycle.Show();
        }

        public void SetDoors()
        {
            this._motorcycle.Doors = 0;
        }

        public void SetEngine()
        {
            this._motorcycle.Engine = "Very fast model";
        }

        public void SetFrame()
        {
            this._motorcycle.Frame = "Metalic";
        }

        public void SetVehicleType()
        {
            this._motorcycle.VehicleType = "Motorcycle";
        }

        public void SetWheels()
        {
            this._motorcycle.Wheels = 2;
        }
    }
}
