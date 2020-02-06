using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPractice
{

/*
 *  Author: Danny Lillard
 *  Date: 2/5/2020
 *  Description: The bear adapter, turns a toy into a killer.
 */
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
