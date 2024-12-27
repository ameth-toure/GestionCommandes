using GestionCommandes.Models;
using GestionCommandes.Repositories;

namespace GestionCommandes.Services
{
    public class ClientService : IClientService
    {
        private readonly IGenericRepository<Client> _repository;

        public ClientService(IGenericRepository<Client> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _repository.GetAll();
        }

        public void AddClient(Client client)
        {
            _repository.Add(client);
        }
    }
}