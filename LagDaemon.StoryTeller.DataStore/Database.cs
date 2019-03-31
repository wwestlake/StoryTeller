using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB;
using MongoDB.Embedded;

namespace LagDaemon.StoryTeller.DataStore
{
    public class Database : IDisposable
    {
        private EmbeddedMongoDbServer _server;

        public Database()
        {
            _server = new EmbeddedMongoDbServer();
        }

        public MongoClient Client
        {
            get { return _server.Client; }
        }

        public void Dispose()
        {
            _server.Dispose();
        }
    }
}
