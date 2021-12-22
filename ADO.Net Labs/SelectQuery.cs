using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ADO.Net_Labs
{
    class SelectQuery
    {
        public static void Do()
        {
            // Step 1: Establish connection with database
            string connString = "Server=.; Database=EmployeeDB; Integrated Security=true";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            // Step 2: Prepare query
            string insertQuery = "select * from Employee where ID=1004";
            SqlCommand command = new SqlCommand(insertQuery, con);

            // Step 3: Execute Query
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("ID " + reader[0].ToString() + "Name: " + reader[1].ToString() + ", Dept : " + reader[2].ToString());
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Step 4: Close connection
                con.Close();
            }
        }
    }
}
