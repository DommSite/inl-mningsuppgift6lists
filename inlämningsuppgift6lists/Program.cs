using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace inlämningsuppgift6lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in de varor du ska köpa");
            List <string> varor = new List<string> ();
            string[] varorr = Console.ReadLine().Split(" ");
            Console.WriteLine("Skriv in priset för varje vara");
            string[] pris = Console.ReadLine().Split(" ");

            Console.WriteLine("Skriv in din handlingslista");
            string[] antalvaror = Console.ReadLine().Split(" ");
            antalvaror.ToImmutableSortedDictionary();
            for (int i = 0; i < antalvaror.Length; i++) 
            {
                Console.WriteLine(antalvaror[i]);
            }
        }

        static string [] läsnamn()
        {
        string text = Console.ReadLine();
        string[] ord = text.Split(" ");
        return ord;
        }
    }


}