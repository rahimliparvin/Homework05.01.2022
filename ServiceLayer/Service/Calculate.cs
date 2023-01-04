using ServiceLayer.Helpers.Consts;
using ServiceLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class Calculate : ICalculate
    {
        public string GetCalculate(int num1, int num2, string operation)
        {
           double result = 0;

            switch(operation)
            {
                case "+":
                    result = num1+num2;
                    return result.ToString();

                case "-":
                    result = num1 - num2;
                    return result.ToString();

                case "*":
                    result = num1 * num2;
                    return result.ToString();

                case "/":
                    result = num1 / num2;
                    return result.ToString();

               default:
                    return ResponseMessages.WrongOperation;
                    

            }
        }
    }
}
