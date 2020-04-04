using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    class part3
    {
        //static List<int> intlist = new List<int>();
        static IEnumerable<int> intlist;
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
            intlist =  Enumerable.Range(-10, 30);
            string omg = "";
            foreach(int  number in intlist)
            {
                omg += $"{number},";
            }
            Console.WriteLine(omg.TrimEnd(',',' '));
        }
    }
}
