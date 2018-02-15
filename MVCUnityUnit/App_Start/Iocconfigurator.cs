using Microsoft.Practices.Unity;
using MVCUnityUnit.Infrastructure;
using MVCUnityUnit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUnityUnit.App_Start
{
    public static class IocConfigurator
    {
        public static void ConfigureIocUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            registerServices(container);

            DependencyResolver.SetResolver(new DemoUnityDependencyResolver(container));

        }

        private static void registerServices(IUnityContainer container)
        {
            container.RegisterType<ILocalWeatherServiceProvider, LocalWeatherServiceProvider>();
            container.RegisterType<IFacebookConnectionManager, FaceBookConnectionManager>
                (new InjectionConstructor(
                    System.Configuration.ConfigurationManager.AppSettings["userName"],
                            System.Configuration.ConfigurationManager.AppSettings["authenticationToken"],
                                    System.Configuration.ConfigurationManager.AppSettings["faceBookAuthUrl"]
                ));
        }
    }
}