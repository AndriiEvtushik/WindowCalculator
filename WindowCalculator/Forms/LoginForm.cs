using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WindowCalculator
{
    public partial class LoginForm : Form
    {
        public string Role;

        public LoginForm()
        {
            InitializeComponent();
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

                if(result != null)
                {
                    Role = result.ToString();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Невірний логін або пароль! Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
