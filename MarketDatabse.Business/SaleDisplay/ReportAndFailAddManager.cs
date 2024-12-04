using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.DataAccess.Concreate;
using MarketDatabase.Entities;
using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabse.Business.SaleDisplay
{
    public class ReportAndFailAddManager
    {
        private IReport _report;
        public ReportAndFailAddManager(IReport report)
        {
            _report = report;
        }
        public Report Added(Report stockProduct)
        {
            return _report.Added(stockProduct); ;
        }
    }
}
