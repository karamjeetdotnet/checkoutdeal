using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Validation.Providers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CheckoutDeal
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           // GlobalConfiguration.Configuration.Services.RemoveAll(typeof(System.Web.Http.Validation.ModelValidatorProvider),v => v is InvalidModelValidatorProvider);//Fix for Bug in webapi http://aspnetwebstack.codeplex.com/workitem/270
            AreaRegistration.RegisterAllAreas();
            //ViewEngineCollection Collection = ViewEngines.Engines.;
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            //ValueProviderFactories.Factories.Add(new JsonValueProviderFactory());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }

    //public class NewRazorEngine : RazorViewEngine//IViewEngine
    //{

    //    public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReleaseView(ControllerContext controllerContext, IView view)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}