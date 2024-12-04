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
    public class ReportDal : IReport
    {
        public Report Added(Report report)
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                var AddReport = context.Entry(report);
                AddReport.State = EntityState.Added;
                context.SaveChanges();
                return report;
            }
        }

        public List<Report> GetReport()
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                return context.reports.ToList(); 
            }
        }

        public List<Report> UpdateSalesBetweenDates(DateTime startDate, DateTime endDate)
        {
            using (ContextMarketDatabase _context = new ContextMarketDatabase())
            {
                var salesToUpdate = _context.reports
                                       .Where(s => s.SaleDate >= startDate && s.SaleDate <= endDate)
                                       .ToList();

                _context.SaveChanges();
                return salesToUpdate;
            }
        }
    }
}
