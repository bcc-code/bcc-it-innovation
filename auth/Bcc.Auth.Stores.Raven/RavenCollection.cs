using Raven.Client.Documents;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bcc.Auth.Stores.RavenDb
{
    public class RavenCollection<T>
    {
        private readonly RavenStore _store;

        public RavenCollection(RavenStore store)
        {
            _store = store;
        }

        public IDocumentStore Store => _store.Store;
    }
}
