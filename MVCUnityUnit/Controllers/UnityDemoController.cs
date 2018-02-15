using MVCUnityUnit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUnityUnit.Controllers
{
    public class UnityDemoController : Controller
    {

        private readonly ILocalWeatherServiceProvider _weatherServiceProvider;
        private readonly IFacebookConnectionManager _facebookConnectionManager;
        public UnityDemoController(ILocalWeatherServiceProvider weatherServiceProvider,
            IFacebookConnectionManager faceBookConnectionManager)
        {
            _weatherServiceProvider = weatherServiceProvider;
            _facebookConnectionManager = faceBookConnectionManager;
        }

       
        public ActionResult Index()
        {
            if (_facebookConnectionManager.AuthenticateUser())
            {
                string currentWeatherInMyArea = _weatherServiceProvider.GetLocalWeatherByZipCode("32310");
            }

            return View();
        }
	}
}