namespace KoganCodingChallenge.Api.ApiModels
{
    using System.Collections.Generic;
    using Core.Models;

    public class ProductDto
    {
        public IEnumerable<Product> Objects { get; set; }
        public string Next { get; set; }
    }
}