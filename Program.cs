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
            int startSize = 0;

            do
            {
                Console.Write("Start size: ");

                try
                {
                    startSize = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }

            } while (startSize < Constant.minPopulation);


            int endSize = 0;

            do
            {
                Console.Write("End size: ");

                try
                {
                    endSize = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }

            } while (endSize >= startSize);
        }
    }
}

