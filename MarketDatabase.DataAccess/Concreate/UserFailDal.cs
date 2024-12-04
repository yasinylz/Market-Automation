using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.Entities;
using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.DataAccess.Concreate
{
    public class UserFailDal : IUser
    {

        public UserFail GetUser(string username, string password)
        {
            using (ContextMarketDatabase _context = new ContextMarketDatabase())
            {
                return _context.userFails.SingleOrDefault(u => u.Name == username && u.Password == password);
            }
        }

      
    }
}
