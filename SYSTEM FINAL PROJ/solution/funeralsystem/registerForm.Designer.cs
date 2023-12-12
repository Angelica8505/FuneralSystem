namespace funeralsystem
{
    partial class registerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            signup_loginbtn = new Button();
            label6 = new Label();
            label5 = new Label();
            signup_button = new Button();
            signup_showpass = new CheckBox();
            signup_password = new TextBox();
            label4 = new Label();
            signup_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            panel1.Controls.Add(signup_loginbtn);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 400);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(72, 8, 138);
            pictureBox1.Image = Properties.Resources.kisspng_headstone_cemetery_funeral_home_death_funeral_5ac757ab403424_254163061523013547263_removebg_preview;
            pictureBox1.Location = new Point(68, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
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
            // signup_loginbtn
            // 
            signup_loginbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_loginbtn.Location = new Point(29, 341);
            signup_loginbtn.Name = "signup_loginbtn";
            signup_loginbtn.Size = new Size(186, 35);
            signup_loginbtn.TabIndex = 1;
            signup_loginbtn.Text = "LOGIN HERE";
            signup_loginbtn.UseVisualStyleBackColor = true;
            signup_loginbtn.Click += signup_loginbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(48, 322);
            label6.Name = "label6";
            label6.Size = new Size(153, 16);
            label6.TabIndex = 0;
            label6.Text = "Already have an account?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 370);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 17;
            // 
            // signup_button
            // 
            signup_button.BackColor = Color.FromArgb(33, 8, 97);
            signup_button.FlatAppearance.BorderSize = 0;
            signup_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            signup_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            signup_button.FlatStyle = FlatStyle.Flat;
            signup_button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_button.ForeColor = SystemColors.ButtonHighlight;
            signup_button.Location = new Point(370, 297);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(102, 32);
            signup_button.TabIndex = 16;
            signup_button.Text = "SIGN UP";
            signup_button.UseVisualStyleBackColor = false;
            signup_button.Click += signup_button_Click;
            // 
            // signup_showpass
            // 
            signup_showpass.AutoSize = true;
            signup_showpass.Font = new Font("Tahoma", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_showpass.Location = new Point(437, 249);
            signup_showpass.Name = "signup_showpass";
            signup_showpass.Size = new Size(90, 15);
            signup_showpass.TabIndex = 15;
            signup_showpass.Text = "Show password";
            signup_showpass.UseVisualStyleBackColor = true;
            signup_showpass.CheckedChanged += login_showpass_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.Location = new Point(303, 220);
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(224, 23);
            signup_password.TabIndex = 14;
            signup_password.TextChanged += signup_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(306, 193);
            label4.Name = "label4";
            label4.Size = new Size(62, 14);
            label4.TabIndex = 13;
            label4.Text = "Password:";
            // 
            // signup_username
            // 
            signup_username.Location = new Point(303, 150);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(224, 23);
            signup_username.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 130);
            label3.Name = "label3";
            label3.Size = new Size(65, 14);
            label3.TabIndex = 11;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(303, 74);
            label2.Name = "label2";
            label2.Size = new Size(169, 22);
            label2.TabIndex = 10;
            label2.Text = "Register Account";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 18);
            label1.TabIndex = 9;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 400);
            Controls.Add(label5);
            Controls.Add(signup_button);
            Controls.Add(signup_showpass);
            Controls.Add(signup_password);
            Controls.Add(label4);
            Controls.Add(signup_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registerForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Button signup_loginbtn;
        private Label label6;
        private Label label5;
        private Button signup_button;
        private CheckBox signup_showpass;
        private TextBox signup_password;
        private Label label4;
        private TextBox signup_username;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}