using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.DataAccess.Concreate;
using MarketDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.DataAccess
{
    public class StockProductsDal : IStockProduct
    {
        public StockProduct Added(StockProduct productData)
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                var AddedEntity = context.Entry(productData);
                AddedEntity.State = EntityState.Added;
                context.SaveChanges();
                return productData;
            }
        }
        public bool IsSaleExists(string barcodeNo)
        {
            using (var context = new ContextMarketDatabase())
            {
                return context.stockProducts.Any(s => s.BarcodeNo == barcodeNo);
            }
        }
        public void Delete(StockProduct productData)
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                var DeleteEntity = context.Entry(productData);
                DeleteEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public List<StockProduct> Get(Expression<Func<StockProduct, bool>> filter = null)
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())                                                         
            {
                return filter == null ? context.Set<StockProduct>().ToList() : context.Set<StockProduct>().Where(filter).ToList();

            }
        }




        public StockProduct Update(StockProduct productData)
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                var UpdateEntity = context.Entry(productData);
                UpdateEntity.State = EntityState.Modified;
                context.SaveChanges();
                return productData;
            }
        }
        public StockProduct GetBarcode(string barcode)
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                return context.stockProducts.SingleOrDefault(p => p.BarcodeNo == barcode);
            }

        }
        public void UpdateStockProduct(StockProduct stockProduct)
        {
            using (ContextMarketDatabase context = new ContextMarketDatabase())
            {
                var UpdateStockAmount = context.Entry(stockProduct);
                UpdateStockAmount.State = EntityState.Modified;
                context.SaveChanges();
            
            }
                
        }

    }
}
