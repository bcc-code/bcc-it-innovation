using Bcc.Auth.Stores;
using Duende.IdentityServer.Models;
using Duende.IdentityServer.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bcc.Auth.Server.Stores
{
    public class ClientStore : IClientStore
    {
        private readonly IClientRepository _clients;

        public ClientStore(IClientRepository clients)
        {
            if (clients is null)
            {
                throw new ArgumentNullException(nameof(clients));
            }

            _clients = clients;
        }

        public async Task<Client> FindClientByIdAsync(string clientId)
        {
            return await _clients.FindClientByIdAsync(clientId);
        }
    }
}
