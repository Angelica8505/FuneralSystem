using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funeralsystem
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , " Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addClient1_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_button_Click(object sender, EventArgs e)
        {
            dashboardclient1.Visible = true;
            addClient1.Visible = false;
            payment1.Visible = false;


            dashboardclient dashForm = dashboardclient1 as dashboardclient;

            if(dashForm != null )
            {
                dashForm.RefreshData();
            }

        }

        private void client_infobtn_Click(object sender, EventArgs e)
        {
            dashboardclient1.Visible = false;
            addClient1.Visible = true;
            payment1.Visible = false;

            addClient addCliForm = addClient1 as addClient;
             if(addCliForm != null)
            {
                addCliForm.RefreshData();
            }

        }

        private void payment_button_Click(object sender, EventArgs e)
        {
            dashboardclient1.Visible = false;
            addClient1.Visible = false;
            payment1.Visible = true;

            payment paymentForm = payment1 as payment;
            if(paymentForm != null)
            {
                paymentForm.RefreshData();
            }
        }
    }
   
}


