using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using MarketDatabse.Business.StockDisplay;
using MarketDatabase.Entities;
using MarketDatabase.DataAccess;
using MarketDatabase.Entities.Concreate;

namespace MarketDatabase.FormUI
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private BarcodeReader barcodeReader;
        StockProductManager _stockProductService = new StockProductManager(new StockProductsDal());

        public Form1()
        {
            InitializeComponent();
            InitializeBarcodeReader();
            
        }

        private void InitializeBarcodeReader()
        {
            barcodeReader = new BarcodeReader();
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
                        txtBarcodeNo.Text = result.Text;
                        LoadProductByBarcode(result.Text);
                        StopCamera();
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

        private void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBox1.Image=null; 
            }
        }

        private void LoadProductByBarcode(string barcode)
        {
            var product = _stockProductService.GetBarcodeManager(barcode);
            if (product != null)
            {
                txtStockId.Text = product.StokId.ToString();
                txtBarcodeNo.Text = product.BarcodeNo;
                txtBrandName.Text = product.BrandName;
                txtCategoryName.Text = product.CategoryName;
                txtProductName.Text = product.ProductName;
                txtAmount.Text = product.Amount.ToString();
                txtPurchasePrice.Text = product.PurchasePrice.ToString();
                txtSalePirce.Text = product.SalePrice.ToString();
                txtPurchaseDate.Text = product.PurchaseData.ToString();
            }
            else
            {
                MessageBox.Show("Ürün bulunamadı!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        // Diğer metodlarınızı buraya ekleyin
        StockProductManager _manager = new StockProductManager(new StockProductsDal());

        protected void GetData()
        {
            dataGridView1.DataSource = _manager.GetProduct();
        }

        protected void TextClear()
        {
            txtStockId.Clear();
            txtBarcodeNo.Clear();
            txtBrandName.Clear();
            txtCategoryName.Clear();
            txtProductName.Clear();
            txtAmount.Clear();
            txtPurchasePrice.Clear();
            txtPurchaseDate.Clear();
            txtSalePirce.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnAdded_Click(object sender, EventArgs e)
        {
           
            try
            {
                _manager.Added(new StockProduct
                {
                    BarcodeNo = txtBarcodeNo.Text,
                    BrandName = txtBrandName.Text,
                    CategoryName = txtCategoryName.Text,
                    ProductName = txtProductName.Text,
                    Amount = Convert.ToInt32(txtAmount.Text),
                    PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                    SalePrice = Convert.ToDecimal(txtSalePirce.Text),
                    PurchaseData = Convert.ToDateTime(txtPurchaseDate.Text),
                });
                MessageBox.Show("Ürün başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData();
                TextClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata,Ürün Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = dataGridView1.CurrentRow;
            txtStockId.Text = rows.Cells[0].Value.ToString();
            txtBarcodeNo.Text = rows.Cells[1].Value.ToString();
            txtBrandName.Text = rows.Cells[2].Value.ToString();
            txtCategoryName.Text = rows.Cells[3].Value.ToString();
            txtProductName.Text = rows.Cells[4].Value.ToString();
            txtAmount.Text = rows.Cells[5].Value.ToString();
            txtPurchasePrice.Text = rows.Cells[6].Value.ToString();
            txtSalePirce.Text = rows.Cells[7].Value.ToString();
            txtPurchaseDate.Text = rows.Cells[8].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _manager.Update(new StockProduct
            {
                StokId = Convert.ToInt32(txtStockId.Text),
                BarcodeNo = txtBarcodeNo.Text,
                BrandName = txtBrandName.Text,
                CategoryName = txtCategoryName.Text,
                ProductName = txtProductName.Text,
                Amount = Convert.ToInt32(txtAmount.Text),
                PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                SalePrice = Convert.ToDecimal(txtSalePirce.Text),
                PurchaseData = Convert.ToDateTime(txtPurchaseDate.Text),
            });
            MessageBox.Show("Ürün başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetData();
            TextClear();
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                btnDeleted.Enabled = true;
                _manager.Delete(new StockProduct
                {
                    StokId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString())
                });
            }
            else
            {
                btnDeleted.Enabled = false;
            }
            GetData();
            TextClear();
            MessageBox.Show("Ürün Başarıyla Silindi");
        }

        private void btnNowTime_Click(object sender, EventArgs e)
        {
            txtPurchaseDate.Text = DateTime.Now.ToString();
        }

        private void txtSearchCategori_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchCategori.Text))
            {
                dataGridView1.DataSource = _manager.GetCategories(txtSearchCategori.Text);
            }
            else
            {
                GetData();
            }
        }

        private void txtSaarchProductName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSaarchProductName.Text))
            {
                dataGridView1.DataSource = _manager.GetProductName(txtSaarchProductName.Text);
            }
            else
            {
                GetData();
            }
        }

        private void txtSearchBrandName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchBrandName.Text))
            {
                dataGridView1.DataSource = _manager.GetBrandName(txtSearchBrandName.Text);
            }
            else
            {
                GetData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
