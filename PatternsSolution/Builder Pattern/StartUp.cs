using Builder_Pattern.Abstractions;
using Builder_Pattern.Implementations;
using System;

namespace Builder_Pattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Get the motorcycle product
            var motorCycleModel = new MotorcycleModel();
            //Give the creator the model and let it do its thing
            var motorcycleCreator = new VehicleBuilder(motorCycleModel);

            motorcycleCreator.CreateVehicle();
            motorcycleCreator.GetVehicle();

            //New car model
            var carBuilder = new CarModel();
            //New creator with the car model
            var carCreator = new VehicleBuilder(carBuilder);

            carCreator.CreateVehicle();
            carCreator.GetVehicle();
        }
    }
}
