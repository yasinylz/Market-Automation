using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.Entities;
using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static MarketDatabase.DataAccess.Concreate.SaleDal;

namespace MarketDatabase.DataAccess.Concreate
{

    public class SaleDal : ISale
    {
     

        public List<Sale> GetAllSales()
        {
            using (ContextMarketDatabase context= new ContextMarketDatabase() )
            {
                return context.sales.ToList();
            }
        }
        public Sale Added(Sale sale)
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                var AddedEntity = context.Entry(sale);
                AddedEntity.State = EntityState.Added;
                context.SaveChanges();
                return sale;
            }
        }
        public void Delete(Sale sale)
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                var DeleteEntity = context.Entry(sale);
                DeleteEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }
        public void AllDelete()
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                // Get all sales
                var sales = context.sales.ToList();

                // Remove all sales
                context.sales.RemoveRange(sales);

                // Save changes to the database
                context.SaveChanges();
            }
        }

    }

}
