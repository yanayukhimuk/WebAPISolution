using RestSharp;
using System;
using Newtonsoft.Json;

namespace ApiTestLib
{
    public class TestLib
    {
        private const string url = "https://localhost:7214";
            
        public ListOfProductsDTO GetProducts()
        {
            var restClient = new RestClient(url);
            var restRequest = new RestRequest("/api/Products", Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            var response = restClient.Execute(restRequest);
            var content = response.Content;

            var products = JsonConvert.DeserializeObject<ListOfProductsDTO>(content);
            return products;
        }
    }
}