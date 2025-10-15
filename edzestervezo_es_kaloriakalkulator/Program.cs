using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edzestervezo_es_kaloriakalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Név: ");
            string[] name = Console.ReadLine().Split(' ');
            Console.Write("Testsúly: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Edzés célja: ");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Állóképesség");
            Console.WriteLine("2. Izomtömeg növelés");
            Console.WriteLine("3. Fogyás");
        }
    }
}
