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

    public partial class dashboardclient : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\cynth\Desktop\client.mdf;Integrated Security = True; Connect Timeout = 30");
        public dashboardclient()
        {
            InitializeComponent();

            displayTC();
            displayAC();
            displayIC();

        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;

                displayTC();
                displayAC();
                displayIC();
            }
        }
        public void displayTC()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM add_client WHERE delete_date IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_TC.Text = count.ToString();
                        }
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
        }
        public void displayAC()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM add_client WHERE item = @item";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@item", "TotalItem");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {

                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AC.Text = count.ToString();
                        }
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
        }
        public void displayIC()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM add_client WHERE item = @item";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@item", "totalPay");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {

                            int count = Convert.ToInt32(reader[0]);
                            dashboard_IC.Text = count.ToString();
                        }
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
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_TC_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_AC_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_IC_Click(object sender, EventArgs e)
        {

        }
    }
}
