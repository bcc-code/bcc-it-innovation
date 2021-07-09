using Bcc.Auth.Stores;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcc.Auth.Server.Stores
{
    public class ResourceStore : IResourceStore
    {

        public ResourceStore(IApiResourceRepository apiResources)
        {
            if (apiResources is null)
            {
                throw new ArgumentNullException(nameof(apiResources));
            }
            ApiResources = apiResources;
        }

        public async Task<IEnumerable<ApiResource>> FindApiResourcesByNameAsync(IEnumerable<string> apiResourceNames)
        {
            return (await ApiResources.GetApiResourcesAsync()).Where(r => apiResourceNames.Any(n => r.Name == n));
        }

        public async Task<IEnumerable<ApiResource>> FindApiResourcesByScopeNameAsync(IEnumerable<string> scopeNames)
        {
            return (await ApiResources.GetApiResourcesAsync()).Where(r => scopeNames.Any(n => r.Scopes.Contains(n)));
        }

        public Task<IEnumerable<ApiScope>> FindApiScopesByNameAsync(IEnumerable<string> scopeNames)
        {
            return Task.FromResult(Scopes.Where(r => scopeNames.Any(n => r.Name == n)));
        }

        public Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeNameAsync(IEnumerable<string> scopeNames)
        {
            return Task.FromResult(IdentityResources.Where(r => scopeNames.Any(n => r.Name == n)));
        }

        public async Task<Resources> GetAllResourcesAsync()
        {
            return new Resources
            {
                ApiResources = (await ApiResources.GetApiResourcesAsync()),
                ApiScopes = Scopes,
                IdentityResources = IdentityResources,
                OfflineAccess = true
            };
            
        }


        static List<IdentityResource> IdentityResources = new List<IdentityResource>
        {
            new IdentityResource
            {
                Name = "PersonID",
                ShowInDiscoveryDocument = true,
                Description = "PersonID",
                DisplayName = "User's PersonID",
                Enabled = true,
                UserClaims = new List<string>(),
                Properties = new Dictionary<string, string>()
            }
        };



        static List<ApiScope> Scopes = new List<ApiScope>
        {
            new ApiScope
            {
                Name = "Scope-1",
                Enabled = true
            }
        };

        public IApiResourceRepository ApiResources { get; }
    }
}
