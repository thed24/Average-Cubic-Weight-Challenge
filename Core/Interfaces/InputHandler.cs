namespace KoganCodingChallenge.Core.Interfaces
{
    using System.Collections.Generic;
    using Domain;

    public interface InputHandler
    {
        public List<Product> GetProducts();
    }
}