ClientController.cs:
```csharp
using Microsoft.AspNetCore.Mvc;
using GestionCommandes.Services;
using GestionCommandes.Models;

namespace GestionCommandes.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public IActionResult Index()
        {
            var clients = _clientService.GetAllClients();
            return View(clients);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _clientService.AddClient(client);
                return RedirectToAction("Index");
            }
            return View(client);
        }
    }
}