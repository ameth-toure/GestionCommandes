using Microsoft.AspNetCore.Mvc;
using GestionCommandes.Services;
using GestionCommandes.Models;

namespace GestionCommandes.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitService _produitService;

        public ProduitController(IProduitService produitService)
        {
            _produitService = produitService;
        }

        public IActionResult Index()
        {
            var produits = _produitService.GetAllProduits();
            return View(produits);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produit produit)
        {
            if (ModelState.IsValid)
            {
                _produitService.AddProduit(produit);
                return RedirectToAction("Index");
            }
            return View(produit);
        }
    }
}