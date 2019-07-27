using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaC
{
    class Program
    {
        public delegate int SomeMath(int i);
        public delegate bool Compare(int a, Number n);

        static void Main(string[] args)
        {
            DoSomething();
            Console.Read();
        }

        public static void DoSomething()
        {
            SomeMath math = new SomeMath(Square);
            Console.WriteLine(math(8));

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            List<int> listEven = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });

            foreach(int even in listEven)
            {
                Console.WriteLine(even);
            }

            List<int> listOdd = list.FindAll(i => i % 2 == 1);
            listOdd.ForEach(i => 
            {
                Console.WriteLine("Odd number:");
                Console.WriteLine(i);
            });

            math = new SomeMath(x => x * x);
            Console.WriteLine(math(8));

            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp(6, new Number { n = 5 }));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Square(int i)
        {
            return i * i;
        }

        public static int TimesTen(int i)
        {
            return i * 10;
        }
    }

    public class Number
    {
        public int n { get; set; }
    } 
}
