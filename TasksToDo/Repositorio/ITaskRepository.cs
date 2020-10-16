using System;
using System.Collections.Generic;
using TasksToDo.Negocio;

namespace TasksToDo.Repositorio
{
    public interface ITaskRepository
    {
        ListOfTasks ParaLer { get; }
        ListOfTasks Lendo { get; }
        ListOfTasks Lidos { get; }
        IEnumerable<Task> Todos { get; }
        void Incluir(Task Task);
    }
}
