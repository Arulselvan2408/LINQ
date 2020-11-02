using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqwithArrays
{
    partial class Employee
    {
        public void GetData()
        {
            Console.WriteLine("get emp info");
        }
    }
    partial class Employee
    {
        public void Displaydata()
        {
            Console.WriteLine("get emp info");
        }
    }
       
    class partialEg
    {
        static void Main()
        {
            Employee e = new Employee();
            e.Displaydata();
            e.GetData();
            Console.Read();
        }
    }
}
