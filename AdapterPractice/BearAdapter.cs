using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPractice
{
    class BearAdapter : ToyBear
    {
        public Bear ourBear;
        public BearAdapter(Bear b)
        {
            ourBear = b;
        }
        public void hug()
        {
            ourBear.maul();
        }
    }
}
