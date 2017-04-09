using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class CustomComboBox
    {
        public static void SetPartComboBox(ComboBox cb)
        {
            //List<Employee> employeeList = new List<Employee>();

            string selectcommand = "select part_no, CONCAT(part_no,part_name) AS part_name from part order by part_no";
            cb.DataSource = DataAccess.RetrieveDataTable(selectcommand);
            cb.DisplayMember = "part_name";
            cb.ValueMember = "part_no";
        }

        public static void SetDataGridComboBox(DataGridViewComboBoxColumn dgcbc)
        {
            //List<Employee> employeeList = new List<Employee>();

            string selectcommand = "select part_no, CONCAT(part_no,part_name) AS part_name from part order by part_no";
            dgcbc.DataSource = DataAccess.RetrieveDataTable(selectcommand);
            dgcbc.DisplayMember = "part_name";
            dgcbc.ValueMember = "part_no";
        }

        public static void SetEmployeeGridComboBox(DataGridViewComboBoxColumn dgcbc)
        {
            //List<Employee> employeeList = new List<Employee>();
            //string selectcommand = "select empl_no, empl_name from Employee";
            string selectcommand = "select empl_no, empl_name,department_no from Employee where department_no in ('21','51') order by department_no";
            dgcbc.DataSource = DataAccess.RetrieveDataTable(selectcommand);
            dgcbc.DisplayMember = "empl_name";
            dgcbc.ValueMember = "empl_no";
        }
    }
}