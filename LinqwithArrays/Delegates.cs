using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqwithArrays
{
    public delegate void Calculate(int a, int b);
    class Calci
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("sum is {0}", a + b);
        }
        public void Multiplication (int a, int b)
        {
            Console.WriteLine("Multiplication is {0}", (a * b));
        }
    }
    class delegates
    {
        static void Main()
        {
            Calci c = new Calci();
            c.Sum(5, 6);
            c.Multiplication(5, 6);
            //by delegates
            Calculate calculate1 = new Calculate(c.Sum);
            Calculate calculate2 = new Calculate(c.Multiplication);
            calculate1(8, 9);
            calculate2(2, 3);
            Console.Read();
            
        }
    }
}
