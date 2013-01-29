using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApp.Mockup.App_Start
{
    public static class IocConfig
    {
        static readonly IUnityContainer container = new UnityContainer();
        
        public static void RegisterIoc(HttpConfiguration config)
        {
            IServiceLocator serviceLocator = new UnityServiceLocator(container);

            EnterpriseLibraryContainer.Current = serviceLocator;

            System.Web.Mvc.DependencyResolver.SetResolver(new Unity.Mvc3.UnityDependencyResolver(container));
            config.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}