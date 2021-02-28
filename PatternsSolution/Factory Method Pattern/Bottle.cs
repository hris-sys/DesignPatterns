using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    public abstract class Bottle
    {
        protected Bottle(string material, int capacity, string name)
        {
            this.Material = material;
            this.Capacity = capacity;
            this.Name = name;
        }

        public string Material { get; set; }

        public int Capacity { get; set; }

        public string Name { get; set; }
    }
}
