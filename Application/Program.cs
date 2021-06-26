namespace KoganCodingChallenge
{
    using Api;
    using Console;
    using Core;
    using Core.Interfaces;

    internal class Program
    {
        private static readonly OutputHandler OutputHandler = new ConsoleOutputHandler();
        private static readonly InputHandler InputHandler = new ApiInputHandler();

        public static void Main()
        {
            var products = InputHandler.GetProducts();
            var averageCubicWeightOfAirConditioners = CubicWeightService.CalculateAverageCubicWeightOf(products, "Air Conditioners");
            OutputHandler.OutputAverageCubicWeight(averageCubicWeightOfAirConditioners, "Air Conditioners");
        }
    }
}