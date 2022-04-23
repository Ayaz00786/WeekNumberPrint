using System;
using System.Collections.Generic;
using System.Text;

namespace WeekNumberPrint
{
    internal class Class1
    {
        public static void weekprint()
        {
            Console.WriteLine("Enter Week Number:");
            int n= int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Monday");
                        break ;
                    }

                case 3:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }

                case 6:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }

                case 7:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid Week Number");
                        break;
                    }
            }
        }
    }
}
