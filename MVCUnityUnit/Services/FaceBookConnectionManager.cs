using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCUnityUnit.Services
{
    public class FaceBookConnectionManager: IFacebookConnectionManager
    {

        private readonly string _userName;
        private readonly string _authenticationToken;
        private readonly string _facebookConnectionUrl;

        public FaceBookConnectionManager(string userName, string authenticationToken, string faceBookConnectionUrl)
        {
            _userName = userName;
            _authenticationToken = authenticationToken;
            _facebookConnectionUrl = faceBookConnectionUrl;

        }
        public bool AuthenticateUser()
        {
            if (!string.IsNullOrEmpty(_userName) 
                && !string.IsNullOrEmpty(_authenticationToken) 
                && !string.IsNullOrEmpty(_facebookConnectionUrl))
            {
                return true;
            }
            return false;
        }
    }
}