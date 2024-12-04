using AForge.Video.DirectShow;
using AForge.Video;
using MarketDatabase.Entities.Concreate;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketDatabase.DataAccess.Concreate;
using MarketDatabse.Business.SaleDisplay;
using MarketDatabse.Business.StockDisplay;
using ZXing;
using MarketDatabase.DataAccess;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using System.Linq;
using MarketDatabse.Business;
using Stripe.BillingPortal;

namespace MarketDatabase.FormUI.Displays
{
    public partial class SaleDisplay : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private ZXing.BarcodeReader barcodeReader;

        private readonly StockProductManager _stockProductService;
        private readonly DataTransferManager _saleManager;
        private readonly ReportAndFailAddManager _reportAdd;
        private readonly FailReportManager _failreport;

        public SaleDisplay()
        {
            InitializeComponent();
            InitializeBarcodeReader();
            InitializeDataGridView();

            _stockProductService = new StockProductManager(new StockProductsDal());
            _saleManager = new DataTransferManager(new SaleDal());
            _reportAdd = new ReportAndFailAddManager(new ReportDal());
            _failreport = new FailReportManager(new FailReportDal());
        }
        decimal totalPrice;
        private void SaleDisplay_Load(object sender, EventArgs e)
        {
        }

        private void InitializeBarcodeReader()
        {
            barcodeReader = new ZXing.BarcodeReader();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            }
            else
            {
                MessageBox.Show("Kamera bulunamadı!");
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("BarcodeNo", "Barkod No");
            dataGridView1.Columns.Add("ProductName", "Ürün Adı");
            dataGridView1.Columns.Add("Price", "Fiyat");
            dataGridView1.Columns.Add("Quantity", "Adet");
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            using (Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone())
            {
                pictureBox1.Image = (Bitmap)bitmap.Clone();
                var result = barcodeReader.Decode(bitmap);
                if (result != null)
                {
                    Invoke(new Action(() =>
                    {
                        textBox1.Text = result.Text;
                        LoadProductByBarcode(result.Text);
                        Task.Run(() => StopCamera()); // Stop the camera on a separate thread
                    }));
                }
            }
        }

        private void StartCamera()
        {
            if (videoSource != null && !videoSource.IsRunning)
            {
                videoSource.Start();
            }
        }

        private async Task StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                await Task.Run(() =>
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    pictureBox1.Image = null;
                });
            }
        }

        private void LoadProductByBarcode(string barcode)
        {
            var product = _stockProductService.GetBarcodeManager(barcode);
            if (product != null)
            {
                bool productExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["BarcodeNo"].Value?.ToString() == barcode)
                    {
                        row.Cells["Quantity"].Value = (int)row.Cells["Quantity"].Value + 1;
                        row.Cells["Price"].Value = product.SalePrice * (int)row.Cells["Quantity"].Value;
                        totalPrice += product.SalePrice;  // Toplam fiyatı güncelle
                        productExists = true;
                        break;
                    }
                }

                if (!productExists)
                {
                    var sale = new Sale
                    {
                        ProductName = product.ProductName,
                        BarcodeNo = barcode,
                        Price = product.SalePrice
                    };

                    _saleManager.Added(sale);
                    dataGridView1.Rows.Add(sale.BarcodeNo, sale.ProductName, sale.Price, 1);
                    totalPrice += sale.Price;  // Toplam fiyatı güncelle
                }

                ClearTextFields();
                UpdateTotalPriceLabel();
            }
            else
            {
                MessageBox.Show("Ürün bulunamadı!");
            }
        }
        private void UpdateTotalPriceLabel()
        {
            
                label1.Text = $"Toplam Fiyat: {totalPrice:C2}";
            
        }

        private void ClearTextFields()
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void SaleOperationsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Task.Run(() => StopCamera()).Wait(); // Stop the camera on form closing
        }

        private void SaleOperationsPage_Load(object sender, EventArgs e)
        {
        }

        private void svgImageBox1_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadProductByBarcode(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DateTime saleDate = DateTime.Now;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string barcode = row.Cells["BarcodeNo"].Value?.ToString();
                string productName = row.Cells["ProductName"].Value?.ToString();
                string priceString = row.Cells["Price"].Value?.ToString();
                string quantityString = row.Cells["Quantity"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(barcode) || string.IsNullOrWhiteSpace(productName) ||
                    string.IsNullOrWhiteSpace(priceString) || string.IsNullOrWhiteSpace(quantityString))
                {
                    // Boş veya null değerlerle karşılaşıldığında işlem yapmadan devam et
                    continue;
                }

                int quantity = 0;
                if (!int.TryParse(quantityString, out quantity))
                {
                    // Handle parse error or set default quantity
                    quantity = 1;
                }

                decimal price = 0;
                if (!decimal.TryParse(priceString, out price))
                {
                    // Handle parse error or set default price
                    price = 0;
                }

                var sale = new Sale
                {
                    ProductName = productName,
                    Price = price
                };

                _saleManager.Added(sale);

                var product = _stockProductService.GetBarcodeManager(barcode);
                if (product != null)
                {
                    var stockSale = new Report
                    {

                        ProductName = product.ProductName,
                        BarcodeNo = product.BarcodeNo,
                        PurchasePrice = product.PurchasePrice,
                        SalePrice = product.SalePrice,
                        SaleDate = saleDate,
                        BrandName = product.BrandName,
                        CategoryName = product.CategoryName,
                        Amount = quantity,
                        PurchaseDate = product.PurchaseData,
                        SaleCashRegister = button3.Text
                    };
                    var failreport = new FailReport
                    {
                        ProductName = product.ProductName,
                        BarcodeNo = product.BarcodeNo,
                        CategoryName = product.CategoryName,
                        BrandName = product.BrandName,
                        Amount = quantity,
                        PurchaseData = product.PurchaseData,
                        SaleData = saleDate,
                        SalePrice = product.SalePrice,
                        PurchasePrice = product.SalePrice,
                        Session = Global.sessions,
                        SessionName=Global.LoggedInUsername
                    

                    };
                    _failreport.Added(failreport);
                    _reportAdd.Added(stockSale);
                   
                }
            }

            dataGridView1.Rows.Clear();
            totalPrice = 0;  // Toplam fiyatı sıfırla
            UpdateTotalPriceLabel();
            _saleManager.AllDelete();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime saleDate = DateTime.Now;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string barcode = row.Cells["BarcodeNo"].Value?.ToString();
                string productName = row.Cells["ProductName"].Value?.ToString();
                string priceString = row.Cells["Price"].Value?.ToString();
                string quantityString = row.Cells["Quantity"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(barcode) || string.IsNullOrWhiteSpace(productName) ||
                    string.IsNullOrWhiteSpace(priceString) || string.IsNullOrWhiteSpace(quantityString))
                {
                    // Boş veya null değerlerle karşılaşıldığında işlem yapmadan devam et
                    continue;
                }

                int quantity = 0;
                if (!int.TryParse(quantityString, out quantity))
                {
                    // Handle parse error or set default quantity
                    quantity = 1;
                }

                decimal price = 0;
                if (!decimal.TryParse(priceString, out price))
                {
                    // Handle parse error or set default price
                    price = 0;
                }

                var sale = new Sale
                {
                    ProductName = productName,
                    Price = price
                };

                _saleManager.Added(sale);

                var product = _stockProductService.GetBarcodeManager(barcode);
                if (product != null)
                {
                    var stockSale = new Report
                    {

                        ProductName = product.ProductName,
                        BarcodeNo = product.BarcodeNo,
                        PurchasePrice = product.PurchasePrice,
                        SalePrice = product.SalePrice,
                        SaleDate = saleDate,
                        BrandName = product.BrandName,
                        CategoryName = product.CategoryName,
                        Amount = quantity,
                        PurchaseDate = product.PurchaseData,
                        SaleCashRegister = button2.Text
                    };
                    var failreport = new FailReport
                    {
                        ProductName = product.ProductName,
                        BarcodeNo = product.BarcodeNo,
                        CategoryName = product.CategoryName,
                        BrandName = product.BrandName,
                        Amount = quantity,
                        PurchaseData = product.PurchaseData,
                        SaleData = saleDate,
                        SalePrice = product.SalePrice,
                        PurchasePrice = product.SalePrice,
                        Session = Global.sessions,
                        SessionName = Global.LoggedInUsername


                    };
                    _failreport.Added(failreport);

                    _reportAdd.Added(stockSale);
                }
            }

            dataGridView1.Rows.Clear();
            totalPrice = 0;  // Toplam fiyatı sıfırla
            UpdateTotalPriceLabel();
            _saleManager.AllDelete();



        }

    }
    }
