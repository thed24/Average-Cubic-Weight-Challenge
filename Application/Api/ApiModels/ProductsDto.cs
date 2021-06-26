namespace KoganCodingChallenge.Api.ApiModels
{
	using System.Collections.Generic;
	using Core.Models;
	using Newtonsoft.Json;

	public class ProductsDto
	{
		[JsonProperty("objects")]
		public IEnumerable<Product> Products { get; set; }
		[JsonProperty("next")]
		public string NextPageId { get; set; }
	}
}
