using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUnityUnit.Infrastructure
{
    public class DemoUnityDependencyResolver: IDependencyResolver
    {
        private IUnityContainer _unityContainer;

        public DemoUnityDependencyResolver(IUnityContainer unitycontainer)
        {
            _unityContainer = unitycontainer;
        }
        public object GetService(Type serviceType)
        {
            try
            {
                return _unityContainer.Resolve(serviceType);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _unityContainer.ResolveAll(serviceType);
            }
            catch (Exception)
            {

                return new List<object>();
            }
        }
    }
}