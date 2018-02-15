using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCUnityUnit.Services
{
    public class LocalWeatherServiceProvider: ILocalWeatherServiceProvider
    {
        //public LocalWeatherServiceProvider(){ }


        public string GetLocalWeatherByZipCode(string zipcode)
        {
            return "It is snowing right now in your area: " + zipcode;
        }
    }
}