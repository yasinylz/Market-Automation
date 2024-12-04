using DevExpress.XtraEditors;
using MarketDatabase.DataAccess.Concreate;
using MarketDatabase.Entities.Concreate;
using MarketDatabse.Business.StockDisplay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketDatabase.FormUI
{
    public partial class ReportPage : DevExpress.XtraEditors.DirectXForm
    {
        public ReportPage()
        {
            InitializeComponent();
        }
        ReportControl _manager = new ReportControl(new ReportDal());
        private void oDataInstantFeedbackSource2_GetSource(object sender, DevExpress.Data.ODataLinq.GetSourceEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            // Veritabanından ürünleri tarih aralığına göre getir
            var products = _manager.UpdateSalesBetweenDate(startDate, endDate);

            // Ürünleri göster
            dataGridView1.DataSource = products.ToList();
        }

        
    }
    
}