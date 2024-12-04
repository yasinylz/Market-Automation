namespace MarketDatabase.FormUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearchCategori = new System.Windows.Forms.TextBox();
            this.txtSaarchProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcodeNo = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtSalePirce = new System.Windows.Forms.TextBox();
            this.txtPurchaseDate = new System.Windows.Forms.TextBox();
            this.btnAdded = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleted = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNowTime = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStockId = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchBrandName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1183, 309);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtSearchCategori
            // 
            this.txtSearchCategori.Location = new System.Drawing.Point(180, 10);
            this.txtSearchCategori.Name = "txtSearchCategori";
            this.txtSearchCategori.Size = new System.Drawing.Size(156, 20);
            this.txtSearchCategori.TabIndex = 1;
            this.txtSearchCategori.TextChanged += new System.EventHandler(this.txtSearchCategori_TextChanged);
            // 
            // txtSaarchProductName
            // 
            this.txtSaarchProductName.Location = new System.Drawing.Point(180, 36);
            this.txtSaarchProductName.Name = "txtSaarchProductName";
            this.txtSaarchProductName.Size = new System.Drawing.Size(156, 20);
            this.txtSaarchProductName.TabIndex = 2;
            this.txtSaarchProductName.TextChanged += new System.EventHandler(this.txtSaarchProductName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KATEGORİYE GÖRE ARA : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÜRÜN İSMİNE GÖRE ARA :";
            // 
            // txtBarcodeNo
            // 
            this.txtBarcodeNo.Location = new System.Drawing.Point(446, 43);
            this.txtBarcodeNo.Name = "txtBarcodeNo";
            this.txtBarcodeNo.Size = new System.Drawing.Size(113, 20);
            this.txtBarcodeNo.TabIndex = 6;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(446, 121);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(113, 20);
            this.txtProductName.TabIndex = 9;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(446, 150);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(113, 20);
            this.txtAmount.TabIndex = 10;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(446, 176);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(113, 20);
            this.txtPurchasePrice.TabIndex = 11;
            // 
            // txtSalePirce
            // 
            this.txtSalePirce.Location = new System.Drawing.Point(446, 202);
            this.txtSalePirce.Name = "txtSalePirce";
            this.txtSalePirce.Size = new System.Drawing.Size(113, 20);
            this.txtSalePirce.TabIndex = 12;
            // 
            // txtPurchaseDate
            // 
            this.txtPurchaseDate.Location = new System.Drawing.Point(446, 229);
            this.txtPurchaseDate.Name = "txtPurchaseDate";
            this.txtPurchaseDate.Size = new System.Drawing.Size(113, 20);
            this.txtPurchaseDate.TabIndex = 13;
            // 
            // btnAdded
            // 
            this.btnAdded.Location = new System.Drawing.Point(66, 126);
            this.btnAdded.Name = "btnAdded";
            this.btnAdded.Size = new System.Drawing.Size(75, 23);
            this.btnAdded.TabIndex = 14;
            this.btnAdded.Text = "Add";
            this.btnAdded.UseVisualStyleBackColor = true;
            this.btnAdded.Click += new System.EventHandler(this.btnAdded_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(147, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Location = new System.Drawing.Point(227, 126);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(75, 23);
            this.btnDeleted.TabIndex = 16;
            this.btnDeleted.Text = "Delet";
            this.btnDeleted.UseVisualStyleBackColor = true;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Purchase Price : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sale Price : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Product Name : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Amount  : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Purchase Data : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Barcode No : ";
            // 
            // btnNowTime
            // 
            this.btnNowTime.Location = new System.Drawing.Point(446, 252);
            this.btnNowTime.Name = "btnNowTime";
            this.btnNowTime.Size = new System.Drawing.Size(65, 22);
            this.btnNowTime.TabIndex = 18;
            this.btnNowTime.Text = "Now Time";
            this.btnNowTime.UseVisualStyleBackColor = true;
            this.btnNowTime.Click += new System.EventHandler(this.btnNowTime_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Stock  Id: ";
            // 
            // txtStockId
            // 
            this.txtStockId.Location = new System.Drawing.Point(446, 17);
            this.txtStockId.Name = "txtStockId";
            this.txtStockId.Size = new System.Drawing.Size(113, 20);
            this.txtStockId.TabIndex = 19;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(446, 96);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(113, 20);
            this.txtCategoryName.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Category Name :";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(446, 70);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(113, 20);
            this.txtBrandName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Brand Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ÜRÜN MARKASINA GÖRE ARA :";
            // 
            // txtSearchBrandName
            // 
            this.txtSearchBrandName.Location = new System.Drawing.Point(180, 64);
            this.txtSearchBrandName.Name = "txtSearchBrandName";
            this.txtSearchBrandName.Size = new System.Drawing.Size(156, 20);
            this.txtSearchBrandName.TabIndex = 23;
            this.txtSearchBrandName.TextChanged += new System.EventHandler(this.txtSearchBrandName_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1005, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Update With Barcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(650, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 216);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Filtreleme Ekranına Git";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearchBrandName);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtStockId);
            this.Controls.Add(this.btnNowTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdded);
            this.Controls.Add(this.txtPurchaseDate);
            this.Controls.Add(this.txtSalePirce);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtBarcodeNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaarchProductName);
            this.Controls.Add(this.txtSearchCategori);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchCategori;
        private System.Windows.Forms.TextBox txtSaarchProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarcodeNo;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtSalePirce;
        private System.Windows.Forms.TextBox txtPurchaseDate;
        private System.Windows.Forms.Button btnAdded;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNowTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStockId;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchBrandName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

