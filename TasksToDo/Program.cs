using System;
using Microsoft.AspNetCore.Hosting;
using TasksToDo.Negocio;
using TasksToDo.Repositorio;

namespace TasksToDo
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new TaskRepositoryCSV();

            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();

            ImprimeLista(_repo.ParaLer);
            ImprimeLista(_repo.Lendo);
            ImprimeLista(_repo.Lidos);
        }

        static void ImprimeLista(ListOfTasks lista)
        {
            Console.WriteLine(lista);
        }
    }
}
