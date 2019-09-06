using conta_de_luz.Models;
using Microsoft.AspNetCore.Mvc;
namespace conta_de_luz.Controllers
{
    public class ContaController : Controller
    {
        ContaRepository _repository = new ContaRepository();
        public IActionResult Index()
        {
            var contas = _repository.GetAll();
            return View(contas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Conta conta)
        {
            _repository.Create(conta);
            return RedirectToAction("Index");
        }
    }
}