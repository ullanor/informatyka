using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {                
                Console.WriteLine("0 - exit");
                Console.WriteLine("1 - addition");
                Console.WriteLine("2 - substraction");
                Console.WriteLine("3 - multiplication");
                Console.WriteLine("4 - division");
                int menuOption = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 0)
                    break;

                
            }
        }
    }
}
