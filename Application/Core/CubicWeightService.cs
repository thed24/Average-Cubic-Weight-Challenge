namespace KoganCodingChallenge.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public static class CubicWeightService
    {
        public static decimal CalculateAverageCubicWeightOf(IEnumerable<Product> products, string category)
        {
            var categorisedProducts = products.Where(p => p.Category.Equals(category));

            if (categorisedProducts.Any(p => p.Weight is null))
                throw new Exception($"{category} does not support cubic weight calculation.");

            var cubicWeights = categorisedProducts.Select(p => p.Size.AreaInMeters() * p.Weight);
            return cubicWeights.Average().Value;
        }
    }
}