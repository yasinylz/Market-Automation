
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.Entities
{
    public class StockProduct
    {
        [Key]
        public int StokId { get; set; }
        public string BarcodeNo { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime PurchaseData { get; set; }
       




    }
}
