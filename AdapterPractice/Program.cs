using System;

namespace AdapterPractice
{

/*
 *  Author: Danny Lillard
 *  Date: 2/5/2020
 *  Description: The driver for adapter practice, runs through all possibilities of bears.
 */
    class Program
    {
        static void Main(string[] args)
        {
            Bear beets = new GrizzlyBear();
            ToyBear battlestar = new TeddyBear();
            ToyBear galatica = new BearAdapter(beets);

            Console.WriteLine("BEAR:");
            beets.maul();
            beets.hibernate();

            Console.WriteLine();
            
            Console.WriteLine("TEDDY BEAR:");
            battlestar.hug();

            Console.WriteLine();

            Console.WriteLine("ADAPTER BEAR:");
            galatica.hug();
        }
    }
}
