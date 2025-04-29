// See https://aka.ms/new-console-template for more information
using System.Data;
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");
Console.ReadKey();
Console.WriteLine("Zack");

string connectionString = "Data Source=.;Initial Catalog=mydb;User ID=sa;Password=sasa@123;";
Console.WriteLine("ConnectionString : " + connectionString);
SqlConnection connection = new SqlConnection();
Console.WriteLine("Connection opening...");
connection.Open();
Console.WriteLine("Connection opened...");

string query = @"SELECT [BlogId]
      ,[BlogTitle]
      ,[BlogAuthor]
      ,[BlogContent]
      ,[DeleteFlag]
  FROM [dbo].[Tbl_Blog]";
SqlCommand cmd = new SqlCommand(query);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);
SqlDataReader reader = cmd.ExecuteReader();
while(reader.Read())
{
    Console.WriteLine(reader["BlogId"]);
    Console.WriteLine(reader["BlogTitle"]);
    Console.WriteLine(reader["BlogAuthor"]);
    Console.WriteLine(reader["BlogContent"]);
}

Console.WriteLine("Connection closing...");
connection.Close();
Console.WriteLine("Connection closed...");

//Data Set 

//foreach (DataRow dr in dt.Rows)
//{

//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);

//}
