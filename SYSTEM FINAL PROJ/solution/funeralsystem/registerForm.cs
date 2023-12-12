using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace funeralsystem
{
    public partial class registerForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cynth\Desktop\client.mdf;Integrated Security=True;Connect Timeout=30");
        public registerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showpass.Checked ? '\0' : '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginbtn_Click(object sender, EventArgs e)
        {
            Form1 LoginForm = new Form1();
            LoginForm.Show();
            this.Hide();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == ""
               || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT COUNT(id) FROM Client WHERE username =@Client";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@client", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + "is already exist"
                    , "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                String insertData = "INSERT INTO Client" +
                                    "(username, password, date_register)" +
                                    "VALUES(@username, @password, @date_register)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date_register", today);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registered successfully!",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginform = new Form1();
                                    loginform.Show();
                                    this.Hide();


                                }
                            }



                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error" + ex
                  , "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }
        public string enryptpass(string password)
        {
            string msg = "";
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            msg = Convert.ToBase64String(encode);
            return msg;
        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
