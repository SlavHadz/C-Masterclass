using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "First 296", "Two 293", "Third 200" };

            File.WriteAllLines(@"C:\Users\Stanislav\QA\tutorials\C#\C-Masterclass\Assets\highscores.txt", lines);

            //Method 2
            //Console.WriteLine("Please enter the file name");
            //string filename = Console.ReadLine();
            //Console.WriteLine("Please enter the file text");
            //string input = Console.ReadLine();
            //File.WriteAllText(@"C:\Users\Stanislav\QA\tutorials\C#\C-Masterclass\Assets\" + filename + ".txt", input);

            //Method 3
            using(StreamWriter file = new StreamWriter(@"C:\Users\Stanislav\QA\tutorials\C#\C-Masterclass\Assets\myText2.txt"))
            {
                foreach(string line in lines)
                {
                    if(line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"C:\Users\Stanislav\QA\tutorials\C#\C-Masterclass\Assets\myText2.txt", true))
            {
                file.WriteLine("Additional line");
            }

            ////Example 1 Reading text
            //string text = System.IO.File.ReadAllText(@"C:\Users\Stanislav\QA\tutorials\C#\C-Masterclass\Assets\HelloWorld.txt");

            //Console.WriteLine("Textfile contains the following text: {0}", text);

            //// Example 2 Reading lines

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Stanislav\QA\tutorials\C#\C-Masterclass\Assets\HelloWorld.txt");
            //Console.WriteLine("The textfile contains the following text: ");
            //foreach(string line in lines)
            //{
            //    Console.WriteLine("\t" + line);
            //}

            Console.ReadKey();
        }
    }
}
