using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqwithArrays
{
    class ISO
    {

    }
    sealed class  Organization:ISO// sealed classes cannot be inherited. means sealed classes cannot haved derived class
        //but sealed class can inherit other class. i.e sealed class can have parent class but not child class.
    {
        public void Orgname()
        {
            Console.WriteLine("LTI");
            Console.WriteLine("Larsen and tourbo information technology");
        }
        public void Location()
        {
            Console.WriteLine("Location is Chennai");
        }
    }
    class Employees
    {
        public void EMPdetails()
        {
            Console.WriteLine("Ename");
        }

    }
    class SealedEg
    {
    }
}
