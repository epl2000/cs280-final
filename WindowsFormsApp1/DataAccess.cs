using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DataAccess
    {
        public static DataTable RetrieveDataTable(string selectcommand)
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["ERPConnectionString"].ConnectionString;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(selectcommand, connection);
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("youfuckhead" + e.ToString());
                return null;
            }
        }
    }
}