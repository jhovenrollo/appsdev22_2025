using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oralHygiene
{
    public partial class Register: Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\abell\OneDrive\Documents\hotel.mdf;Integrated Security=True;Connect Timeout=30";
        public Register()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cpassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (register_password.Text != register_cpassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                         string checkUsern = "SELECT username FROM users WHERE username = @usern";
                        using (SqlCommand checkU = new SqlCommand(checkUsern, connect))
                        {
                            checkU.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                string tempEmail = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show($"{tempEmail} is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string hashedPassword = HashPassword(register_password.Text.Trim());

                                string insertQuery = "INSERT INTO users (username, password, role, status, date_register) " +
                                                     "VALUES (@username, @password, @role, @status, @date_register)";

                                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                                    cmd.Parameters.AddWithValue("@role", "User");
                                    cmd.Parameters.AddWithValue("@status", "Active");
                                    cmd.Parameters.AddWithValue("@date_register", DateTime.Now);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registration successful!");

                                    Main loginForm = new Main();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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


        private void SignUpShowPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = SignUpShowPass.Checked ? '\0' : '*';
            register_cpassword.PasswordChar = SignUpShowPass.Checked ? '\0' : '*';
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}
