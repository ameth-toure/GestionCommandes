using GestionCommandes.Models;
using GestionCommandes.Repositories;

namespace GestionCommandes.Services
{
    public class ProduitService : IProduitService
    {
        private readonly IGenericRepository<Produit> _repository;

        public ProduitService(IGenericRepository<Produit> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Produit> GetAllProduits()
        {
            return _repository.GetAll();
        }

        public void AddProduit(Produit produit)
        {
            _repository.Add(produit);
        }
    }
}