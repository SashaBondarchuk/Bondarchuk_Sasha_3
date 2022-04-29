using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 17, -5, 678, 51, 56, 65, -65, 2};
            List<int> list2 = new List<int>() { 1, 0, 5, 105, -56};

            Console.WriteLine("Count = " + list1.Where(x => x >= 10 && x <= 99).ToList().Count);

            try
            {
                Console.WriteLine(list2.Where(x => x >= 10 && x <= 99).ToList().Average()); //list 2
            }
            catch (Exception)
            {
                Console.WriteLine("Avarage = 0,0");
            }
        }
    }
}
