namespace KoganCodingChallenge.Output
{
    using System;

    public class ConsoleOutputHandler : OutputHandler
    {
        public void OutputCubicWeight(float value)
        {
            Console.WriteLine($"{value}kg");
        }
    }
}