using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarketClient;
using MarketClient.Utils;

namespace MarketClientTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string url = "TEST";
        private const string user = "TEST";
        private const string privateKey = "TEST";

        [TestMethod]
        public void TestExample()
        {
            /// Attantion!, this code is not good practice! this was made for the sole purpose of being an example.
            /// A real good code, should use defined classes and and not hardcoded values!
            SimpleHTTPClient client = new SimpleHTTPClient();
            var request = new{
                type = "queryUser",
            };
            client.SendPostRequest(url,user,SimpleCtyptoLibrary.CreateToken(user,privateKey), request);
        }
    }
}
