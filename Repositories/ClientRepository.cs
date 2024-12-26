using Microsoft.AspNetCore.Mvc;
using GestionCommandes.Models;
using GestionCommandes.Services;
using System.Threading.Tasks;

namespace GestionCommandes.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitService _produitService;

        public ProduitController(IProduitService produitService)
        {
            _produitService = produitService;
        }

        public async Task<IActionResult> Index()
        {
            var produits = await _produitService.GetAllProduitsAsync();
            return View(produits);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Produit produit)
        {
            await _produitService.AddProduitAsync(produit);
            return RedirectToAction(nameof(Index));
        }
    }
}