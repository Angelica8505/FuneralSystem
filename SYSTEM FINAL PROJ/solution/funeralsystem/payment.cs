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
using System.Data.Sql;
using System.Data.SqlClient;

namespace funeralsystem
{
    public partial class payment : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\cynth\Desktop\client.mdf;Integrated Security = True; Connect Timeout = 30");
        public payment()
        {
            InitializeComponent();
            DisplayClient();
            disableFields();
        }



        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayClient();
            disableFields();
        }

            public void disableFields()
        {
            payment_clientid.Enabled = false;
            payment_fullname.Enabled = false;
            payment_item.Enabled = false;


        }
        public void DisplayClient()
        {
            paymentData cd = new paymentData();
            List<paymentData> listData = cd.PaymentClientListData();

            dataGridView1.DataSource = listData;
        }

        private void payment_updatebtn_Click(object sender, EventArgs e)
        {
            if (payment_clientid.Text == ""
                || payment_fullname.Text == ""
                || payment_item.Text == ""
                || payment_totalpayment.Text == "")
            {
                MessageBox.Show("Please fill all blanks!", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Update?" +
                       "Client ID" + payment_clientid.Text.Trim() + "?", "Confirmation Message",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE add_client SET payment = @payment, " +
                            "update_date = @updatedate WHERE client_id = @clientID";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@payment", payment_totalpayment.Text.Trim());
                            cmd.Parameters.AddWithValue("@updatedate", today);
                            cmd.Parameters.AddWithValue("@clientID", payment_clientid.Text.Trim());


                            cmd.ExecuteNonQuery();
                            DisplayClient();




                            MessageBox.Show("Update Successfully!", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();



                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error" + ex
                     , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cacelled."
                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clearFields()
        {
            payment_clientid.Text = "";
            payment_fullname.Text = "";
            payment_item.Text = "";
            payment_item.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            payment_clientid.Text = row.Cells[0].Value.ToString();
            payment_fullname.Text = row.Cells[2].Value.ToString();
            payment_item.Text = row.Cells[4].Value.ToString();
            payment_totalpayment.Text = row.Cells[5].Value.ToString();
        }

        private void payment_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
