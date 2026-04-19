using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTasks
{
    internal class Student :Person
    {
        private double gpa {  get; set; }


        public double  Gpa { get { return gpa;  } set { gpa = value; } }

        public void printGpa()
        {
            Console.WriteLine($"The GPA is {gpa}");
        }
    }
}
