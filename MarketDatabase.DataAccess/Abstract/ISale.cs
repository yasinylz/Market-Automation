using MarketDatabase.Entities;
using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.DataAccess.Abstract
{
    public interface ISale
    {
        List<Sale> GetAllSales();
        void Delete(Sale sale);
         Sale Added(Sale sale);
        void AllDelete();


    }
}
