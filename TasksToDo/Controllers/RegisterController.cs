using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TasksToDo.HTML;
using TasksToDo.Repositorio;

namespace TasksToDo.Controllers
{
    public class RegisterController
    {
        public RegisterController()
        {
        }

        public string Add(Negocio.Task task)
        {
            var _repo = new TaskRepositoryCSV();
            _repo.Incluir(task);
            return "Task adicionada com sucesso!";
        }

        public IActionResult ExibirFormulario()
        {
            var html = new ViewResult{ ViewName = "form"};
            return html;
        }
    }
}
