using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Abstractions
{
    public interface IVehicleBuilder
    {
        public void SetFrame();

        public void SetEngine();

        public void SetWheels();

        public void SetDoors();
        public void SetVehicleType();

        public void GetVehicle();

    }
}
