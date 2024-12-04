using MarketDatabase.DataAccess.Concreate;
using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.DataAccess.Abstract
{
    public interface IUser
    {
        UserFail GetUser(string username, string password);
    }
}
