using Factory_Method_Pattern.BottleModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern.BottleCreators
{
    public class WaterBottleCreator : IBottleCreator
    {
        public Bottle CreateBottle()
        {
            return new WaterBottle("Plastic", 500, "Water Bottle");
        }
    }
}
