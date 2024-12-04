using MarketDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase.DataAccess.Abstract
{
    public interface IStockProduct
    {
        List<StockProduct> Get(Expression<Func<StockProduct,bool>> filter=null);

        StockProduct Update(StockProduct productData);
        StockProduct Added(StockProduct productData);
        void Delete(StockProduct productData);
        StockProduct GetBarcode(string barcode);
        void UpdateStockProduct(StockProduct stockProduct);
        bool IsSaleExists(string barcodeNo);

    }
}
