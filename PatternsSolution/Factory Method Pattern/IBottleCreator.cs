using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    public interface IBottleCreator
    {
        public abstract Bottle CreateBottle();
    }
}
