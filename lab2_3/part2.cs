using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3
{
    class part2
    {
        public static Dictionary<string, int> slave = new Dictionary<string, int>();
        static List<int> values = new List<int>();
        static public void GenerateNewSlave()
        {
            Random blessrng = new Random();
            string dictstring = "{";
            for (int i = 0; i< 6; i++)
            {
                string key = "item" + i;
                int value = blessrng.Next(0, 100000);
                slave.Add(key,value);
                dictstring += $"{key}:{value}, ";
            }
            Console.WriteLine(dictstring.TrimEnd(' ',',') + "}");

        }
       static public void GetValuesFrom(Dictionary<string,int> dict)
        {
           foreach (KeyValuePair<string,int> v in dict)
            {
                values.Add(v.Value);
            }
        }
        static public string GetKeyByValue(int value)
        {
            foreach (var recordOfDictionary in slave)
            {
                if (recordOfDictionary.Value.Equals(value))
                    return recordOfDictionary.Key;
            }
            return null;
        }
        static public void Execute()
        {
            GenerateNewSlave();
            GetValuesFrom(slave);
            List<KeyValuePair<string,int>> maxvalues = new List<KeyValuePair<string,int>>();
            for (int i = 0; i < 3; i++)
            {
                int vm = values.Max();
                maxvalues.Add(new KeyValuePair<string,int>(GetKeyByValue(vm),vm));
                values.Remove(vm);
            }
            foreach(KeyValuePair<string,int> kvp in maxvalues)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }
        }

    }
}
