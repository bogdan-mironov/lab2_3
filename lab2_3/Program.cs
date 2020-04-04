using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PASTE HERE THE FILEPATH: ");
            string filepath =Console.ReadLine();
            x1.Execute(filepath);
            Console.WriteLine("TYPE ANYTHING TO CLOSE THIS");
            Console.ReadKey(true);
        }
    }

    class x1
    {
        
        static List<int> AOSinfo = new List<int>();
        public static  void Execute(string filepath)
        {
            using (StreamReader fileslave = new StreamReader(filepath))
            {
                int amount_of_symbols = 0;
                bool isEndofFile = false;
                while (isEndofFile == false)
                {
                    string line = fileslave.ReadLine();
                    amount_of_symbols = Lineslave.LineslaveCount(line);
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
        }
    }
    class Lineslave
    {
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
