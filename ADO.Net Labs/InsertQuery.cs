using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ADO.Net_Labs
{
    class InsertQuery
    {
        public static void Do()
        {
            // Step 1: Establish connection with database
            string connString = "Server=.; Database=EmployeeDB; Integrated Security=true";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            // Step 2: Prepare query
            string insertQuery = "insert into Employee(Name, Dept) values('Employee1', 'Finance')";
            SqlCommand command = new SqlCommand(insertQuery, con);

            // Step 3: Execute Query
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Step 4: Close connection
                con.Close();
            }
        }
    }
}
