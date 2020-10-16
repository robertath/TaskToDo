using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasksToDo.Negocio
{

    public class ListOfTasks
    {
        private List<Task> _Tasks;

        public ListOfTasks(string titulo, params Task[] Tasks)
        {
            Titulo = titulo;
            _Tasks = Tasks.ToList();
            _Tasks.ForEach(l => l.Lista = this);
        }

        public string Titulo { get; set; }
        public IEnumerable<Task> Tasks
        {
            get { return _Tasks; }
        }

        public override string ToString()
        {
            var linhas = new StringBuilder();
            linhas.AppendLine(Titulo);
            linhas.AppendLine("=========");
            foreach (var Task in Tasks)
            {
                linhas.AppendLine(Task.ToString());
            }
            return linhas.ToString();
        }
    }
}

