using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqwithArrays
{
    class Class1
    {
        
        static void Main()
        {
            List<student> Studetails = new List<student>();
            Studetails.Add(new student(101, "sri", "chennai", "male"));
            Studetails.Add(new student(102, "ram", "trichy", "male"));
            Studetails.Add(new student(103, "ramya", "bangalore", "female"));
            Studetails.Add(new student(104, "arun", "mumbai", "male"));
            Studetails.Add(new student(105, "geetha", "chennai", "female"));
            var res = from s in Studetails orderby s.City select s;
            foreach(var item in res)
            {
                Console.WriteLine(item.Rollno+" " +item.Name+" "+item.City+" "+item.Gender);
            }
            Console.Read();


        }

        
    }
}
