using System;
using raven_db_api.Models;
using Raven.Client.Documents;

namespace raven_db_api.Repositories
{
    public class SearchRepository : ISearchRepository
    {
        private IDocumentStore GetDocumentStore()
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
            return store.Initialize();
        }

        public string AddDocument()
        {
            var documentStore = GetDocumentStore();
            using(var session = documentStore.OpenSession())
            {
                session.Store(new Menu
                {
                    Name = "Breakfast Menu",
                    Courses = {
                        new Course {
                            Name = "Waffle",
                            Cost = 2.3m
                        },
                        new Course {
                            Name = "Cereal",
                            Cost = 1.3m,
                            Allergenics = { "Peanuts" }
                        },
                    }
                });
                session.SaveChanges();
            }

            return "OK";
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
        
    
    