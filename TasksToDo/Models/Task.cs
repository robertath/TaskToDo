using System;
using System.Text;

namespace TasksToDo.Negocio
{
    public class Task
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public ListOfTasks Lista { get; set; }

        public string Detalhes()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Detalhes do Task");
            stringBuilder.AppendLine("=====");
            stringBuilder.AppendLine($"Título: {Titulo}");
            stringBuilder.AppendLine($"Autor: {Autor}");
            stringBuilder.AppendLine($"Lista: {Lista.Titulo}");
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor}";
        }
    }

}
