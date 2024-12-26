using GestionCommandes.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionCommandes.Services
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAllClientsAsync();
        Task AddClientAsync(Client client);
    }
}