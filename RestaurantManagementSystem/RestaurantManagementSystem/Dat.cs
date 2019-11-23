using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RestaurantManagementSystem
{
    public class Dat
    {

        public string A;
        public DataTable insert(string a)
        {
            string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";


            // @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Papillon\Documents\ProgrammersStaff\MyProjects\csharpRepo\RestaurantManagementSystem\Restaurantdb.accdb";



            OleDbConnection con = new OleDbConnection(conn);

            con.Open();

            OleDbCommand cmd = new OleDbCommand();


            cmd.Connection = con;

            cmd.CommandText = a;




            // cmd.ExecuteNonQuery();

            OleDbDataReader sdr = cmd.ExecuteReader();


            DataTable datarecords = new DataTable();


            datarecords.Load(sdr);


            con.Close();

            return datarecords;
        }

    }
}
