using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable etudiant = new DataTable("Etudiant");
            etudiant.Columns.Add(new DataColumn("id"));
            etudiant.Columns.Add(new DataColumn("name"));
            etudiant.Rows.Add(148278, "Marc");
            etudiant.Rows.Add(154585, "Paul"); 

            DataTable prof = new DataTable("Prof");
            prof.Columns.Add(new DataColumn("id"));
            prof.Columns.Add(new DataColumn("Name"));
            prof.Rows.Add(12520, "toto");
            prof.Rows.Add(145632, "Jean"); 

            System.Data.DataSet set = new System.Data.DataSet();
            set.Tables.Add(etudiant);
            set.Tables.Add(prof); 

            Console.WriteLine(set.GetXml());

            Console.ReadLine();
        }
    }
}
