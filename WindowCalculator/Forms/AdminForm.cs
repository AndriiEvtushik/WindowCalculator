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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO Materials (Category, Name, Color, PricePerM2, Description) VALUES (@c,@n,@col,@p,@d)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@c", txtCategory.Text);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@col", txtColor.Text);
                cmd.Parameters.AddWithValue("@p", Convert.ToDouble(txtPrice.Text));
                cmd.Parameters.AddWithValue("@d", txtDesc.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Матеріал додано!");
            }
        }
    }
}
