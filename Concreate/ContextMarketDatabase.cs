using MarketDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.DataAccess.Concreate
{
    public class ContextMarketDatabase:DbContext
    {
       public DbSet<StockProduct> stockProducts {  get; set; }   
    } 
}
