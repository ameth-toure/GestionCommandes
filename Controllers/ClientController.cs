using Microsoft.AspNetCore.Mvc;
using GestionCommandes.Models;
using GestionCommandes.Services;
using System.Threading.Tasks;

namespace GestionCommandes.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<IActionResult> Index()
        {
            var clients = await _clientService.GetAllClientsAsync();
            return View(clients);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Client client)
        {
            await _clientService.AddClientAsync(client);
            return RedirectToAction(nameof(Index));
        }
    }
}
