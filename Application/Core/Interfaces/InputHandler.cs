namespace KoganCodingChallenge.Core.Interfaces
{
    using System.Collections.Generic;
    using Models;

    public interface InputHandler
    {
        public List<Product> GetProducts();
    }
}