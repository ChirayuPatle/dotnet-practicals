using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Make sure SQL Server is running and DB/table exist
        string connectionString = "Data Source=.;Initial Catalog=TestDB;Integrated Security=True;TrustServerCertificate=True";

        try
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Connected to database!\n");

                string query = "SELECT Id, Name, Age FROM Students";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(
                                $"{reader["Id"]} {reader["Name"]} {reader["Age"]}"
                            );
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine();
    }
}