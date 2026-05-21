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
    public partial class MainForm : Form
    {
        private string Role;
        public MainForm(string role)
        {
            InitializeComponent();
            Role = role;

            if (Role == "manager")
                btnAdmin.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWidth.Text) ||
                string.IsNullOrWhiteSpace(txtHeight.Text) ||
                string.IsNullOrWhiteSpace(txtSections.Text) ||
                string.IsNullOrWhiteSpace(txtOpeningSections.Text) ||
                string.IsNullOrWhiteSpace(txtFramePrice.Text) ||
                string.IsNullOrWhiteSpace(txtGlassPrice.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }
            double width = Convert.ToDouble(txtWidth.Text) / 1000;
            double height = Convert.ToDouble(txtHeight.Text) / 1000;

            int sections = Convert.ToInt32(txtSections.Text);
            int opening = Convert.ToInt32(txtOpeningSections.Text);

            double frame = Convert.ToDouble(txtFramePrice.Text);
            double glass = Convert.ToDouble(txtGlassPrice.Text);

            double area = width * height;
            double total = (area * frame) + (area * glass);

            total *= 1.10;

            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO Orders (Width, Height, Sections, OpeningSections, TotalPrice) VALUES (@w, @h, @s, @o, @t)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@w", width);
                cmd.Parameters.AddWithValue("@h", height);
                cmd.Parameters.AddWithValue("@s", sections);
                cmd.Parameters.AddWithValue("@o", opening);
                cmd.Parameters.AddWithValue("@t", total);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Вартість: " + total.ToString("C"));
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            new MaterialsForm().ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new AdminForm().ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            new OrdersForm().ShowDialog();
        }
    }
}
