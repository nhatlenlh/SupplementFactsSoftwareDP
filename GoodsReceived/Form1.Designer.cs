namespace GoodsReceived
{
	partial class GoodsReceivedForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Products = new System.Windows.Forms.DataGridView();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.ProductIdInput = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ProductNameInput = new System.Windows.Forms.TextBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.ResetBtn = new System.Windows.Forms.Button();
			this.ProductPriceInput = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.AddReceiptBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ProductQuantityInput = new System.Windows.Forms.TextBox();
			this.ResetAllBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
			this.SuspendLayout();
			// 
			// Products
			// 
			this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductPrice,
            this.ProductQuantity});
			this.Products.Location = new System.Drawing.Point(439, 123);
			this.Products.Name = "Products";
			this.Products.ReadOnly = true;
			this.Products.RowHeadersWidth = 51;
			this.Products.RowTemplate.Height = 24;
			this.Products.Size = new System.Drawing.Size(741, 209);
			this.Products.TabIndex = 0;
			this.Products.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Products_RowsAdded);
			// 
			// ProductID
			// 
			this.ProductID.HeaderText = "ProductID";
			this.ProductID.MinimumWidth = 6;
			this.ProductID.Name = "ProductID";
			this.ProductID.ReadOnly = true;
			this.ProductID.Width = 125;
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "ProductName";
			this.ProductName.MinimumWidth = 6;
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			this.ProductName.Width = 125;
			// 
			// ProductPrice
			// 
			this.ProductPrice.HeaderText = "ProductPrice";
			this.ProductPrice.MinimumWidth = 6;
			this.ProductPrice.Name = "ProductPrice";
			this.ProductPrice.ReadOnly = true;
			this.ProductPrice.Width = 125;
			// 
			// ProductQuantity
			// 
			this.ProductQuantity.HeaderText = "ProductQuantity";
			this.ProductQuantity.MinimumWidth = 6;
			this.ProductQuantity.Name = "ProductQuantity";
			this.ProductQuantity.ReadOnly = true;
			this.ProductQuantity.Width = 125;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Product ID";
			// 
			// ProductIdInput
			// 
			this.ProductIdInput.Location = new System.Drawing.Point(138, 123);
			this.ProductIdInput.Name = "ProductIdInput";
			this.ProductIdInput.Size = new System.Drawing.Size(242, 22);
			this.ProductIdInput.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label3.Location = new System.Drawing.Point(398, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(325, 34);
			this.label3.TabIndex = 5;
			this.label3.Text = "GOODS RECEIVED FORM";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Product Name";
			// 
			// ProductNameInput
			// 
			this.ProductNameInput.Location = new System.Drawing.Point(138, 181);
			this.ProductNameInput.Name = "ProductNameInput";
			this.ProductNameInput.Size = new System.Drawing.Size(242, 22);
			this.ProductNameInput.TabIndex = 7;
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(138, 374);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(113, 38);
			this.AddBtn.TabIndex = 8;
			this.AddBtn.Text = "Add Product";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// ResetBtn
			// 
			this.ResetBtn.Location = new System.Drawing.Point(274, 374);
			this.ResetBtn.Name = "ResetBtn";
			this.ResetBtn.Size = new System.Drawing.Size(106, 38);
			this.ResetBtn.TabIndex = 9;
			this.ResetBtn.Text = "Reset";
			this.ResetBtn.UseVisualStyleBackColor = true;
			this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
			// 
			// ProductPriceInput
			// 
			this.ProductPriceInput.Location = new System.Drawing.Point(138, 244);
			this.ProductPriceInput.Name = "ProductPriceInput";
			this.ProductPriceInput.Size = new System.Drawing.Size(242, 22);
			this.ProductPriceInput.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Product Price";
			// 
			// AddReceiptBtn
			// 
			this.AddReceiptBtn.Location = new System.Drawing.Point(138, 434);
			this.AddReceiptBtn.Name = "AddReceiptBtn";
			this.AddReceiptBtn.Size = new System.Drawing.Size(113, 38);
			this.AddReceiptBtn.TabIndex = 12;
			this.AddReceiptBtn.Text = "Export Receipt";
			this.AddReceiptBtn.UseVisualStyleBackColor = true;
			this.AddReceiptBtn.Click += new System.EventHandler(this.AddReceiptBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 313);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 13;
			this.label1.Text = "Product Quantity";
			// 
			// ProductQuantityInput
			// 
			this.ProductQuantityInput.Location = new System.Drawing.Point(138, 310);
			this.ProductQuantityInput.Name = "ProductQuantityInput";
			this.ProductQuantityInput.Size = new System.Drawing.Size(242, 22);
			this.ProductQuantityInput.TabIndex = 14;
			// 
			// ResetAllBtn
			// 
			this.ResetAllBtn.Location = new System.Drawing.Point(274, 434);
			this.ResetAllBtn.Name = "ResetAllBtn";
			this.ResetAllBtn.Size = new System.Drawing.Size(106, 38);
			this.ResetAllBtn.TabIndex = 15;
			this.ResetAllBtn.Text = "Reset All";
			this.ResetAllBtn.UseVisualStyleBackColor = true;
			this.ResetAllBtn.Click += new System.EventHandler(this.ResetAllBtn_Click);
			// 
			// GoodsReceivedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 525);
			this.Controls.Add(this.ResetAllBtn);
			this.Controls.Add(this.ProductQuantityInput);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddReceiptBtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ProductPriceInput);
			this.Controls.Add(this.ResetBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.ProductNameInput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ProductIdInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Products);
			this.Name = "GoodsReceivedForm";
			this.Text = "GoodsReceived";
			this.Load += new System.EventHandler(this.GoodsReceivedForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView Products;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ProductIdInput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ProductNameInput;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Button ResetBtn;
		private System.Windows.Forms.TextBox ProductPriceInput;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button AddReceiptBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ProductQuantityInput;
		private System.Windows.Forms.Button ResetAllBtn;
	}
}

