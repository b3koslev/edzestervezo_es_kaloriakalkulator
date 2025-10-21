using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace edzestervezo_es_kaloriakalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            bool toName = false;
            int space_num = 0;
            bool space = false;
            double weight;
            
            while (true)
            {
                Console.Write("Név: ");
                name = Console.ReadLine();
                for (int i = 0; i < name.Length; i++)
                {
                    space_num = name.IndexOf(' ', 0);
                    if (space_num > 0)
                    {
                        space = true;
                    }
                }
                if (char.IsUpper(name[0]) && space && char.IsUpper(name[space_num + 1]))
                {
                    toName = true;
                    break;
                }
                else 
                { 
                    space = false;
                    Console.WriteLine("Hibás névformátum!");
                }
            }
            
            while (true)
            {
                Console.Write("Add meg a testsúlyodat (kg) [50-120]: ");
                if (double.TryParse(Console.ReadLine(), out weight) && weight >= 50 && weight <= 120)
                    break;
                else
                    Console.WriteLine("Hibás testsúly. Kérlek, adj meg egy valós számot 50 és 120 között!");
            }
            Console.WriteLine("Válassz edzéscélt:");
            Console.WriteLine("1. Állóképesség fejlesztése");
            Console.WriteLine("2. Izomtömeg növelése");
            Console.WriteLine("3. Fogyás");
            Console.Write("Add meg a cél számát (1-3): ");
            int goal = Convert.ToInt32(Console.ReadLine());

            string workoutType = string.Empty;
            int workoutDuration = 0;
            double calorieMultiplier = 0;

            if (goal == 1)
            {
                workoutType = "Állóképesség";
                workoutDuration = 45;
                calorieMultiplier = 0.12;
            }
            else if (goal == 2)
            {
                workoutType = "Izomtömeg növelése";
                workoutDuration = 60;
                calorieMultiplier = 0.10;
            }
            else if (goal == 3)
            {
                workoutType = "Fogyás";
                workoutDuration = 30;
                calorieMultiplier = 0.15;
            }
            else
            {
                Console.WriteLine("Hibás cél választás! Kérlek, válassz 1 és 3 között.");
                return;
            }

            Console.Write("Hány napot szeretnél edzeni?: ");
            int workoutDays = Convert.ToInt32(Console.ReadLine());
            double totalWorkoutTime = 0;

            for (int i = 0; i < workoutDays; i++)
            {
                int strengthlevel;
                while (true)
                {
                    Console.Write($"Add meg a(z) {i + 1}. edzésnap erősségi szintjét (1-5): ");
                    if (int.TryParse(Console.ReadLine(), out strengthlevel) && strengthlevel >= 1 && strengthlevel <= 5)
                    {
                        totalWorkoutTime += workoutDuration * strengthlevel;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hibás erősségi szint! Csak 1 és 5 közötti egész szám lehet.");
                    }
                }
            }

            double totalCaloriesBurned = weight * totalWorkoutTime * calorieMultiplier;

            Console.WriteLine();
            Console.WriteLine("Összegzés: ");

            Console.WriteLine($"\n{lastName} {firstName} edzésterve:");
            Console.WriteLine($"Edzés célja: {workoutType}");
            Console.WriteLine($"Teljes heti edzésidő: {totalWorkoutTime} perc");
            Console.WriteLine($"Összes elégetett kalória: {totalCaloriesBurned}");
        }
    }
}
