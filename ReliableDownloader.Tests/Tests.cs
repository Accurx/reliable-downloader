using NUnit.Framework;

namespace ReliableDownloader.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void Test1()
        {
            var fileDownloader = new FileDownloader();
            Assert.True(true);
        }
    }
}