using Duende.IdentityServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcc.Auth.Stores
{
    public interface IApiResourceRepository
    {
        Task<ApiResource> AddApiResourceAsync(ApiResource resource);

        Task<List<ApiResource>> GetApiResourcesAsync();
    }
}
