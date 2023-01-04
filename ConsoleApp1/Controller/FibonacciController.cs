using ServiceLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLayer.Controller
{
    public class FibonacciController
    {
        public void GetFibonacci()
        {
            Fibonacci controller = new();

            Console.WriteLine("Ededi daxil edin");
        Number: string n = Console.ReadLine();
            int checkedn;
            bool isParsen = int.TryParse(n, out checkedn);

            if (!isParsen)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ededi duzgun daxil edin");
                Console.ResetColor();
                goto Number;
            }

           
        }
    }
}
