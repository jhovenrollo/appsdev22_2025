using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static oralHygiene.Main;
using System.Security.Cryptography;


namespace oralHygiene
{
    public partial class Login: Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abell\OneDrive\Documents\hotel.mdf;Integrated Security=True;Connect Timeout=30";
        public Login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Instacon_Click(object sender, EventArgs e)
        {

        }

        private void FaceCon_Click(object sender, EventArgs e)
        {

        }

        private void EmailCon_Click(object sender, EventArgs e)
        {

        }

        private void ContaCon_Click(object sender, EventArgs e)
        {

        }

       

        private void register_btn_Click(object sender, EventArgs e)
        {

            Register loginForm = new Register();
            loginForm.Show();
            this.Hide();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text.Trim();
            string password = login_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string hashedPassword = HashPassword(password);

                    string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Main dashboardForm = new Main();
                                dashboardForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void LoginShowPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = LoginShowPass.Checked ? '\0' : '*';
            login_password.PasswordChar = LoginShowPass.Checked ? '\0' : '*';
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
