using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (SqlConnection conn = new SqlConnection(@"Data Source=MARC-PC\SQLEXPRESS;Initial Catalog=Poudlard;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"))
            //{
            
            //conn.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM Etudiant e WHERE e.classe = 'M1'", conn);
            //SqlDataReader result = command.ExecuteReader();

            //while (result.Read())
            //{
            //    Console.WriteLine(result[0] + " " + result[1] + " " + result[2] + " " + result[3] + " " + result[4]);
            //}

            //Console.ReadLine();

            //}

            SqlConnection conn = new SqlConnection(@"Data Source=MARC-PC\SQLEXPRESS;Initial Catalog=Poudlard;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            SqlCommand command = new SqlCommand();
            conn.Open();
           

            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                command.Transaction = transaction;

                command.CommandText = "Insert into Etudiant Values (124563, 'totototo', 'tititi', '25/10/1985', 'B2')";
                command.Connection = conn; 
                command.ExecuteNonQuery();

                command.CommandText = "Insert into Etudiant Values (256345, 'aaaaaa', 'bbbb', '25/10/1955', 'M2')";
                command.ExecuteNonQuery(); 

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
