using System;
using System.IO;

namespace TasksToDo.HTML
{
    public class HtmlUtils
    {
        public HtmlUtils()
        {
        }

        public static string CarregaArquivoHTML(string nomeArquivo)
        {
            var nomeCompletoArquivo = $"HTML/{nomeArquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }
    }
}
