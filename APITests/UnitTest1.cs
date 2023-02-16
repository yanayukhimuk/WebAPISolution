using RestSharp;
using ApiTestLib;

namespace APITests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            var testData = new TestLib();
            var response = testData.GetProducts();
        }
    }
}