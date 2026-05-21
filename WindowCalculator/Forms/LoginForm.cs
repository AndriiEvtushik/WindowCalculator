using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WindowCalculator
{
    public partial class LoginForm : Form
    {
        public string Role = string.Empty;

        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT Role FROM Users WHERE Login = @l AND Password = @p";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@l", txtLogin.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                var result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    Role = result.ToString() ?? string.Empty;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Невірний логін або пароль! Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
