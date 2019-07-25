using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi("200", "blue", "A4"),
                new BMW("300", "black", "M3")
            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            Car bmw = new BMW("200", "red", "Z3");
            Car audi = new Audi("300", "green", "A3");

            bmw.ShowDetails();
            audi.ShowDetails();

            BMW bmw2 = new BMW("200", "blue", "M3");
            bmw2.ShowDetails();

            Car bmw2Double = (Car)bmw2;

            bmw2Double.ShowDetails();

            Console.ReadKey();
        }
    }
}
