using Microsoft.AspNetCore.Mvc;
using MvcWebJobChollometro.Models;
using MvcWebJobChollometro.Repositories;

namespace MvcWebJobChollometro.Controllers
{
    public class ChollometroController : Controller
    {
        private RepositoryChollos repo;

        public ChollometroController(RepositoryChollos repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            List<Chollo> chollos = await this.repo.GetChollosAsync();
            return View(chollos);
        }
    }
}
