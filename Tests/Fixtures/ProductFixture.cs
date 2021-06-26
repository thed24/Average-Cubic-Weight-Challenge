namespace KoganCodingChallengeTests.Fixtures
{
    using System.Collections.Generic;
    using KoganCodingChallenge.Core.Models;

    public static class ProductFixture
    {
        internal static IEnumerable<Product> ProductsOfMultipleCategories => new List<Product>
        {
            new Product
            {
                Category = "Air Conditioners",
                Title = "Window Seal for Portable Air Conditioners",
                Weight = 235.0m,
                Size = new Size
                {
                    Width = 26.0m,
                    Length = 26.0m,
                    Height = 5.0m
                }
            },
            new Product
            {
                Category = "Air Conditioners",
                Title = "Kogan 12,000 BTU Portable Air Conditioner (3.5KW, Reverse Cycle)",
                Weight = 33500.0m,
                Size = new Size
                {
                    Width = 49.5m,
                    Length = 56.8m,
                    Height = 87.5m
                }
            },
            new Product
            {
                Category = "Gadgets",
                Title = "10 Pack Family Car Sticker Decals",
                Weight = 120.0m,
                Size = new Size
                {
                    Width = 15.0m,
                    Length = 13.0m,
                    Height = 1.0m
                }
            },
            new Product
            {
                Category = "Batteries",
                Title = "10 Pack Kogan CR2032 3V Button Cell Battery",
                Weight = 60.0m,
                Size = new Size
                {
                    Width = 5.8m,
                    Length = 19.0m,
                    Height = 0.3m
                }
            }
        };

        internal static IEnumerable<Product> ProductsWithCubicWeightExampleIncluded => new List<Product>
        {
            new Product
            {
                Category = "Air Conditioners",
                Title = "Window Seal for Portable Air Conditioners",
                Weight = 250.0m,
                Size = new Size
                {
                    Width = 30.0m,
                    Length = 40.0m,
                    Height = 20.0m
                }
            },
            new Product
            {
                Category = "Gadgets",
                Title = "10 Pack Family Car Sticker Decals",
                Weight = 120.0m,
                Size = new Size
                {
                    Width = 15.0m,
                    Length = 13.0m,
                    Height = 1.0m
                }
            },
            new Product
            {
                Category = "Batteries",
                Title = "10 Pack Kogan CR2032 3V Button Cell Battery",
                Weight = 60.0m,
                Size = new Size
                {
                    Width = 5.8m,
                    Length = 19.0m,
                    Height = 0.3m
                }
            }
        };
        
        internal static IEnumerable<Product> ProductsWithNullWeight => new List<Product>
        {
            new Product
            {
                Category = "Air Conditioners",
                Title = "Window Seal for Portable Air Conditioners",
                Weight = 250.0m,
                Size = new Size
                {
                    Width = 30.0m,
                    Length = 40.0m,
                    Height = 20.0m
                }
            },
            new Product
            {
                Category = "Gadgets",
                Title = "10 Pack Family Car Sticker Decals",
                Weight = null,
                Size = null
            },
            new Product
            {
                Category = "Batteries",
                Title = "10 Pack Kogan CR2032 3V Button Cell Battery",
                Weight = 60.0m,
                Size = new Size
                {
                    Width = 5.8m,
                    Length = 19.0m,
                    Height = 0.3m
                }
            }
        };
    }
}