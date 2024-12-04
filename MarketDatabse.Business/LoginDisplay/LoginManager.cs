using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabse.Business.LoginDisplay
{
    public class LoginManager
    {
        private IUser _user;
        public LoginManager(IUser user)
        {
            _user = user;
        }

        public UserFail GetUser(string username, string password)
        {
            return _user.GetUser(username, password);   
        }
    }
}
