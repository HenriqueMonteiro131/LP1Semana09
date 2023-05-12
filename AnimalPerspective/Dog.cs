using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Dog
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}