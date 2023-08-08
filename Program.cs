using System;

namespace PopulationGrowth
{
    static class Constant
    {
        public const int minPopulation = 9;
    }

    class Program
    {
        static void Main()
        {
            int startSize = GetInput("Start size: ", Constant.minPopulation);
            
            if (startSize == -1) { throw new InvalidProgramException("Wrong start size value!"); }


            int endSize = GetInput("End size: ", startSize);

            if (endSize == -1) { throw new InvalidProgramException("Wrong end size value!"); }

            int yearsOfGrowth = CalculateGrowthInYears(startSize, endSize);

            Console.WriteLine("Years: " + yearsOfGrowth);
        }

        static int GetInput(string message, int limit)
        {
            int number = 0;
            int tryes = 10;

            do
            {
                Console.Write(message);

                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }

                --tryes;

            } while (number <= limit && tryes > 0);

            if (tryes == 0) { return -1; }

            return number; 
        }

        static int CalculateGrowthInYears(int beginPopulation, int endPopulation)
        {
            int number = 0;

            do
            {
                beginPopulation += (beginPopulation / 3) - (beginPopulation / 4);

                ++number;

            } while (endPopulation > beginPopulation);

            return number;          
        }
    }
}

