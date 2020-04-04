using System;
namespace lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            part1.Execute();
            Console.WriteLine("----------------------------------------------------------------------------------------\nPart 2");
            part2.Execute();
            Console.WriteLine("----------------------------------------------------------------------------------------\nPart 3");
            part3.Execute();
            Console.WriteLine("PRESS ANYTHING TO CLOSE THIS");
            Console.ReadKey(true);
        }
    }
}