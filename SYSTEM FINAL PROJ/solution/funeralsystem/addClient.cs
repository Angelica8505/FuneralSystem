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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace funeralsystem
{
    public partial class addClient : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\cynth\Desktop\client.mdf;Integrated Security = True; Connect Timeout = 30");

        public addClient()
        {
            InitializeComponent();
            //TO DISPLAY THE DATA FROM DATABASE TO DATA GRID
            displayClientData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayClientData();
        }

        public void displayClientData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM  add_client", "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\cynth\\Desktop\\client.mdf;Integrated Security = True; Connect Timeout = 30");
            DataSet ds = new DataSet();
            da.Fill(ds, "add_client");
            dataGridView1.DataSource = ds.Tables["add_client"].DefaultView;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (addclient_id.Text == ""
                   || addclient_fullname.Text == ""
                   || addclient_gender.Text == ""
                   || addclient_phonenumber.Text == ""
                   || addclien_item.Text == ""
                   || Addclient_servicetype.Text == ""
                   || addclient_picture.Image == null)
            {
                MessageBox.Show("Please all the blank", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Delete?" +
                    "Client ID" + addclient_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        

                        string updateData = "DELETE FROM add_client WHERE  client_id = @clientid";


                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@clientID", addclient_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Deleted Successfully!", "Information Message",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayClientData();

                            ClearFields();
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

        private void addclient_add_Click(object sender, EventArgs e)
        {
            if (addclient_id.Text == ""
                || addclient_fullname.Text == ""
                || addclient_gender.Text == ""
                || addclient_phonenumber.Text == ""
                || addclien_item.Text == ""
                || Addclient_servicetype.Text == ""
                || addclient_picture.Image == null)
            {
                MessageBox.Show("Please all the blank", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkClientID = "SELECT COUNT(*) FROM add_client WHERE client_id = @ClientID";

                        using (SqlCommand CheckClient = new SqlCommand(checkClientID, connect))
                        {
                            CheckClient.Parameters.AddWithValue("@clientID", addclient_id.Text.Trim());
                            int count = (int)CheckClient.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addclient_id.Text.Trim() + "is already taken",
                             "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO add_client" +
                                    "( client_id, full_name, gender, phone_number, item," +
                                    " image, payment, insert_date,service_type)" +
                                    "VALUES(@clientID,@fullname,@gender, @phonenumber, @item, @image,@payment,@insertdate, @servicetype)";



                                string path = Path.Combine(@"C:\Users\cynth\Desktop\solution\funeralsystem\directory\"
                               + addclient_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addclient_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@clientID", addclient_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullname", addclient_fullname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addclient_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phoneNumber", addclient_phonenumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@item", addclien_item.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@payment", 0);
                                    cmd.Parameters.AddWithValue("@insertdate", today);
                                    cmd.Parameters.AddWithValue("@servicetype", Addclient_servicetype.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayClientData();


                                    MessageBox.Show("Added Successfully!", "Information Message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    ClearFields();
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                       "error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();

                    }
                }

            }

        }

        private void addclient_phonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void addclient_import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addclient_picture.ImageLocation = imagePath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex
                      , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)



        {
            if (e.RowIndex != -1)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addclient_id.Text = row.Cells[1].Value.ToString();
                addclient_fullname.Text = row.Cells[2].Value.ToString();
                addclient_gender.Text = row.Cells[3].Value.ToString();
                addclient_phonenumber.Text = row.Cells[4].Value.ToString();
                addclien_item.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    addclient_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addclient_picture.Image = null;
                }
                Addclient_servicetype.Text = row.Cells[5].Value.ToString();


            }
        }

        public void ClearFields()
        {
            addclient_id.Text = "";
            addclient_fullname.Text = "";
            addclient_gender.SelectedIndex = -1;
            addclient_phonenumber.Text = "";
            addclien_item.SelectedIndex = -1;
            Addclient_servicetype.SelectedIndex = -1;
            addclient_picture.Image = null;


        }
        private void addclient_update_Click(object sender, EventArgs e)
        {
            {
                if (addclient_id.Text == ""
                    || addclient_fullname.Text == ""
                    || addclient_gender.Text == ""
                    || addclient_phonenumber.Text == ""
                    || addclien_item.Text == ""
                    || Addclient_servicetype.Text == ""
                    || addclient_picture.Image == null)
                {
                    MessageBox.Show("Please all the blank", "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Udate?" +
                        "Client ID" + addclient_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE add_client SET full_name = @fullName, gender = @gender" +
                                ", Phone_number = @phonenumber, item = @item," +
                                " update_date = @updatedate, service_type = @servicetype " +
                                "WHERE client_id = @clientid";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@fullname", addclient_fullname.Text.Trim());
                                cmd.Parameters.AddWithValue("@gender", addclient_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@phoneNumber", addclient_phonenumber.Text.Trim());
                                cmd.Parameters.AddWithValue("@item", addclien_item.Text.Trim());
                                cmd.Parameters.AddWithValue("@updatedate", today);
                                cmd.Parameters.AddWithValue("@servicetype", Addclient_servicetype.Text.Trim());
                                cmd.Parameters.AddWithValue("@clientid", addclient_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayClientData();

                                MessageBox.Show("Update Successfully!", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ClearFields();
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
        }

        private void addclient_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Addclient_servicetype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

