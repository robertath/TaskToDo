using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TasksToDo.Repositorio;

namespace TasksToDo.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult ToDo()
        {
            var _repo = new TaskRepositoryCSV();
            ViewBag.Tasks = _repo.ParaLer.Tasks;
            Console.Writeline("Listando To Dos...");
            return View("list");
        }

        public IActionResult Doing()
        {
            var _repo = new TaskRepositoryCSV();
            ViewBag.Tasks = _repo.Lendo.Tasks;
            Console.Writeline("Listando To Doings...");
            return View("list");
        }

        public IActionResult Done()
        {
            var _repo = new TaskRepositoryCSV();
            ViewBag.Tasks = _repo.Lidos.Tasks;
            Console.Writeline("Listando Done...");
            return View("list");
        }


        public string Detalhes(int id)
        {
            var repo = new TaskRepositoryCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            Console.Writeline("Details...");
            return livro.Detalhes();
        }

        public string Teste()
        {
            return "nova funcionalidade implementada";
        }
    }
}
