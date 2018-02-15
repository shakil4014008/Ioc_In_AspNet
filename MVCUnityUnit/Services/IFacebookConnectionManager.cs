using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCUnityUnit.Services
{
    public interface IFacebookConnectionManager
    {
        bool AuthenticateUser();
    }
}
