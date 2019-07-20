using mvc_entity.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace mvc_entity
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Adiciona o filtro criado antes de registra-los na aplicacao
            GlobalFilters.Filters.Add(new LogActionFilter());

            AreaRegistration.RegisterAllAreas();
            // Registra os filtros globais na aplicacao
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Registra as dependencias estabelecidas no UnityConfig
            UnityConfig.RegisterComponents();
        }
    }
}
