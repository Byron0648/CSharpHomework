using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int n;
            Console.WriteLine("请输入一个正整数");
            string s = Console.ReadLine();
            n = int.Parse(s);

            Console.WriteLine(n+"的质因数有");
            while (n>0)
            {
                
                if(n%i==0)
                {
                    Console.Write(i + "  ");
                    n /= i;
                }
                else
                {
                    i++;
                }    

            }
           


         }
    }
}
