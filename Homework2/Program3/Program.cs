using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] A = new bool[101];
            A[0] = false;
            A[1] = false;
            for(int i=2;i<101; i++)
            {
                A[i] = true;
          
            }
            for(int i=2;i<Math.Sqrt(100);i++)
            {
                if(A[i]==true)
                {
                    for(int j=i;i*j<101;j++)
                    {
                        A[j*i] = false;
                    }
                }
            }
            Console.WriteLine("2到100的质数有：");
            for(int i=2;i<101;i++)
            {
                if(A[i]==true)
                {
                    Console.Write(i + "  ");
                }
            }
        }
    }
}
