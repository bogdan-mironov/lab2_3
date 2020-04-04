using System;
using System.Collections.Generic;
using System.IO;


namespace lab2_3
{
    class part1
    {
        static List<int> AOSinfo = new List<int>();
        public static void Execute()
        {
        mark:
            Console.WriteLine("PASTE HERE THE FILEPATH: ");
            string filepath = Console.ReadLine();
            StreamReader fileslave;
            try
            {
                fileslave = new StreamReader(filepath);
            }
            catch (Exception)
            {
                goto mark;
            }
            int amount_of_symbols = 0;
            bool isEndofFile = false;
            while (isEndofFile == false)
            {
                string line = fileslave.ReadLine();
                amount_of_symbols = LineslaveCount(line);
                if (amount_of_symbols == -1)
                {
                    isEndofFile = true;
                    continue;
                }
                AOSinfo.Add(amount_of_symbols);
            }
            string output = "";
            foreach (int AOS in AOSinfo)
            {
                output += $"{AOS}, ";
            }
            Console.WriteLine(output.TrimEnd(',', ' '));
        }
        public static int LineslaveCount(string line)
        {
            if (line == null)
            {
                return -1;
            }
            int amount_of_symbols;
            amount_of_symbols = line.Length;
            return amount_of_symbols;
        }
    }
}
