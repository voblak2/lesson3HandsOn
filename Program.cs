using System;

namespace lesson3HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Emily", "Harry", "Rupert", "Clara", "Lily", "Michael"};
            
            //Printing the array in forward order
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine("Have you seen " + names[i] + "?");
                }
                
            //Printing the array in reverse order
                for (int i = names.Length -1; i >= 0; i--)
                {
                    Console.WriteLine("Have you seen " + names[i] + "?");
                }

        }
    }
}