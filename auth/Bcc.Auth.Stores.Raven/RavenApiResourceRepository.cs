using Duende.IdentityServer.Models;
using Duende.IdentityServer.Stores;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcc.Auth.Stores.RavenDb
{
    public class RavenApiResourceRepository : RavenCollection<ApiResource>, IApiResourceRepository
    {
        public RavenApiResourceRepository(RavenStore store) : base(store)
        {

        }

        public async Task<ApiResource> AddApiResourceAsync(ApiResource resource)
        {
            var existing = (await FindApiResourcesByNameAsync(new[] { resource.Name })).FirstOrDefault();
            if (existing == null)
            {
                using (var session = Store.OpenAsyncSession())
                {
                    await session.StoreAsync(resource);
                    await session.SaveChangesAsync();
                }
            }
            return resource;
        }



        public async Task<IEnumerable<ApiResource>> FindApiResourcesByNameAsync(IEnumerable<string> apiResourceNames)
        {
            using (var session = Store.OpenAsyncSession())
            {
                var resources = await session
                    .Advanced
                    .AsyncDocumentQuery<ApiResource>()
                    .WhereIn(x => x.Name, apiResourceNames)
                    .ToListAsync();

                return resources;
            }
        }

        public async Task<List<ApiResource>> GetApiResourcesAsync()
        {
            using (var session = Store.OpenAsyncSession())
            {
                var resources = await session
                    .Advanced
                    .AsyncDocumentQuery<ApiResource>()
                    .ToListAsync();
                return resources;
            }
        }
    }
}
