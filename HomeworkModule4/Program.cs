using System;

namespace HomeworkModule4
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthnumber;

            Console.WriteLine("Enter your month number from 1 - 12 : ");
            monthnumber = Convert.ToInt32(Console.ReadLine());
            
            switch (monthnumber)
            {
                case 1:
                    Console.WriteLine("31 days!");
                    break;
                case 2:
                    Console.WriteLine("28 or 29 days!");
                    break;
                case 3:
                    Console.WriteLine("31 days!");
                    break;
                case 4:
                    Console.WriteLine("30 days!");
                    break;
                case 5:
                    Console.WriteLine("31 days!");
                    break;
                case 6:
                    Console.WriteLine("30 days!");
                    break;
                case 7:
                    Console.WriteLine("31 days!");
                    break;
                case 8:
                    Console.WriteLine("31 days!");
                    break;
                case 9:
                    Console.WriteLine("30 days!");
                    break;
                case 10:
                    Console.WriteLine("31 days!");
                    break;
                case 11:
                    Console.WriteLine("30 days!");
                    break;
                case 12:
                    Console.WriteLine("31 days!");
                    break;
                default:
                    Console.WriteLine("Invald input! You must eneter month number from 1 to 12! :)");
                    break;



            }
            
            Console.ReadLine();
        }
    }
}
