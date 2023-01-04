using ServiceLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class Fibonacci : IFibonacci
    {
        public void GetFibonacci(int[] arr, int n)
        {
            
            arr[0] = 0;
            arr[1] = 1;


            for (int i = 2; i <= n; i++)
            { 
                arr[i] = arr[i - 1] + arr[i - 2];


                Console.WriteLine(arr[i]);
            }
        }
    }
}
