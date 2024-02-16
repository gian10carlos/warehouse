using DataLayer.DataLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse_interface.Components.Manager
{
    internal class Login
    {
        private LoginClass loginClass =  new LoginClass();
        public Boolean IsLoggedIn(string username, string password) 
        {
            return loginClass.Login(username, password);
        }
    }
}
