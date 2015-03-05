using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers;
            string info;
            int numberSS;

            for (int i = 0; i < 20; i++ )
            {
                info = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        numberSS = Int32.Parse(info);
                        Console.Write(info);
                        
                    }

                    catch (InvalidCastException e)
                    {
                        Console.WriteLine(e.Message+ "Do you wish to continue? Y/N?");
                        
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Y)
                        {
                            Console.WriteLine("Returning back now. . .");
                        }
                        else
                        {
                            return;
                        }
                      

                    }  i++;
                    numbers.Add(new int() { numberSS, i});
                        break;
                }
               
               
            }

        }     
    }
}
