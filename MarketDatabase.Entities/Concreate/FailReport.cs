using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.Entities.Concreate
{
    public class FailReport
    {
        public int Id { get; set; }

        public string BarcodeNo { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime PurchaseData { get; set; }
        public DateTime SaleData { get; set; }
        public bool Session { get; set; }
        public string SessionName { get; set;}
        
    }
}
