using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.DataAccess.Concreate
{
    public class FailReportDal:IFailReport
    {
        public FailReport Added(FailReport failReport)
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                var AddedEntity = context.Entry(failReport);
                AddedEntity.State = EntityState.Added;
                context.SaveChanges();
                return failReport;
            }
        }

        public List<FailReport> UpdateSalesBetweenDates(DateTime startDate, DateTime endDate)
        {
            using (ContextMarketDatabase _context = new ContextMarketDatabase())
            {
                var salesToUpdate = _context.failReports
                                       .Where(s => s.SaleData >= startDate && s.SaleData <= endDate)
                                       .ToList();

                _context.SaveChanges();
                return salesToUpdate;
            }
        }
    }
}
