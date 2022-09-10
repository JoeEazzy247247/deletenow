

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deletenow
{
    public class ForeEachTEst
    {
        public class student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        

        [Test]
        public void ForEachtest1()
        {
            var students = new List<student>();
            var student1 = new student()
            {
                 Name = "Joseph",
                 Age = 45
            };

            var student2 = new student()
            {
                Name = "Cath",
                Age = 34
            };
            students.Add(student1);
            students.Add(student2);
            students.ForEach(x =>
            {
                if (x.Age > 40)
                {
                    Console.WriteLine($"{x.Name} is above 40");
                    Assert.IsTrue(x.Name == "Joseph");
                }
            });
        }
    }
}
