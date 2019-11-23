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


namespace WindowsFormsApplication1
{
   public class DATA

    {
        public string A;
        public DataTable insert(string a)
        {
            string conn = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Emma\Desktop\Projects\Sales and inventory c#\WindowsFormsApplication1\WindowsFormsApplication1\signup.accdb";
            
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
