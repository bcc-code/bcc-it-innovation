using Duende.IdentityServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcc.Auth.Stores
{
    public interface IClientRepository
    {
        Task<Client> AddClientAsync(Client client);

        Task<Client> FindClientByIdAsync(string clientId);
    }
}
