using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern.BottleModels
{
    public class CocaCola : Bottle
    {
        public CocaCola(string material, int capacity, string name) 
            : base(material, capacity, name)
        {
        }
    }
}
