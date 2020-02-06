using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPractice
{
/*
 *  Author: Danny Lillard
 *  Date: 2/5/2020
 *  Description: Class definition for GrizzlyBear, can maul and sleep.
 */
    class GrizzlyBear : Bear
    {
        public void maul()
        {
            Console.WriteLine("The bear mauls in the language of anger.");
        }
        
        public void hibernate()
        {
            Console.WriteLine("The bear sleeps a big sleep.");
        }
    }
}
