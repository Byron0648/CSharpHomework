using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            int sum = 0;
            Console.Write("请输入数组长度：");
            int.TryParse(Console.ReadLine(), out i);
            int[] A = new int[i];
            Console.WriteLine("请输入数组内容：");
            for(int j=0;j<i;j++)
            {
                A[j]=int.Parse(Console.ReadLine());
            }
            int max = A[0];
            int min = A[0];
            for (int j=0;j<i;j++)
            {
                if (A[j] > max) max = A[j];
                if (A[j] < min) min = A[j];
                sum += A[j];

            }
            int aver=sum/i ;
            Console.WriteLine("该数组最大元素是："+max);
            Console.WriteLine("该数组最小元素是："+min);
            Console.WriteLine("该数组的和是：" + sum);
            Console.WriteLine("该数组的平均数是：" + aver);
        }
    }
}
