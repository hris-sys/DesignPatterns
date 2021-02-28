using Factory_Method_Pattern.BottleModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern.BottleCreators
{
    public class CocaColaCreator : IBottleCreator
    {
        public Bottle CreateBottle()
        {
            return new CocaCola("Aluminium", 750, "Coca Cola");
        }
    }
}
