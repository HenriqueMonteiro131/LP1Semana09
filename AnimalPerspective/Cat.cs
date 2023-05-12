using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective 
{
    public class Cat : IMammal
    {
       public override string Sound()
        {
            NumberOfNipples = 8;
            return base.Sound() + "Miau";
        } 
    }
}