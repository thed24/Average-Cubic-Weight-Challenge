namespace KoganCodingChallenge.Network
{
    using System.Collections.Generic;
    using Domain;

    public class ProductDto
    {
        public IEnumerable<Product> Objects { get; set; }
        public string Next { get; set; }
    }
}