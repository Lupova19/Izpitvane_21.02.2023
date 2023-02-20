using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int n = int.Parse(Console.ReadLine());
            int[] ocenki9d = (Console.ReadLine().Split().Select(int.Parse).ToArray());
            InputAvg();
            //PrintElements(ocenki9d);
            Console.WriteLine($"All elements: {ocenki9d}");


        }

        private static float InputAvg(int[] ocenki9d)
        {
            Console.WriteLine($"Avg= {ocenki9d.Average()}");
            return;
        }

        //private static void PrintElements(int[] index , int array)
        //{
        //    int result = 0;
        //    
        //}

        //private static float InputAvg(float[] ocenki9d)
        //{
        //    Console.WriteLine($"Avg= {ocenki9d.Average()}");
        //    return;
        //}
    }
}
