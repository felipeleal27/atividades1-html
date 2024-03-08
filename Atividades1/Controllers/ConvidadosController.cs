using Atividades1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atividades1.Controllers
{
    public class ConvidadosController : Controller
    {

        private IList<Convidados> Convidados = new List<Convidados>
        {
            new Convidados()
            {
                Id = 1,
                Nome = "Felipe",
                EMail = "abc@ab.com",
                comparecimento = true
            },
            new Convidados()
            {
                Id = 2,
                Nome = "Joao",
                EMail = "abcd@abc.com",
                comparecimento = false
            },
            new Convidados()
            {
                Id = 3,
                Nome = "Guilherme",
                EMail = "abcde@abcd.com",
                comparecimento = true
            },
            new Convidados()
            {
                Id = 4,
                Nome = "Lucas",
                EMail = "abcdef@abcde.com",
                comparecimento = false
            },
        };
        public IActionResult Index()
        {
            return View(Convidados.Where(conv => conv.comparecimento == true)); ;
        }

        public IActionResult Edit(int id)
        {
            return View(Convidados.Where(conv => conv.Id == id).First());
        }

        [HttpPost]

        public IActionResult Edit(Convidados convidados)
        {
            Convidados.Remove(Convidados.Where(conv => conv.Id == convidados.Id).First());
            Convidados.Add(convidados);
            return RedirectToAction("Index");
        }

        public IActionResult Exibir()
        {
            return View(Convidados);
        }


    }
}
