using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace tests1
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            this._output = output;
        }
        
        [Fact]
        public void Test1()
        {
            bool toTest = true;
            Assert.True(toTest);
        }

        [Fact]
        public async Task TestValuesAsync()
        {
            var client = new HttpClient();
            var result = await client.GetAsync("http://service1/api/values");

            var jsonString = await result.Content.ReadAsStringAsync();
            _output.WriteLine("Results: " + jsonString);

            Assert.Contains("Clark", jsonString);
        }
    }
}
