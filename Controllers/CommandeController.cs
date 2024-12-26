using Microsoft.AspNetCore.Mvc;
using GestionCommandes.Models;
using GestionCommandes.Services;
using System.Threading.Tasks;

namespace GestionCommandes.Controllers
{
    public class CommandeController : Controller
    {
        private readonly ICommandeService _commandeService;

        public CommandeController(ICommandeService commandeService)
        {
            _commandeService = commandeService;
        }

        public async Task<IActionResult> Index()
        {
            var commandes = await _commandeService.GetAllCommandesAsync();
            return View(commandes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Commande commande)
        {
            await _commandeService.AddCommandeAsync(commande);
            return RedirectToAction(nameof(Index));
        }
    }
}