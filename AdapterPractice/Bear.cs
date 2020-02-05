using System;
using System.Collections.Generic;
using System.Text;

/*
 *  Author: Danny Lillard
 *  Date: 2/5/2020
 *  Description: This file holds the interface for the Bear, GrizzlyBear will inherent from this.
 */
namespace AdapterPractice
{
    interface Bear
    {
        public void maul();
        public void hibernate();
    }
}
