using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersExercise
{
    class Boss: Employee
    {
        public string CompanyCar { get; set; }

        public Boss()
        {
            this.Name = "Boss";
            this.FirstName = "Random";
            this.Salary = 2;
            this.CompanyCar = "Lada";
        }

        public Boss(string name, string firstName, int salary, string companyCar)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("{0} {1} is leading!", FirstName, Name);
        }
    }
}
