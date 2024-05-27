using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkSystem
{

    internal class UserData
    {

      
    }

    class UserDetails
    {
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KARLOWEN\source\repos\ParkingSystem4\ParkSystem\ParkSystem\DB\Database1.mdf;Integrated Security=True";

        public string name;
        public int id;

        private static UserDetails instance;
        public static UserDetails Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDetails();
                return instance;
            }
            set
            {
                instance = value;
            }
        }


        public void setId(int Id)
        {
            id = Id;
        }

        public string[] GetAdminById(int id)
        {
            string[] adminData = new string[3]; // Assuming you want to store only username, password, and date_created

            string query = "SELECT id, username, password, date_created FROM admin WHERE id = @Id";

            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter for the ID
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Read data from the reader
                            int fetchedId = reader.GetInt32(0);
                            string username = reader.GetString(1);
                            string password = reader.GetString(2);
                            DateTime? dateCreated = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);

                            // Assign admin data to the array
                            adminData[0] = username;
                            adminData[1] = password;
                            adminData[2] = dateCreated?.ToString();
                        }
                    }
                }
            }

            // Return the admin data array
            return adminData;
        }





        public int getId()
        {
            return id;
        }

        public string getName() {
            string[] adminData = GetAdminById(id);

            return  adminData[0];
        }


    }
}
