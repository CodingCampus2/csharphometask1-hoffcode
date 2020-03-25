using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                int population = int.Parse(task.City.Population);
                float sickPercentage = float.Parse(task.City.SickPercentage);
                float killProbability = float.Parse(task.Virus.KillProbability);

                float sickPopulation = (float)population * sickPercentage;
                int sickPopulationInt = (int)Math.Truncate(sickPopulation);

                float diedPopulation = killProbability * sickPopulation;
                int diedPopulationInt = (int)Math.Truncate(diedPopulation);

                string result = $"There are {sickPopulationInt} people sick with {task.Virus.Name} in the city of {task.City.Name}, {diedPopulationInt} of which died";

                return result;
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
