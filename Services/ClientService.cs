using GestionCommandes.Models;
using GestionCommandes.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionCommandes.Services
{
    public class ClientService : IClientService
    {
        private readonly IGenericRepository<Client> _repository;

        public ClientService(IGenericRepository<Client> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task AddClientAsync(Client client)
        {
            await _repository.AddAsync(client);
        }
    }
}