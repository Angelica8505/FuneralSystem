using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace funeralsystem
{
    internal class paymentData
    {
        public string ClientID { get; set; }//0
        public string Contact {  get; set; }//1
        public string Gender { get; set; }//2
        public string Name { get; set; }//3
        public string Item { get; set; }//4
        public int Payment { get; set; }//5


      SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\cynth\Desktop\client.mdf;Integrated Security = True; Connect Timeout = 30");


        public List<paymentData> PaymentClientListData()
        {
            List<paymentData> listdata = new List<paymentData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM add_client WHERE delete_date is NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            paymentData sd = new paymentData();
                            sd.ClientID = reader["client_id"].ToString();
                            sd.Name = reader["Full_name"].ToString();
                            sd.Contact = reader["Phone_number"].ToString();
                            sd.Gender = reader["gender"].ToString();
                            sd.Item = reader["item"].ToString();
                            sd.Payment = (int)reader["payment"];


                            listdata.Add(sd);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error: " + ex);
                }
                finally
                {
                    connect.Close();
                }

            }
            return listdata;
        }
    }

}
