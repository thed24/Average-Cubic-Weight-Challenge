namespace KoganCodingChallenge.Core.Models
{
    public class Product
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public decimal? Weight { get; set; }
        public Size Size { get; set; }
    }
}