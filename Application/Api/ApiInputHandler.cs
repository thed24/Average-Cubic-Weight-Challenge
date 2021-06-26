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
        private readonly Uri resource = new Uri("http://wp8m3he1wt.s3-website-ap-southeast-2.amazonaws.com/api/products/");

        public List<Product> GetProducts()
        {
            var responses = new List<ProductDto>();
            var currentId = "1";

            var morePaginatedResponsesExist = true;
            while (morePaginatedResponsesExist)
            {
                var productsEndpoint = new Uri(resource, currentId);
                var productsAsJson = Client.GetStringAsync(productsEndpoint).Result;
                responses.Add(JsonConvert.DeserializeObject<ProductDto>(productsAsJson));
                if (responses.Last().Next is null)
                    morePaginatedResponsesExist = false;
                else
                    currentId = responses.Last().Next;
            }

            var objects = responses.Select(p => p.Objects);
            return objects.SelectMany(p => p).ToList();
        }
    }
}