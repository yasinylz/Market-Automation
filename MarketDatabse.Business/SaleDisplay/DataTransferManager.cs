using MarketDatabase.DataAccess.Abstract;
using MarketDatabase.Entities;
using MarketDatabase.Entities.Concreate;
using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabse.Business.SaleDisplay
{
    public class DataTransferManager
    {

        private ISale _stockProduct;
        public DataTransferManager(ISale stockProduct)
        {
            _stockProduct = stockProduct;
        }
        public List<Sale> GetProduct()
        {


            return _stockProduct.GetAllSales();


        }
        public Sale Added(Sale stockProduct)
        {
            return _stockProduct.Added(stockProduct);
        }
        public void Delete(Sale stockProduct)
        {
            _stockProduct.Delete(stockProduct);

        }
        public void AllDelete()
        {
            _stockProduct.AllDelete();
        }



    }
}
