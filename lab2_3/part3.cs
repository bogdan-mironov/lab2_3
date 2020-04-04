using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    class part3
    {
        static List<int> intlist = new List<int>();
        
        static public void Execute()
        {
            GenerateNewIntList();
            IEnumerable<int> minnumber = from t in intlist
                                  where t > 0
                                  orderby t
                                  select t;
            Console.WriteLine(minnumber.FirstOrDefault());
        }
        static public void GenerateNewIntList()
        {
            Random blessrng = new Random();
            string omg = "";
            for (int i = 0; i < blessrng.Next(10, 50); i++)
            {
                int blessednumber = blessrng.Next(-1000, 10000);
                intlist.Add(blessednumber);
                omg += $"{blessednumber}, ";
            }
            Console.WriteLine(omg.TrimEnd(',',' '));
        }
    }
}
