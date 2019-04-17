using System;
using System.Collections.Generic;

namespace PredicateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> mylist = new List<int>() {1,2,3,4,5,6,7,8,9,10};

            int evenCount = mylist.Count(x => x % 2 == 0 );
            int unEvenCount = mylist.Count(x => x % 2 != 0 );
            
            Console.WriteLine($"Even = {evenCount}, Uneven = {unEvenCount}");
        }

    }
}
