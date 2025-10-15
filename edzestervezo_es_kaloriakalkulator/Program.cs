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
            string lastName = name[0];
            string firstName = name[1];
            Console.Write("Testsúly: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Edzés célja: ");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Állóképesség");
            Console.WriteLine("2. Izomtömeg növelés");
            Console.WriteLine("3. Fogyás");

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
                workoutType = "Izomtömeg növelés";
                workoutDuration = 60;
                calorieMultiplier = 0.1;
            }
            else if (goal == 3)
            {
                workoutType = "Fogyás";
                workoutDuration = 30;
                calorieMultiplier = 0.15;
            }
            else
            {
                workoutType = "Érvénytelen cél";
                workoutDuration = 0;
            }

            Console.Write("Hány napot szeretnél edzeni?: ");
            int workoutDays = Convert.ToInt32(Console.ReadLine());

            int strengthlevel = 1;

            double totalWorkoutTime = 0;

            for (int i = 1; i <= workoutDays; i++)
            {
                Console.Write($"{i}. edzésnap erősségi szintje (1-5): ");
                while (strengthlevel < 1 || strengthlevel > 5)
                {
                    strengthlevel = Convert.ToInt32(Console.ReadLine());
                }
                double dailyWorkoutTime = workoutDuration * (1 + 0.1 * strengthlevel);
                totalWorkoutTime += dailyWorkoutTime;
            }

            double totalCaloriesBurned = weight * totalWorkoutTime * calorieMultiplier;
        }
    }
}
