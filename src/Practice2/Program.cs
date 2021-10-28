using System;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter a charachter that you want to convert:  ");
            char x = char.Parse(Console.ReadLine());
            
            if (char.IsUpper(x))
            {
                x = char.ToLower(x);
                Console.WriteLine(x);
            }
               
                
            else
            {
                x = char.ToUpper(x);
                Console.WriteLine(x);
            }
            ////////////////////////////////////////////////
            Console.WriteLine("Enter your age in years:  ");
            int age=int.Parse(Console.ReadLine());
            age = age * 365 * 24 * 60;
            Console.WriteLine("your age in minutes is:{0}", age);
            /////////////////////////////////////////////////////////
            Console.WriteLine("Enter the first string that you want to concatenate:  ");
            string firstString=Console.ReadLine();
            Console.WriteLine("Enter the second string that you want to concatenate: ");
            string secondString = Console.ReadLine();
            string conctenatedString= string.Concat(firstString,secondString);
            Console.WriteLine("The concatenated string is:{0}", conctenatedString);
            /////////////////////////////////////////////////////////
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c= int.Parse(Console.ReadLine());
            int d= int.Parse(Console.ReadLine());
           





        }
    }
}
