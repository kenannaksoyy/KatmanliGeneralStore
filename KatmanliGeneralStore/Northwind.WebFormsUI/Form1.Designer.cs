namespace Northwind.WebFormsUI
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.lblCategoryNameAdd = new System.Windows.Forms.Label();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.lblStockAmountAdd = new System.Windows.Forms.Label();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.tbxStockAmountAdd = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryNameUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(35, 188);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(1049, 188);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(35, 26);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(512, 75);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(35, 107);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(512, 75);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Ara";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(53, 34);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(168, 31);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(323, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(53, 34);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(58, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(168, 31);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(323, 22);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.cbxCategoryAdd);
            this.gbxProductAdd.Controls.Add(this.btnProductAdd);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.tbxStockAmountAdd);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.lblStockAmountAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblCategoryNameAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxProductAdd.Location = new System.Drawing.Point(35, 445);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(346, 238);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(6, 48);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(58, 16);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Ürün Adı";
            // 
            // lblCategoryNameAdd
            // 
            this.lblCategoryNameAdd.AutoSize = true;
            this.lblCategoryNameAdd.Location = new System.Drawing.Point(6, 76);
            this.lblCategoryNameAdd.Name = "lblCategoryNameAdd";
            this.lblCategoryNameAdd.Size = new System.Drawing.Size(57, 16);
            this.lblCategoryNameAdd.TabIndex = 1;
            this.lblCategoryNameAdd.Text = "Kategori";
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(6, 104);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(36, 16);
            this.lblUnitPriceAdd.TabIndex = 2;
            this.lblUnitPriceAdd.Text = "Fiyat";
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(105, 45);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(149, 22);
            this.tbxProductNameAdd.TabIndex = 3;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(105, 101);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(149, 22);
            this.tbxUnitPriceAdd.TabIndex = 5;
            // 
            // lblStockAmountAdd
            // 
            this.lblStockAmountAdd.AutoSize = true;
            this.lblStockAmountAdd.Location = new System.Drawing.Point(6, 132);
            this.lblStockAmountAdd.Name = "lblStockAmountAdd";
            this.lblStockAmountAdd.Size = new System.Drawing.Size(73, 16);
            this.lblStockAmountAdd.TabIndex = 6;
            this.lblStockAmountAdd.Text = "Stok Adedi";
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(6, 160);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(76, 16);
            this.lblQuantityPerUnitAdd.TabIndex = 7;
            this.lblQuantityPerUnitAdd.Text = "Birim Adedi";
            // 
            // tbxStockAmountAdd
            // 
            this.tbxStockAmountAdd.Location = new System.Drawing.Point(105, 129);
            this.tbxStockAmountAdd.Name = "tbxStockAmountAdd";
            this.tbxStockAmountAdd.Size = new System.Drawing.Size(149, 22);
            this.tbxStockAmountAdd.TabIndex = 8;
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(105, 157);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(149, 22);
            this.tbxQuantityPerUnitAdd.TabIndex = 9;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(105, 185);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(149, 36);
            this.btnProductAdd.TabIndex = 10;
            this.btnProductAdd.Text = "Ürün Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(105, 73);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(149, 24);
            this.cbxCategoryAdd.TabIndex = 11;
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.cbxCategoryUpdate);
            this.gbxProductUpdate.Controls.Add(this.btnProductUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxStockAmountUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblStockAmountUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblCategoryNameUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblProductNameUpdate);
            this.gbxProductUpdate.Location = new System.Drawing.Point(396, 445);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(346, 238);
            this.gbxProductUpdate.TabIndex = 4;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Ürün Güncelle";
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(105, 73);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(149, 24);
            this.cbxCategoryUpdate.TabIndex = 11;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(105, 185);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(149, 36);
            this.btnProductUpdate.TabIndex = 10;
            this.btnProductUpdate.Text = "Ürün Güncelle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(105, 157);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(149, 22);
            this.tbxQuantityPerUnitUpdate.TabIndex = 9;
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(105, 129);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(149, 22);
            this.tbxStockAmountUpdate.TabIndex = 8;
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(6, 160);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(76, 16);
            this.lblQuantityPerUnitUpdate.TabIndex = 7;
            this.lblQuantityPerUnitUpdate.Text = "Birim Adedi";
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(6, 132);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(73, 16);
            this.lblStockAmountUpdate.TabIndex = 6;
            this.lblStockAmountUpdate.Text = "Stok Adedi";
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(105, 101);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(149, 22);
            this.tbxUnitPriceUpdate.TabIndex = 5;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(105, 45);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(149, 22);
            this.tbxProductNameUpdate.TabIndex = 3;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(6, 104);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(36, 16);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Fiyat";
            // 
            // lblCategoryNameUpdate
            // 
            this.lblCategoryNameUpdate.AutoSize = true;
            this.lblCategoryNameUpdate.Location = new System.Drawing.Point(6, 76);
            this.lblCategoryNameUpdate.Name = "lblCategoryNameUpdate";
            this.lblCategoryNameUpdate.Size = new System.Drawing.Size(57, 16);
            this.lblCategoryNameUpdate.TabIndex = 1;
            this.lblCategoryNameUpdate.Text = "Kategori";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(6, 48);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(58, 16);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(926, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Seçili Ürünü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 792);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.TextBox tbxStockAmountAdd;
        private System.Windows.Forms.Label lblQuantityPerUnitAdd;
        private System.Windows.Forms.Label lblStockAmountAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblCategoryNameAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblCategoryNameUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

