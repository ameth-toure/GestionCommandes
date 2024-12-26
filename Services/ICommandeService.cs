using GestionCommandes.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionCommandes.Services
{
    public interface ICommandeService
    {
        Task<IEnumerable<Commande>> GetAllCommandesAsync();
        Task AddCommandeAsync(Commande commande);
    }
}