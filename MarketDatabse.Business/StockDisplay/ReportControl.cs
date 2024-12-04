using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabse.Business.StockDisplay
{
    public class ReportControl
    {
        private IReport _report;
        public ReportControl(IReport report)
        {
            _report = report;
        }
        public List<Report> UpdateSalesBetweenDate(DateTime startDate, DateTime endDate)
        {
            return _report.UpdateSalesBetweenDates(startDate, endDate);
        }
    }
}
