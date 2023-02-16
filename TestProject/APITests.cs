using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using WebAPIProject;

namespace TestProject
{
    public class APITests
    {
        private readonly HttpClient client;

        public APITests()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());
            client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET")]
        public async Task GetAllProductsAsync(string method)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), "api/Products");
            var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
