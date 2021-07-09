using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using Raven.Client.ServerWide.Operations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bcc.Auth.Stores.RavenDb
{



    public class RavenStore
    {
        private Lazy<IDocumentStore> _store;
        private readonly RavenConfig _config;

        public IDocumentStore Store => _store.Value;

        public RavenStore(RavenConfig config)
        {
            _store = new Lazy<IDocumentStore>(CreateStore);
            _config = config;
        }

        private IDocumentStore CreateStore()
        {

            IDocumentStore store = new DocumentStore()
            {
                // Define the cluster node URLs (required)
                Urls = new[] { _config.Urls },

                // Set conventions as necessary (optional)
                Conventions =
                {
                    MaxNumberOfRequestsPerSession = 10,
                    UseOptimisticConcurrency = true
                },

                // Define a default database (optional)
                Database = _config.DatabaseName,

                // Define a client certificate (optional)
                // Certificate = new X509Certificate2("C:\\path_to_your_pfx_file\\cert.pfx"),

                // Initialize the Document Store
            }.Initialize();
            //Task.Run(async () => await
            //    var result = await store.Maintenance.Server.SendAsync(new CreateDatabaseOperation(new Raven.Client.ServerWide.DatabaseRecord
            //    {
            //        DatabaseName = _config.DatabaseName,
            //    }));
            //})
            //store.Database = _config.DatabaseName;

            return store;
        }


    }
}
