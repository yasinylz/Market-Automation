using MarketDatabase.DataAccess.Concreate;
using MarketDatabase.Entities.Concreate;
using MarketDatabse.Business;
using MarketDatabse.Business.SaleDisplay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketDatabase.FormUI.Displays
{
    public partial class kasa : Form
    {
       
        public kasa()
        {
            InitializeComponent();
            
        }

        FailReportManager _reportManager = new FailReportManager(new FailReportDal());
        private void kasa_Load(object sender, EventArgs e)
        {
            label1.Text=Global.LoggedInUsername;
            dataGridView1.DataSource = _reportManager.UpdateSalesBetweenDates(dateTimePicker1.Value,dateTimePicker2.Value).ToList();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            // Veritabanından ürünleri tarih aralığına göre getir
            var products = _reportManager.UpdateSalesBetweenDates(startDate,endDate);

            // Ürünleri göster
            DisplayProducts(products);
        }

        private void DisplayProducts(List<FailReport> products)
        {
            // DataGridView temizle
            dataGridView1.Rows.Clear();

            // Her bir ürünü DataGridView'e ekle
            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.Id, product.ProductName, product.SalePrice);
            }
        }
    }
    
}
