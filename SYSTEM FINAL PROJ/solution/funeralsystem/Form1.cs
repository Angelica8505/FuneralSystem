using System;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace funeralsystem
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\cynth\Desktop\client.mdf;Integrated Security = True; Connect Timeout = 30");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (login_username.Text == ""
                || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                   , "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string checkUser = "SELECT * FROM client WHERE username = '" + login_username.Text + "' and password = '" + login_password.Text + "'";


                        using (SqlCommand cmd = new SqlCommand(checkUser, connect))
                        {
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable Dt = new DataTable();
                            sda.Fill(Dt);

                            if (Dt.Rows.Count > 0)
                            {
                                MessageBox.Show("Login successfully",
                                    "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username/password, Please try again!",
                                    "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            login_signupbtn = new Button();
            label6 = new Label();
            login_button = new Button();
            login_showpass = new CheckBox();
            login_password = new TextBox();
            label4 = new Label();
            login_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(72, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(login_signupbtn);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 400);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(72, 8, 138);
            pictureBox1.Image = Properties.Resources.kisspng_headstone_cemetery_funeral_home_death_funeral_5ac757ab403424_254163061523013547263_removebg_preview;
            pictureBox1.Location = new Point(74, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(48, 149);
            label7.Name = "label7";
            label7.Size = new Size(165, 14);
            label7.TabIndex = 2;
            label7.Text = "Funeral Management System";
            // 
            // login_signupbtn
            // 
            login_signupbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_signupbtn.Location = new Point(29, 341);
            login_signupbtn.Name = "login_signupbtn";
            login_signupbtn.Size = new Size(186, 35);
            login_signupbtn.TabIndex = 1;
            login_signupbtn.Text = "SIGN UP";
            login_signupbtn.UseVisualStyleBackColor = true;
            login_signupbtn.Click += login_signupbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(48, 322);
            label6.Name = "label6";
            label6.Size = new Size(136, 16);
            label6.TabIndex = 0;
            label6.Text = "Register your Account ";
            label6.Click += label6_Click;
            // 
            // login_button
            // 
            login_button.BackColor = Color.FromArgb(33, 8, 97);
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            login_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_button.ForeColor = SystemColors.ButtonHighlight;
            login_button.Location = new Point(361, 312);
            login_button.Name = "login_button";
            login_button.Size = new Size(102, 32);
            login_button.TabIndex = 24;
            login_button.Text = "LOGIN";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click_1;
            // 
            // login_showpass
            // 
            login_showpass.AutoSize = true;
            login_showpass.Font = new Font("Tahoma", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showpass.Location = new Point(428, 248);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(90, 15);
            login_showpass.TabIndex = 23;
            login_showpass.Text = "Show password";
            login_showpass.UseVisualStyleBackColor = true;
            login_showpass.CheckedChanged += signup_showpass_CheckedChanged;
            // 
            // login_password
            // 
            login_password.Location = new Point(294, 219);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(224, 23);
            login_password.TabIndex = 22;
            login_password.TextChanged += login_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(294, 202);
            label4.Name = "label4";
            label4.Size = new Size(62, 14);
            label4.TabIndex = 21;
            label4.Text = "Password:";
            // 
            // login_username
            // 
            login_username.Location = new Point(294, 156);
            login_username.Name = "login_username";
            login_username.Size = new Size(224, 23);
            login_username.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(294, 139);
            label3.Name = "label3";
            label3.Size = new Size(65, 14);
            label3.TabIndex = 19;
            label3.Text = "Username:";
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(294, 77);
            label2.Name = "label2";
            label2.Size = new Size(141, 22);
            label2.TabIndex = 18;
            label2.Text = "Login Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(546, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 17;
            exit.Text = "X";
            exit.Click += exit_Click_1;
            // 
            // Form1
            // 
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 400);
            Controls.Add(login_button);
            Controls.Add(login_showpass);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void login_button_Click_1(object sender, EventArgs e)
        {
            if (login_username.Text == ""
                || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                  , "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM client WHERE @username = username AND @password = password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);


                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("login Successfully!",
                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Mainform mForm = new Mainform();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username/password, please try again!",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label7;
        private Button login_signupbtn;
        private Label label6;
        private Button login_button;
        private CheckBox login_showpass;
        private TextBox login_password;
        private Label label4;
        private TextBox login_username;
        private Label label3;
        private Label label2;
        private Label exit;

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void login_signupbtn_Click(object sender, EventArgs e)
        {
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Hide();
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {



        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

