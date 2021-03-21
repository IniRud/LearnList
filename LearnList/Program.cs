using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<double> marathons = new List<double>{ 12.32, 34.12, 98.01, 56.55};

            //double time = marathons[1];
            //double time = marathons.Count;
            //bool time = marathons.Contains(12.32);
            //bool time = marathons.Remove(12.32);
            //marathons.Clear();

            //Console.WriteLine($"The time spent is {time} hours");
            //Console.WriteLine($" Count: {marathons.Count}");

            double[] firstStage = new double[] {11.23, 32.10, 45.03 };
            double[] secondStage = new double[] { 55.55, 99.91};

            List<double> winTime = new List<double>();

            winTime.AddRange(firstStage);
            winTime.InsertRange(0, secondStage);

            foreach(double wins in winTime)
            {
                Console.WriteLine(wins);
            }
            //winTime.RemoveRange(1,3);
            //Console.WriteLine($" Count: {winTime.Count}");
            Console.ReadKey();
        }
    }
}
