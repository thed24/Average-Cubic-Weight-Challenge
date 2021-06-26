namespace KoganCodingChallengeTests.Core
{
    using System;
    using Fixtures;
    using FluentAssertions;
    using KoganCodingChallenge.Core;
    using Xunit;

    public class CubicWeightServiceTests
    {
        [Fact]
        public void GivenListOfProducts_ShouldCalculateCubicWeightCorrectly()
        {
            const decimal expected = 6.0m;
            var exampleProduct = ProductFixture.ProductsWithCubicWeightExampleIncluded;

            var result = CubicWeightService.CalculateAverageCubicWeightOf(exampleProduct, "Air Conditioners");

            result.Should().Be(expected);
        }

        [Fact]
        public void GivenListOfProducts_WhenCategoryIsAirConditioner_ShouldCalculateCubicWeightOfOnlyAirConditionerProducts()
        {
            const decimal expected = 4121.1484m;
            var products = ProductFixture.ProductsOfMultipleCategories;

            var result = CubicWeightService.CalculateAverageCubicWeightOf(products, "Air Conditioners");

            result.Should().Be(expected);
        }
        
        [Fact]
        public void GivenListOfProducts_WhenCategoryIsIncludesProductsWithNullWeight_ShouldThrowException()
        {
            var products = ProductFixture.ProductsWithNullWeight;

            Action serviceInvocation = () => CubicWeightService.CalculateAverageCubicWeightOf(products, "Gadgets");

            serviceInvocation.Should().Throw<Exception>().WithMessage("Gadgets does not support cubic weight calculation.");        
        }
    }
}