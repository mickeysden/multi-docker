using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace tests2
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
        public async Task TestEthicsAsync()
        {
            var client = new HttpClient();
            var result = await client.GetAsync("http://service2/api/ethics");

            var jsonString = await result.Content.ReadAsStringAsync();
            _output.WriteLine("Results: " + jsonString);

            Assert.Contains("ethic1", jsonString);
        }
    }
}
