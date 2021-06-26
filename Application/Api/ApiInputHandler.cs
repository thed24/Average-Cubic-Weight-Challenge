namespace KoganCodingChallenge.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using ApiModels;
    using Core.Interfaces;
    using Core.Models;
    using Newtonsoft.Json;

    public class ApiInputHandler : InputHandler
    {
        private static readonly HttpClient Client = new HttpClient();
        private readonly Uri endpoint = new Uri("http://wp8m3he1wt.s3-website-ap-southeast-2.amazonaws.com");

        public List<Product> GetProducts()
        {
            var responses = new List<ProductsDto>();
            var currentPageId = "/api/products/1";

            var morePaginatedResponsesExist = true;
            while (morePaginatedResponsesExist)
            {
                var productsEndpoint = new Uri(endpoint, currentPageId);
                var productsAsJson = Client.GetStringAsync(productsEndpoint).Result;
                responses.Add(JsonConvert.DeserializeObject<ProductsDto>(productsAsJson));
                if (responses.Last().NextPageId is null)
                    morePaginatedResponsesExist = false;
                else
                    currentPageId = responses.Last().NextPageId;
            }

            var listsOfProducts = responses.Select(p => p.Products);
            return listsOfProducts.SelectMany(p => p).ToList();
        }
    }
}