using System;

namespace AdapterPractice
{
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
