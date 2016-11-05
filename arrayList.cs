//A C# program designed to initialize and print out double values in an array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[20];
            for (int i =0; i<20; i++)
            {
                numbers[i] = Math.Pow(i, i);
            }

            for (int i=0; i<20; i++)
            {
                System.Console.WriteLine("Numbers[" + i + "] = " + numbers[i]);
            }

            System.Console.ReadLine();
        }
    }
}
