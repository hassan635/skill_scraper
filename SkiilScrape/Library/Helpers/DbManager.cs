using System;
using MongoDB.Driver;
namespace SkiilScrape.Library.Helpers
{
    public class DbManager
    {
        private MongoClient mongoClient = null;
         
        public DbManager()
        {
            var dbclient = new MongoClient("mongodb+srv://tezt:Windows.2000@cluster0-gpynn.mongodb.net/<dbname>?retryWrites=true&w=majority");
            var db = dbclient.GetDatabase("testdb");
        }
    }
}
