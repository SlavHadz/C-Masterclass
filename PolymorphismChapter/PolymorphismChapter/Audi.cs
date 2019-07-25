using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChapter
{
    class Audi: Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi (string hp, string color, string model)
        {
            this.HP = hp;
            this.Color = color;
            this.Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("The car's HP is {0} and the color is {1}. Brand: {2} Model: {3}", this.HP, this.Color, this.brand, this.Model);
        }

        public override void Repair()
        {
            Console.WriteLine("Audi is repaired!");
        }
    }
}
