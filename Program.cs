//Script that convert nubers inside a string to integer
//then add only numbers to a empty list and write to screen
using System;
// To use List
using System.Collections.Generic;

namespace Sssert
{
    class Program
    {
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
            // Check if it can be convertible to int
            bool result;
            char[] b= a.ToCharArray();
            List<int> liste = new List<int> ();
            for (int i = 0; i < b.Length; i++)
            {
                result = Char.IsDigit(b[i]);
                if (result)
                {
                    // Convert char to int
                    int c = (int)Char.GetNumericValue(b[i]);
                    liste.Add(c);
                    
                }
            }
            //write the list
            foreach (var d in liste)
                {
                    Console.WriteLine(d);
                }

            Console.ReadLine();
        }
    }
}
