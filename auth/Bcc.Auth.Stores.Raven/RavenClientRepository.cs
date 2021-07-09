using Duende.IdentityServer.Models;
using Duende.IdentityServer.Stores;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcc.Auth.Stores.RavenDb
{
    public class RavenClientRepository : RavenCollection<Client>, IClientStore, IClientRepository
    {
        public RavenClientRepository(RavenStore store) : base(store)
        {

        }

        public async Task<Client> AddClientAsync(Client client)
        {
            var existing = await FindClientByIdAsync(client.ClientId);
            if (existing == null)
            {
                using (var session = Store.OpenAsyncSession())
                {
                    await session.StoreAsync(client);
                    await session.SaveChangesAsync();
                }
            }

            return client;
        }

        public async Task<Client> FindClientByIdAsync(string clientId)
        {
            using (var session = Store.OpenAsyncSession())
            {
                var client = await session
                    .Advanced
                    .AsyncDocumentQuery<Client>()
                    .WhereEquals(x => x.ClientId, clientId)
                    .FirstOrDefaultAsync();

                return client;
            }
        }
    }
}
