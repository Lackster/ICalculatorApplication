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

            for (int i = 0; i < 20; i++ )
            {
                info = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        int numberSS = Int32.Parse(info);
                        Console.Write(info);
                        i++;
                        break;
                    }

                    catch (InvalidCastException e)
                    {
                        Console.WriteLine(e.Message+ "Do you wish to continue? Y/N?");
                        
                        Console.ReadKey();

                    }
                }
            }

        }     
    }
}
