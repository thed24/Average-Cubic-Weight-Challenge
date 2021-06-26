namespace KoganCodingChallenge.Console
{
    using System;
    using Core.Interfaces;

    public class ConsoleOutputHandler : OutputHandler
    {
        public void OutputAverageCubicWeight(decimal value, string category)
        {
            Console.WriteLine($"Average Cubic Weight of all {category}: {value}kg");
        }
    }
}