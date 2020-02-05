using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPractice
{
    class BearAdapter : TeddyBear
    {
        public BearAdapter(Bear b)
        {
            b = new GrizzlyBear();
        }
        public void hug()
        {
            Bear ourBear = new GrizzlyBear();
            ourBear.maul();
        }
    }
}
