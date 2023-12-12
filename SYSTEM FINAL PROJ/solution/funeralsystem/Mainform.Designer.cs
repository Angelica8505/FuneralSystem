namespace funeralsystem
{
    partial class Mainform
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            logout_button = new Button();
            payment_button = new Button();
            client_infobtn = new Button();
            Dashboard_button = new Button();
            Greet_user = new Label();
            panel3 = new Panel();
            dashboardclient1 = new dashboardclient();
            addClient1 = new addClient();
            payment1 = new payment();
            notifyIcon1 = new NotifyIcon(components);
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 8, 97);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 65);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(210, 17);
            label2.TabIndex = 2;
            label2.Text = "Funeral Management Sytem";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(1073, 9);
            label1.Name = "label1";
            label1.Size = new Size(15, 16);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 8, 101);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(logout_button);
            panel2.Controls.Add(payment_button);
            panel2.Controls.Add(client_infobtn);
            panel2.Controls.Add(Dashboard_button);
            panel2.Controls.Add(Greet_user);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 535);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // logout_button
            // 
            logout_button.BackColor = Color.FromArgb(33, 8, 97);
            logout_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            logout_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_button.ForeColor = SystemColors.ButtonHighlight;
            logout_button.Location = new Point(24, 487);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(171, 36);
            logout_button.TabIndex = 5;
            logout_button.Text = "SIGNOUT";
            logout_button.UseVisualStyleBackColor = false;
            logout_button.Click += button4_Click;
            // 
            // payment_button
            // 
            payment_button.BackColor = Color.FromArgb(33, 8, 97);
            payment_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            payment_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            payment_button.FlatStyle = FlatStyle.Flat;
            payment_button.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment_button.Location = new Point(39, 338);
            payment_button.Name = "payment_button";
            payment_button.Size = new Size(156, 50);
            payment_button.TabIndex = 4;
            payment_button.Text = "PAYMENT";
            payment_button.UseVisualStyleBackColor = false;
            payment_button.Click += payment_button_Click;
            // 
            // client_infobtn
            // 
            client_infobtn.BackColor = Color.FromArgb(33, 8, 97);
            client_infobtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            client_infobtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            client_infobtn.FlatStyle = FlatStyle.Flat;
            client_infobtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            client_infobtn.Location = new Point(39, 260);
            client_infobtn.Name = "client_infobtn";
            client_infobtn.Size = new Size(156, 55);
            client_infobtn.TabIndex = 3;
            client_infobtn.Text = "CLIENT INFORMATION";
            client_infobtn.UseVisualStyleBackColor = false;
            client_infobtn.Click += client_infobtn_Click;
            // 
            // Dashboard_button
            // 
            Dashboard_button.BackColor = Color.FromArgb(33, 8, 97);
            Dashboard_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            Dashboard_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            Dashboard_button.FlatStyle = FlatStyle.Flat;
            Dashboard_button.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboard_button.Location = new Point(39, 187);
            Dashboard_button.Name = "Dashboard_button";
            Dashboard_button.Size = new Size(156, 48);
            Dashboard_button.TabIndex = 2;
            Dashboard_button.Text = "DASHBOARD";
            Dashboard_button.UseVisualStyleBackColor = false;
            Dashboard_button.Click += Dashboard_button_Click;
            // 
            // Greet_user
            // 
            Greet_user.AutoSize = true;
            Greet_user.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Greet_user.ForeColor = SystemColors.ButtonFace;
            Greet_user.Location = new Point(59, 133);
            Greet_user.Name = "Greet_user";
            Greet_user.Size = new Size(109, 15);
            Greet_user.TabIndex = 1;
            Greet_user.Text = "Welcome, User!";
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboardclient1);
            panel3.Controls.Add(addClient1);
            panel3.Controls.Add(payment1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(222, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(878, 535);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // dashboardclient1
            // 
            dashboardclient1.BorderStyle = BorderStyle.FixedSingle;
            dashboardclient1.Location = new Point(0, 0);
            dashboardclient1.Name = "dashboardclient1";
            dashboardclient1.Size = new Size(878, 535);
            dashboardclient1.TabIndex = 5;
            // 
            // addClient1
            // 
            addClient1.BorderStyle = BorderStyle.FixedSingle;
            addClient1.Location = new Point(0, 0);
            addClient1.Name = "addClient1";
            addClient1.Size = new Size(878, 565);
            addClient1.TabIndex = 4;
            // 
            // payment1
            // 
            payment1.BorderStyle = BorderStyle.FixedSingle;
            payment1.Location = new Point(0, 0);
            payment1.Name = "payment1";
            payment1.Size = new Size(878, 532);
            payment1.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(33, 8, 101);
            pictureBox1.Image = Properties.Resources.kisspng_headstone_cemetery_funeral_home_death_funeral_5ac757ab403424_254163061523013547263_removebg_preview;
            pictureBox1.Location = new Point(50, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mainform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label Greet_user;
        private Button Dashboard_button;
        private Button payment_button;
        private Button client_infobtn;
        private Button logout_button;
        private Panel panel3;
        private payment payment1;
        private NotifyIcon notifyIcon1;
        private addClient addClient1;
        private dashboardclient dashboardclient1;
        private PictureBox pictureBox1;
    }
}