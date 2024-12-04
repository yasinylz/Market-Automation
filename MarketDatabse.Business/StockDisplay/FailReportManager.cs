using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.DataAccess.Concreate;
using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabse.Business
{
    public class FailReportManager
    {
        private IFailReport _failreport;
        public FailReportManager(IFailReport failReport)
        {
            _failreport = failReport;
        }
        public List<FailReport> UpdateSalesBetweenDates(DateTime startDate, DateTime endDate)
        {
            return _failreport.UpdateSalesBetweenDates(startDate, endDate);
        }
        public FailReport Added(FailReport failReport)
        {
            return _failreport.Added(failReport);
        }
       

    }
}
