using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace DataAccessUnitTest
{
    [TestFixture]
    public class ColorsTest
    {
        protected TestServer server;
        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }

        [Test]
        public void GetAllColors_Test()
        {
            var repository = server.Host.Services.GetService<IVehiclesDataManager>();
            var list = repository.GetAll();
            Assert.Pass();
        }
    }
}