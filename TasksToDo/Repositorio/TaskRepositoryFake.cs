using System;
using System.Collections.Generic;
using TasksToDo.Negocio;

namespace TasksToDo.Repositorio
{
    public class TaskRepositoryFake
    {
        private ListOfTasks _paraLer;
        private ListOfTasks _lendo;
        private ListOfTasks _lidos;

        public TaskRepositoryFake()
        {
            var l1 = new Task { Titulo = "O Iluminado", Autor = "Stephen King" };
            var l2 = new Task { Titulo = "It, a coisa", Autor = "Stephen King" };
            var l3 = new Task { Titulo = "Carrie, a estranha", Autor = "Stephen King" };
            var l4 = new Task { Titulo = "Sob a Redoma", Autor = "Stephen King" };
            var l5 = new Task { Titulo = "Cemiterio Maldito", Autor = "Stephen King" };
            var l6 = new Task { Titulo = "A Escolha dos Tres - Torre Negra 2", Autor = "Stephen King" };
            var l7 = new Task { Titulo = "O Pistoleiro - Torre Negra 1", Autor = "Stephen King" };
            var l8 = new Task { Titulo = "Terras Devastadas - Torre Negra 3", Autor = "Stephen King" };
            var l9 = new Task { Titulo = "O Mago e o Vidro - Torre Negra 4", Autor = "Stephen King" };
            var l10 = new Task { Titulo = "Lobos de Calla - Torre Negra 5", Autor = "Stephen King" };
            var l11 = new Task { Titulo = "A Danca da Morte", Autor = "Stephen King" };
            var l12 = new Task { Titulo = "Sombras da Noite", Autor = "Stephen King" };

            _paraLer = new ListOfTasks("Para Ler", l1, l4, l5, l12);
            _lendo = new ListOfTasks("Lendo", l3, l11);
            _lidos = new ListOfTasks("Lidos", l2, l6, l7, l9, l8, l10);
        }

        public ListOfTasks ParaLer => _paraLer;
        public ListOfTasks Lendo => _lendo;
        public ListOfTasks Lidos => _lidos;

        public IEnumerable<Task> Todos => throw new NotImplementedException();

        public void Incluir(Task Task)
        {
            throw new System.NotImplementedException();
        }
    }
}
