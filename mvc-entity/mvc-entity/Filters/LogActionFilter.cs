using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc_entity.Filters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        // Filtros executados antes ou depois de uma chamada de uma Action ou do retorno do Result.
        // Pode ser feito inumeras coisas, assim como Logar algo ou executar filtros nos parametros recebidos.
        // Eh necessario decorar com [LogActionFilter()] o controller a ser filtrado.
        // Pode ser decorado somente em uma acao tambem.
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("OnResultExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuted", filterContext.RouteData);
        }

        private void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = string.Format("{0} controller: {1} action: {2}", methodName, controllerName, actionName);
            Debug.WriteLine(message, "Action Filter Log");
        }

    }
}