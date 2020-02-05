using System;
using System.Collections.Generic;
using System.Text;

/*
 *  Author: Danny Lillard
 *  Date: 2/5/2020
 *  Description: This file holds the functionality of the TeddyBear.
 */
namespace AdapterPractice
{
    class TeddyBear : ToyBear
    {
        public void hug()
        {
            Console.WriteLine("The teddybear gives a hug in French.");
        }
    }
}
