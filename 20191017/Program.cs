using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191017
{
    class Program
    {
        static void Main(string[] args)
        {
            int input=-1;
            int guess=55;


            while (true)
            {
                String input_str = Console.ReadLine();
                input = int.Parse(input_str);


                if (input==guess)
                {
                    Console.Write("恭喜你答對了!");
                    break;

                }

                Console.Write("猜錯了，再來一次!");
                    
            }


            Console.WriteLine("PAUSE");
            Console.ReadKey();
        }
    }
}
