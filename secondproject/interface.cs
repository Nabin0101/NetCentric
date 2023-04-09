using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondproject
{
    public interface living
    {
        //Interface//
        void WhatIEat();
        void WhatIBreathe();
    }
    public class Lion : living
    {
        public int legs { get; set; }
        public int hello { get; set; }
        public void WhatIEat()
        {
            Console.WriteLine("I eat Flesh");
        }
        public void WhatIBreathe()
        {
            Console.WriteLine("Hello");
        }
    }
}
