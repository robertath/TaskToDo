using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace TasksToDo.MVC
{
    public class DefaultRouter
    {
        public DefaultRouter()
        {
        }

        public static Task DefaulTreatment(HttpContext context)
        {
            //rota padrão: /<Classe>Logica/Metodo
            //{classe}/{metodo}

            var classe = Convert.ToString(context.GetRouteValue("classe"));
            var nomeMetodo = Convert.ToString(context.GetRouteValue("metodo"));

            var nomeCompleto = $"TasksToDo.Logic.{classe}Logic";

            var tipo = Type.GetType(nomeCompleto);
            var metodo = tipo.GetMethods().Where(m => m.Name == nomeMetodo).First();
            var requestDelegate = (RequestDelegate)Delegate.CreateDelegate(typeof(RequestDelegate), metodo);

            return requestDelegate.Invoke(context);

        }
    }
}
