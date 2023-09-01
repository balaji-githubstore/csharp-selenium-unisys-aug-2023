using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionProject
{
    class ProgramDB
    {
        //Connectionstring from app.config file.
        // public static String connectionString = ConfigurationManager.ConnectionStrings["connapp"].ConnectionString;
        public static String connectionString = "Data Source=balaji;Initial Catalog=test;User ID=sa;Password=123456;Integrated Security=True";
        static void Main(string[] args)
        {

            SqlConnection s = new SqlConnection(connectionString);
            SqlCommand c = new SqlCommand("SELECT * FROM [CUSTOMERS]", s);
            s.Open();
             SqlDataReader r= c.ExecuteReader();
            while(r.Read())
            {
                for(int i=0;i<r.FieldCount;i++)
                {
                    Console.WriteLine(r[i]);
                }
            }
            s.Close();

            
            ////Using connectionString from app.config
            ////Reading data from database table (Select query)
            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                connection1.Open();
                using (SqlCommand command1 = new SqlCommand("SELECT * FROM [CUSTOMERS]", connection1))
                {
                    using (SqlDataReader reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.WriteLine(reader.GetValue(i));
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }

            ////Select query using connection string directly stored in string.
            //string connectionString2 = "Data Source=balaji;Initial Catalog=test;User ID=sa;Password=123456;;Integrated Security=True";
            //using (SqlConnection connection2 = new SqlConnection(connectionString2))
            //{
            //    connection2.Open();
            //    using (SqlCommand command2 = new SqlCommand("SELECT * FROM [CUSTOMERS]", connection2))
            //    {
            //        using (SqlDataReader reader = command2.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                for (int i = 0; i < reader.FieldCount; i++)
            //                {
            //                    Console.WriteLine(reader.GetValue(i));
            //                }
            //                Console.WriteLine();
            //            }
            //        }
            //    }
            //}

            //// Code to read first row and first cell value only
            //SqlConnection connection3 = new SqlConnection(connectionString);
            //connection3.Open();
            //SqlCommand command3 = new SqlCommand("Select count(*) from customers", connection3);
            //String CellValue = command3.ExecuteScalar().ToString();
            //Console.WriteLine(CellValue);
            //connection3.Close();

            ////Code to pass delete query 
            //SqlConnection connection4 = new SqlConnection(connectionString);
            //connection4.Open();
            //SqlCommand command4 = new SqlCommand("delete from [CUSTOMERS] where id = 2", connection4);
            //int rowAffected = command4.ExecuteNonQuery();
            //Console.WriteLine(rowAffected);
            //connection4.Close();


            ////Code to pass update query
            //SqlConnection connection5 = new SqlConnection(connectionString);
            //connection5.Open();
            //SqlCommand command5 = new SqlCommand("delete from [CUSTOMERS] where id = 2", connection5);
            //int rowAffected1 = command4.ExecuteNonQuery();
            //Console.WriteLine(rowAffected1);
            //connection5.Close();


            //Read data using dataadapter - automatically opens and close the database connection
            SqlConnection connection6 = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [CUSTOMERS]", connection6);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                String cell = row["salary"].ToString();
                Console.WriteLine(cell);
            }
            connection6.Close();

        }
    }
}
