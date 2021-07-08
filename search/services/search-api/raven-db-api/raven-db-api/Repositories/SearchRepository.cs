using System;
using Raven.Client.Documents;

namespace raven_db_api.Repositories
{
    public class SearchRepository : ISearchRepository
    {
        public void InitStore()
        {
            using IDocumentStore store = new DocumentStore
            {
                Urls = new[]
                {
                    "http://localhost:8080"
                },
                Database = "TestDb2",
                Conventions = { }
            };
            store.Initialize();
        }
        
        public string GetSearch()
        {
            using (IDocumentStore store = new DocumentStore
            {
                Urls = new[]
                {
                    "http://live-test.ravendb.net"
                },
                Database = "Northwind",
                Conventions = { }
            })
            {
                store.Initialize();
            }
            return "";
        }
    }
}
        
    
    