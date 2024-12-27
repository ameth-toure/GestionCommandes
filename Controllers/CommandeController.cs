using Microsoft.AspNetCore.Mvc;
using GestionCommandes.Services;
using GestionCommandes.Models;

namespace GestionCommandes.Controllers
{
    public class CommandeController : Controller
    {
        private readonly ICommandeService _commandeService;

        public CommandeController(ICommandeService commandeService)
        {
            _commandeService = commandeService;
        }

        public IActionResult Index()
        {
            var commandes = _commandeService.GetAllCommandes();
            return View(commandes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Commande commande)
        {
            if (ModelState.IsValid)
            {
                _commandeService.AddCommande(commande);
                return RedirectToAction("Index");
            }
            return View(commande);
        }
    }
}