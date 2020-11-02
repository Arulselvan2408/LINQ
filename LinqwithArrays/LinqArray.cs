using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqwithArrays
{
    class student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        internal student(int Rollno, string Name, string City, string Gender)
        {
            this.Rollno = Rollno;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;

        }
    }
        class LinqArray
        {
            static int[] Marks = { 50, 65, 75, 82, 99, 86, 75, 100, 42 };
            static void IntegerArray()
            {
                Console.WriteLine("Maximum Marks={0}", Marks.Max());
                Console.WriteLine("Minimym Marks={0}", Marks.Min());
                var marray = from m in Marks where m > 70 && m < 100 select m;
                foreach (var m in marray)
                {
                    Console.WriteLine(m);
                }
                // no of students marks btw 70 and 100
                int marray1 = (from m in Marks where m > 70 && m > 100 select m).Count();
                Console.WriteLine("Number of Students: {0}", marray1);

            }
        void ListEg()
        {
            List<student> stu = new List<student>();
            stu.Add(new student(101, "sri", "chennai", "male"));
            stu.Add(new student(102, "ram", "trichy", "male"));
            stu.Add(new student(103, "ramya", "bangalore", "female"));
            stu.Add(new student(104, "arun", "mumbai", "male"));
            stu.Add(new student(105, "geetha", "chennai", "female"));
            var studetails = from s in stu where s.City.Equals("chennai") select s;
            foreach(var st in studetails)
            {
                Console.WriteLine(st.Rollno+" "+st.Name+" "+st.City);
            }
            //select name and city from studetails
            var studetails1 = from s in stu
                             where s.City.Equals("chennai")
                             select new { n = s.Name, c = s.City };
            foreach(var item in studetails1)
            {
                Console.WriteLine(item.n+" "+item.c);
            }
        }
        void OrderBy_groupbyEg()
        {
            List<student> stu = new List<student>();
            stu.Add(new student(101, "sri", "chennai", "male"));
            stu.Add(new student(102, "ram", "trichy", "male"));
            stu.Add(new student(103, "ramya", "bangalore", "female"));
            stu.Add(new student(104, "arun", "mumbai", "male"));
            stu.Add(new student(105, "geetha", "chennai", "female"));
            IEnumerable<student> st = from s in stu
                                      orderby s.Gender, s.Name
                                      select s;
          
            foreach(var stud in st)
            {
                Console.WriteLine("{0}  {1}  {2}", stud.Name, stud.City, stud.Gender);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Number of males and Females");
            var gendercount = from s in stu
                              group s by s.Gender;
            foreach(var g in gendercount)
            {
                Console.WriteLine(g.Key + " "+g.Count());
            }

        }
            static void Main()
            {
            /* string[] books = { "English", "tamil", "Java", ".Net", "Cloud Computing", "grid computing" };
             //fetching data from book array
             var res = from b in books
                       select b;
             foreach(var bname in res)
             {
                 Console.WriteLine(bname); 
             }
             var iobj = from bo in books
                     where bo.Contains("Computing")
                     select bo;
             foreach(var bo in iobj)
             {
                 Console.WriteLine(bo);
             }
             Console.Read();*/
            //LinqArray.IntegerArray();
            LinqArray lin = new LinqArray();
            //lin.ListEg();
            lin.OrderBy_groupbyEg();
            Console.Read();

            }
        }

}
