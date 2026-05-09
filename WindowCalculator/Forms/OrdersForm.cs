using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowCalculator.Forms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders(string search = "")
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Orders";

                if (!string.IsNullOrEmpty(search))
                {
                    query += " WHERE CAST(Id AS NVARCHAR) LIKE @s OR CAST(TotalPrice AS NVARCHAR) LIKE @s";
                }

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                if (!string.IsNullOrEmpty(search))
                    da.SelectCommand.Parameters.AddWithValue("@s", "%" + search + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOrders(txtSearch.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using (SqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Orders WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                LoadOrders();
            }
        }
    }
}
