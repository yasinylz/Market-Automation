using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.DataAccess.Abstract
{
    public interface IReport
    {
        List<Report> GetReport();
        Report Added(Report report);
        List<Report> UpdateSalesBetweenDates(DateTime startDate, DateTime endDate);
    }
}
