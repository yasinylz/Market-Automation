using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.Entities.Concreate
{
    public class Sale
    {
        [Key] 
        public int SaleId { get; set; }
        public string ProductName { get; set; }

        public string BarcodeNo { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }


    }
}
