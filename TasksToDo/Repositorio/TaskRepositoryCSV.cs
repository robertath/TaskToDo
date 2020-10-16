using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TasksToDo.Negocio;

namespace TasksToDo.Repositorio
{
    public class TaskRepositoryCSV : ITaskRepository
    {

        private static readonly string nomeArquivoCSV = "Repositorio/tasks.csv";

        private ListOfTasks _paraLer;
        private ListOfTasks _lendo;
        private ListOfTasks _lidos;


        public TaskRepositoryCSV()
        {

            var arrayParaLer = new List<Task>();
            var arrayLendo = new List<Task>();
            var arrayLidos = new List<Task>();

            using (var file = File.OpenText(TaskRepositoryCSV.nomeArquivoCSV))
            {
                while (!file.EndOfStream)
                {
                    var textoTask = file.ReadLine();
                    if (string.IsNullOrEmpty(textoTask))
                    {
                        continue;
                    }
                    var infoTask = textoTask.Split(';');
                    var Task = new Task
                    {
                        Id = Convert.ToInt32(infoTask[1]),
                        Titulo = infoTask[2],
                        Autor = infoTask[3]
                    };
                    switch (infoTask[0])
                    {
                        case "para-ler":
                            arrayParaLer.Add(Task);
                            break;
                        case "lendo":
                            arrayLendo.Add(Task);
                            break;
                        case "lidos":
                            arrayLidos.Add(Task);
                            break;
                        default:
                            break;
                    }
                }
            }

            _paraLer = new ListOfTasks("Para Ler", arrayParaLer.ToArray());
            _lendo = new ListOfTasks("Lendo", arrayLendo.ToArray());
            _lidos = new ListOfTasks("Lidos", arrayLidos.ToArray());
        }

        public ListOfTasks ParaLer => _paraLer;
        public ListOfTasks Lendo => _lendo;
        public ListOfTasks Lidos => _lidos;

        public IEnumerable<Task> Todos => _paraLer.Tasks.Union(_lendo.Tasks).Union(_lidos.Tasks);

        public void Incluir(Task Task)
        {
            var id = Todos.Select(l => l.Id).Max();
            using (var file = File.AppendText(TaskRepositoryCSV.nomeArquivoCSV))
            {
                file.WriteLine($"para-ler;{id + 1};{Task.Titulo};{Task.Autor}");
            }
        }
    }
}
