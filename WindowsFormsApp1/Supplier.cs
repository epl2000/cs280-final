using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class Supplier
    {
        public static void SetSupplierListBox(ListBox lb)
        {
            //List<Employee> employeeList = new List<Employee>();

            string selectcommand = "select * from sup where ctm_no in (select ctm_no from part where part_no <'95%')";
            lb.DataSource = DataAccess.RetrieveDataTable(selectcommand);

            lb.DisplayMember = "ctm_name";
            lb.ValueMember = "ctm_no";
            Renderer.RenderUI(lb);
        }
    }
}