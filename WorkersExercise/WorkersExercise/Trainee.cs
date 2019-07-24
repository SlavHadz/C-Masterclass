using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersExercise
{
    class Trainee: Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee ()
        {
            this.Name = "Trainee";
            this.FirstName = "Random";
            this.Salary = 0;
            this.WorkingHours = 20;
            this.SchoolHours = 20;
        }

        public Trainee(string name, string firstName, int salary, int workingHours, int schoolHours)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("{0} {1} is learning", FirstName, Name);
        }
    }
}
