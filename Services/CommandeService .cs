using GestionCommandes.Models;
using GestionCommandes.Repositories;

namespace GestionCommandes.Services
{
    public class CommandeService : ICommandeService
    {
        private readonly IGenericRepository<Commande> _repository;

        public CommandeService(IGenericRepository<Commande> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Commande> GetAllCommandes()
        {
            return _repository.GetAll();
        }

        public void AddCommande(Commande commande)
        {
            _repository.Add(commande);
        }
    }
}