using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 17, -5, 678, 51, 56, 65, -65, 2 };
            List<int> list2 = new List<int>() { 10, 178, -54, 6, 1, 56, 75, -5, 200 };

            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            foreach (var item in list1)
            {
                dict.Add(item, list2);
            }
            SerealizeObj(dict);
        }
        static void SerealizeObj(Dictionary<int, List<int>> dictionary)
        {
            var jsonOut = Newtonsoft.Json.JsonConvert.SerializeObject(dictionary);
            var pathOut = Path.Combine(Environment.CurrentDirectory, "jsonOut.txt");
            File.WriteAllText(pathOut, jsonOut);
        } 
    }
}