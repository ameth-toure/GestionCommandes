using GestionCommandes.Models;
using GestionCommandes.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionCommandes.Services
{
    public class CommandeService : ICommandeService
    {
        private readonly IGenericRepository<Commande> _repository;

        public CommandeService(IGenericRepository<Commande> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Commande>> GetAllCommandesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task AddCommandeAsync(Commande commande)
        {
            await _repository.AddAsync(commande);
        }
    }
}
