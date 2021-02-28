using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern.BottleModels
{
    public class WaterBottle : Bottle
    {
        public WaterBottle(string material, int capacity, string name) 
            : base(material, capacity, name)
        {

        }
    }
}
