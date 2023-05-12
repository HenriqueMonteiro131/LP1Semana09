using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective 
{
    public class Dog: IMammal
    {
        public override string Sound()
        {
            NumberOfNipples = 10;
            return base.Sound() + "Woof!";
        }
    }
}