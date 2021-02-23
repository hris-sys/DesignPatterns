using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Abstractions
{
    public class VehicleBuilder
    {
        private IVehicleBuilder vehicleBuilder;

        public VehicleBuilder(IVehicleBuilder vehicleBuilder)
        {
            this.vehicleBuilder = vehicleBuilder;
        }

        public void CreateVehicle()
        {
            vehicleBuilder.SetVehicleType();
            vehicleBuilder.SetDoors();
            vehicleBuilder.SetEngine();
            vehicleBuilder.SetFrame();
            vehicleBuilder.SetWheels();
        }
        public void GetVehicle()
        {
            this.vehicleBuilder.GetVehicle();
        }

    }
}
