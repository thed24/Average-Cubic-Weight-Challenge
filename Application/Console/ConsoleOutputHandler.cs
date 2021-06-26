namespace KoganCodingChallenge.Console
{
    using System;
    using Output;

    public class ConsoleOutputHandler : OutputHandler
    {
        public void OutputCubicWeight(decimal value)
        {
            Console.WriteLine($"{value}kg");
        }
    }
}