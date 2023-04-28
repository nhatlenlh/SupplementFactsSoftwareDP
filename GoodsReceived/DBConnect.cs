using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System;

namespace GoodsReceived
{
	public class DBConnect
	{
		public static SqlConnection myConn = null;

		public void CreateConnection()
		{
			var connectionString = ConfigurationManager.ConnectionStrings["DevConn"].ConnectionString;

			myConn = new SqlConnection(connectionString);
			myConn.Open();
		}

		public void AddProduct(SqlCommand cmd, DataGridViewRow productRow)
		{
			cmd.CommandText = "Execute spProductCreate @productId, @productName, @productPrice, @productQuantity";

			cmd.Parameters.Add("@productId", SqlDbType.VarChar, 10).Value = productRow.Cells[0].Value;
			cmd.Parameters.Add("@productName", SqlDbType.NVarChar, 50).Value = productRow.Cells[1].Value;
			cmd.Parameters.Add("@productPrice", SqlDbType.Int).Value = productRow.Cells[2].Value;
			cmd.Parameters.Add("@productQuantity", SqlDbType.Int).Value = productRow.Cells[3].Value;

			cmd.ExecuteNonQuery();
			cmd.Parameters.Clear();
		}

		public int AddReceipt(SqlCommand cmd, int totalWarehousePrice, int totalWarehouseQuantity)
		{
			cmd.CommandText = "Execute spWarehouseReceipt @totalWarehouseQuantity, @totalWarehousePrice, @createdDate";

			cmd.Parameters.Add("@totalWarehouseQuantity", SqlDbType.Int).Value = totalWarehouseQuantity;
			cmd.Parameters.Add("@totalWarehousePrice", SqlDbType.Int).Value = totalWarehousePrice;
			// dd/mm/yyyy
			cmd.Parameters.Add("@createdDate", SqlDbType.Date).Value = DateTime.Today.ToString("D");

			int id = Convert.ToInt32(cmd.ExecuteScalar());

			cmd.Parameters.Clear();

			return id;
		}

		public void AddReceiptDetail(SqlCommand cmd, DataGridView products, int receiptId)
		{
			cmd.CommandText = "Execute spIncludeImportedProducts @totalProductQuantity, @totalProductPrice, @receiptId, @productId";

			for (int row = 0; row < products.Rows.Count - 1; row++)
			{
				string productId = products.Rows[row].Cells[0].Value.ToString();
				int totalProductQuantity = Convert.ToInt32(products.Rows[row].Cells[3].Value);
				int totalProductPrice = Convert.ToInt32(products.Rows[row].Cells[2].Value) * totalProductQuantity;

				cmd.Parameters.Add("@totalProductQuantity", SqlDbType.Int).Value = totalProductQuantity;
				cmd.Parameters.Add("@totalProductPrice", SqlDbType.Int).Value = totalProductPrice;
				cmd.Parameters.Add("@receiptId", SqlDbType.Int).Value = receiptId;
				cmd.Parameters.Add("@productId", SqlDbType.VarChar, 10).Value = productId;

				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
			}
		}
	}
}
