using MarketDatabase.DataAccess;
using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.DataAccess.Concreate;
using MarketDatabase.Entities;
using MarketDatabase.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabse.Business.StockDisplay
{

    public class StockProductManager
    {
        //Dependency Inversion Principle (DIP) / Bağımlılıkların Tersine Çevrilmesi İlkesi
        private IStockProduct _stockProduct;
        public StockProductManager(IStockProduct stockProduct)
        {
            _stockProduct = stockProduct;
        }
        public List<StockProduct> GetProduct()
        {


          return  _stockProduct.Get();
                
            
        }
        public StockProduct Added(StockProduct stockProduct)
        {
            
            if (!_stockProduct.IsSaleExists(stockProduct.BarcodeNo))
            {
                return _stockProduct.Added(stockProduct);
            }
            else
            {
                throw new Exception("Bu ürün zaten mevcut!");
            }
        }
        public void Delete(StockProduct stockProduct)
        {
             _stockProduct.Delete(stockProduct);

        }
        public StockProduct Update(StockProduct stockProduct)
        {
            return _stockProduct.Update(stockProduct);
        }
        public List<StockProduct> GetProductName(string productName)
        {
            return _stockProduct.Get(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }
        public List<StockProduct> GetCategories(string categories)
        {
            return _stockProduct.Get(p => p.CategoryName.ToLower().Contains(categories.ToLower()));
        }
        public List<StockProduct> GetBrandName(string brand)
        {
            return _stockProduct.Get(p => p.BrandName.ToLower().Contains(brand.ToLower()));
        }
        public StockProduct GetBarcodeManager(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode)||barcode==null)
            {
                throw new ArgumentException("Geçersiz barkod");


            }
            return _stockProduct.GetBarcode(barcode);
        }
    }
}
