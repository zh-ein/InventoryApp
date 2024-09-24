namespace InventoryApp
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            cbCategory = new ComboBox();
            gridViewProductList = new DataGridView();
            richTxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 83);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 0;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 125);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 0;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 169);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 0;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 213);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 0;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 259);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 0;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 306);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 0;
            label7.Text = "Sell Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(501, 86);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 0;
            label8.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(127, 80);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(317, 31);
            txtProductName.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(127, 256);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(317, 31);
            txtQuantity.TabIndex = 1;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(127, 300);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(317, 31);
            txtSellPrice.TabIndex = 1;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(127, 163);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(317, 31);
            dtPickerMfgDate.TabIndex = 2;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(127, 207);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(317, 31);
            dtPickerExpDate.TabIndex = 2;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(127, 122);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(317, 33);
            cbCategory.TabIndex = 3;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(33, 377);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.RowHeadersWidth = 62;
            gridViewProductList.Size = new Size(853, 208);
            gridViewProductList.TabIndex = 4;
            gridViewProductList.CellContentClick += gridViewProductList_CellContentClick;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(501, 114);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(385, 217);
            richTxtDescription.TabIndex = 5;
            richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(732, 337);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(154, 34);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click_1;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 597);
            Controls.Add(btnAddProduct);
            Controls.Add(richTxtDescription);
            Controls.Add(gridViewProductList);
            Controls.Add(cbCategory);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddProduct";
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private ComboBox cbCategory;
        private DataGridView gridViewProductList;
        private RichTextBox richTxtDescription;
        private Button btnAddProduct;
    }
}
