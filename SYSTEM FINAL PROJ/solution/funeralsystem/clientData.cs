using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace funeralsystem
{

    internal class clientData
    {
        public int id { get; set; }//0
        public string ClientID { get; set; }//1
        public string Name { get; set; }//2
        public string Gender { get; set; }//3
        public string contact { get; set; }//4
        public string Item { get; set; }//5
        public string Image { get; set; }//6
        public int Payment { get; set; }//7
        public string servicetype { get; set; }//8


        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\cynth\Desktop\client.mdf;Integrated Security = True; Connect Timeout = 30");

        public List<clientData> ClientListData()
        {
            List<clientData> listdata = new List<clientData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect. Open();

                    string selectData = "SELECT * FROM add_client WHERE delete_date is NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            clientData cd = new clientData();
                            cd.id = (int)reader["id"];
                            cd.Name = reader["Full_name"].ToString();
                            cd.Gender = reader["gender"].ToString();
                            cd.contact = reader["contact_number"].ToString();
                            cd.ClientID = reader["client_id"].ToString();
                            cd.Item = reader["item"].ToString();
                            cd.Image = reader["image"].ToString();
                            cd.Payment = (int)reader["payment"];
                            cd.servicetype = reader["Service_type"].ToString();


                            listdata.Add(cd);

                        }
                    }
                }catch(Exception ex)
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
