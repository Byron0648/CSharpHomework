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
            double a;
            double b;
            string c = "";
            Console.WriteLine("请输入一个数字");
            c = Console.ReadLine();
            a = double.Parse(c);
            Console.WriteLine("请输入另一个数字");
            c = Console.ReadLine();
            b = double.Parse(c);
            Console.WriteLine("两个数字的乘积是：" + (a * b));
        }
    }
}
