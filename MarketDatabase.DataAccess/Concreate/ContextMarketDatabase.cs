using MarketDatabase.Entities;
using MarketDatabase.Entities.Concreate;
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
        public DbSet<Sale> sales { get; set; }
        public DbSet<Report> reports { get; set; }
        public DbSet<FailReport> failReports { get; set; }

        public DbSet<UserFail> userFails { get; set; }


    }
}
