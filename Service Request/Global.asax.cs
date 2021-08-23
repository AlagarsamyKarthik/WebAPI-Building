
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Service_Request.BusinessLayer;
using Service_Request.DataLayer;
using Service_Request.Models;
using SimpleInjector;


namespace Service_Request
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //var container = new Container();
            //container.Register<IBuildingDataAccessLayer,BuildingDAL>();
            //container.Register<IBuildingBusinessLayer, BuildingBL>();
            //container.Verify();
            ////DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            //DependencyResolver.SetResolver(((IServiceProvider)container).GetService, container.GetAllInstances);
            //GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorDependencyResolver(container);
        }
    }
}
