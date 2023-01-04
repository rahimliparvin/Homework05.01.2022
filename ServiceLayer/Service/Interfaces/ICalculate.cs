using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interfaces
{
    public interface ICalculate
    {
        public  string  GetCalculate(int num1 ,int num2, string operation);
    }
}
