using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LagDaemon.StoryTeller.DataStore;
using MongoDB.Driver;

namespace LagDaemon.StoryTeller.UnitTests
{

    [TestFixture]
    public class DataStoreTests
    {
        private class TestClass
        {
            public int Id { get; set; }
            public string TestValue { get; set; }
        }

        [Test]
        public void StartupTests()
        {
            using (var test = new Database())
            {
                var client = test.Client;

                Assert.NotNull(client);
            }
        }

        [Test]
        public async Task ReadWriteTests()
        {
            using (var test = new Database())
            {
                FieldDefinition<TestClass> field = "Id";
                var builder = new FilterDefinitionBuilder<TestClass>();

                FilterDefinition<TestClass> filter = builder.Eq("Id", 12345);

                var client = test.Client;
                var db = client.GetDatabase("test");
                var collection = db.GetCollection<TestClass>("col");
                await collection.InsertOneAsync(new TestClass() { Id = 12345, TestValue = "Hello World" });
                var retrieved = await collection.FindSync<TestClass>(filter).SingleOrDefaultAsync();
                Assert.NotNull(retrieved);
                Assert.AreEqual("Hello World", retrieved.TestValue);
            }
        }

        [Test]
        public async Task ReadWriteTests2()
        {
            using (var test = new Database())
            {
                FieldDefinition<TestClass> field = "Id";
                var builder = new FilterDefinitionBuilder<TestClass>();

                FilterDefinition<TestClass> filter = builder.Eq("Id", 12345);

                var client = test.Client;
                var db = client.GetDatabase("test");
                var collection = db.GetCollection<TestClass>("col");
                //await collection.InsertOneAsync(new TestClass() { Id = 12345, TestValue = "Hello World" });
                var retrieved = await collection.FindSync<TestClass>(filter).SingleOrDefaultAsync();
                Assert.NotNull(retrieved);
                Assert.AreEqual("Hello World", retrieved.TestValue);
            }
        }


    }
}
