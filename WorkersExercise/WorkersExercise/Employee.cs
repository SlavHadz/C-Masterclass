using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersExercise
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        //default contructor
        public Employee() {
            this.Name = "Worker";
            this.FirstName = "Random";
            this.Salary = 1;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("{0} {1} is working!", FirstName, Name);
        }

        public void Pause()
        {
            Console.WriteLine("{0} {1} took a brake.", FirstName, Name);
        }
    }
}
