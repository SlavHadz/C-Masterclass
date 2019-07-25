using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChapter
{
    class BMW: Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW (string hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("The car's HP is {0} and the color is {1}. Brand: {2} Model: {3}", this.HP, this.Color, this.brand, this.Model);
        }

        public override void Repair()
        {
            Console.WriteLine("BMW is repaired!");
        }
    }
}
