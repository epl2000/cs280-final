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
    internal class Quotation
    {
        public static void SetQuotationListBox(ListBox lb)
        {
            //List<Employee> employeeList = new List<Employee>();
            string selectcommand = "select concat (ctm_name,trade_no) as ctm_name ,trade_no,trade_date from quot order by trade_date desc";
            //string selectcommand = "select concat (ctm_name,trade_no) as ctm_name ,trade_no,trade_date from quot where ctm_name like '%下期%' order by trade_date desc";
            lb.DataSource = DataAccess.RetrieveDataTable(selectcommand);

            lb.DisplayMember = "ctm_name";
            lb.ValueMember = "trade_no";
            Renderer.RenderUI(lb);
        }
    }
}