using ServiceLayer.Helpers.Consts;
using ServiceLayer.Service;
using ServiceLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BaseLayer.Controller
{
    public class CalculateController
    {
        public static void GetCalculate()
        { 
            Calculate controller = new();

         Console.WriteLine("Add first number:");

            Number1: string num1 = Console.ReadLine();
            int checkedNum1;
            bool isParseNum1 = int.TryParse(num1, out checkedNum1);

            if (!isParseNum1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ResponseMessages.WrongNumber);
                Console.ResetColor();
                goto Number1;
            }

            Console.WriteLine("Add operation");
            string operation = Console.ReadLine();


            Console.WriteLine("Add second number");

             Number2: string num2 = Console.ReadLine();
            int checkedNum2;
            bool isParseNum2 = int.TryParse(num2,out checkedNum2);

            if (!isParseNum2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ResponseMessages.WrongNumber);
                Console.ResetColor();
                goto Number2;
            }

            if (checkedNum2 == 0  &&  operation == "/")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ResponseMessages.Error);
                Console.ResetColor();
                goto Number2;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result");
          

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(controller.GetCalculate(checkedNum1 , checkedNum2 , operation));
            Console.ResetColor();


        }
        
    }
}
