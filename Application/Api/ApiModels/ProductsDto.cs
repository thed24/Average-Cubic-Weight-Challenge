namespace KoganCodingChallenge.Api.ApiModels
{
	using System.Collections.Generic;
	using Core.Models;

	public class ProductsDto
	{
		public IEnumerable<Product> Products { get; set; }
		public string Next { get; set; }
	}
}
