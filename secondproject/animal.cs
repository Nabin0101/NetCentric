using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondproject
{
     public abstract  class animal
    {
        //Dynamic Polymorphsim//
        public abstract void WhatIEat();
        public void WhatIBreathe()
        {
            Console.WriteLine("I breathe Oxygen");
        }
    }
    public class Tiger: animal
    {
        public override void WhatIEat() {
            Console.WriteLine("I eat Flesh");
        }
    }
}
