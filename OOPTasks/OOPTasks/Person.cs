using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTasks
{
    internal class Person
    {

        public string Name { get; set; }
        private int age;

        public void printPersonInfo()
        {
            Console.WriteLine($"The name is {Name} and the age is {age}");
        }

        public int Age { get { return age; } set { age = value; } }
    }
}
