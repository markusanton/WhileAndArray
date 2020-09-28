using System;
using System.Dynamic;
using System.Security.Claims;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shoppinglist = { "milk", "bread", "WC paper", "cookies", "pork" };

                int arrayLength = shoppinglist.Length;
            Console.WriteLine($"you have {arrayLength} items on your list");

            for (int i = 0; i < shoppinglist.Length; i++)
            {
                Console.WriteLine($"{i+1}. {shoppinglist[i]}");
                
            }

            Console.WriteLine($"the first item on your list is {shoppinglist[0]}");
            Console.WriteLine($"the last item on your list is{shoppinglist[5]}");



        }
    }
}
