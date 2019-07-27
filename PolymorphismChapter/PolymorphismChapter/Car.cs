using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismChapter
{
    class Car
    {
        public string Color { get; set; }
        public string HP { get; set; }

        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int carId, string owner)
        {
            carIDInfo.IDNum = carId;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owner by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        public Car()
        {
            
        }

        public Car(string hp, string color)
        {
            this.Color = color;
            this.HP = hp;
        }

        public void ShowDetails()
        {
            Console.WriteLine("The car's HP is {0} and the color is {1}", this.HP, this.Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
