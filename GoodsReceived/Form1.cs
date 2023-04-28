using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GoodsReceived
{
	public partial class GoodsReceivedForm : Form
	{
		public GoodsReceivedForm()
		{
			InitializeComponent();
		}

		private void GoodsReceivedForm_Load(object sender, EventArgs e)
		{
			AddReceiptBtn.Enabled = false;
			ResetAllBtn.Enabled = false;
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			if (CheckValidationProductInput())
			{
				string productId = ProductIdInput.Text;
				string productName = ProductNameInput.Text;
				string productQuantity = ProductQuantityInput.Text;
				string productPrice = ProductPriceInput.Text;

				Products.Rows.Add(productId, productName, productPrice, productQuantity);

				ResetBtn_Click(null, null);
			}
		}

		bool CheckValidationProductInput()
		{
			if (ProductIdInput.Text == "")
			{
				MessageBox.Show("Please enter product id");
				ProductIdInput.Focus();
				return false;
			}
			else if (ProductNameInput.Text == "")
			{
				MessageBox.Show("Please enter product name");
				ProductNameInput.Focus();
				return false;
			}
			else if (ProductPriceInput.Text == "" || !IsNumber(ProductPriceInput.Text))
			{
				MessageBox.Show("Please enter right product price");
				ProductPriceInput.Focus();
				return false;
			}
			else if (ProductQuantityInput.Text == "" || !IsNumber(ProductQuantityInput.Text))
			{
				MessageBox.Show("Please enter right product quantity");
				ProductQuantityInput.Focus();
				return false;
			}

			return true;
		}

		bool IsNumber(string text)
		{
			Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
			return regex.IsMatch(text);
		}

		private void ResetBtn_Click(object sender, EventArgs e)
		{
			ProductPriceInput.Text = "";
			ProductNameInput.Text = "";
			ProductIdInput.Text = "";
			ProductQuantityInput.Text = "";
		}

		private void ResetAllBtn_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to reset all products ?", "Confirm reset", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				Products.Rows.Clear();
				ResetBtn_Click(null, null);
			}
		}

		private void Products_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (Products.Rows.Count > 1)
			{
				AddReceiptBtn.Enabled = true;
				ResetAllBtn.Enabled = true;
			}
			else
			{
				AddReceiptBtn.Enabled = false;
				ResetAllBtn.Enabled = false;
			}
		}

		private void AddReceiptBtn_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to add this receipt?", "Confirm add", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				DBConnect dbConnect = new DBConnect();
				dbConnect.CreateConnection();
				SqlConnection conn = DBConnect.myConn;

				SqlCommand cmd = conn.CreateCommand();
				
				int totalWarehouseQuantity = 0;
				int totalWarehousePrice = 0;

				for (int row = 0; row < Products.Rows.Count - 1; row++)
				{
					dbConnect.AddProduct(cmd, Products.Rows[row]);

					totalWarehousePrice += Convert.ToInt32(Products.Rows[row].Cells[2].Value) * Convert.ToInt32(Products.Rows[row].Cells[3].Value);
					totalWarehouseQuantity += Convert.ToInt32(Products.Rows[row].Cells[3].Value);
				}

				int receiptId = dbConnect.AddReceipt(cmd, totalWarehousePrice, totalWarehouseQuantity);

				dbConnect.AddReceiptDetail(cmd, Products, receiptId);

				conn.Close();

				MessageBox.Show("Add receipt succesfully!");

				ExportExcel(receiptId);

				Products.Rows.Clear();
			}
		}

		private void ExportExcel(int receiptId)
		{
			// creating Excel Application  
			Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
			
			// creating new WorkBook within Excel application  
			Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
			
			// creating new Excelsheet in workbook  
			Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
			
			// see the excel sheet behind the program  
			app.Visible = true;
			
			// get the reference of first sheet. By default its name is Sheet1.  
			// store its reference to worksheet  
			worksheet = workbook.Sheets["Sheet1"];
			worksheet = workbook.ActiveSheet;
			
			// changing the name of active sheet  
			worksheet.Name = "Exported from gridview";

			// storing header part in Excel
			int i, j = 0;

			for (i = 1; i < Products.Columns.Count + 1; i++)
			{
				worksheet.Cells[1, i] = Products.Columns[i - 1].HeaderText;
			}
			worksheet.Cells[1, i + 1] = "WarehouseReceiptID";
			
			// storing Each row and column value to excel sheet  
			for (i = 0; i < Products.Rows.Count - 1; i++)
			{
				for (j = 0; j < Products.Columns.Count; j++)
				{
					worksheet.Cells[i + 2, j + 1] = Products.Rows[i].Cells[j].Value.ToString();
				}
			}
			worksheet.Cells[2, j + 2] = receiptId;

			string currDateTime = DateTime.Now.ToString("dd MM yyyy hh mm ss");
			string savepath = System.IO.Path.GetFullPath(currDateTime + ".xlsx"); 

			// save the application  
			workbook.SaveAs(savepath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			// Exit from the application  
			app.Quit();
		}
	}
}
