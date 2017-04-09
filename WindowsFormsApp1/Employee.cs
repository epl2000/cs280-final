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
    public class Employee
    {
        private string name;
        private string employeenumber;

        public string Name { get => name; set => name = value; }
        public string EmployeeNumber { get => employeenumber; set => employeenumber = value; }

        public static void SetEmployeeComboBox(ListControl cb)
        {
            //List<Employee> employeeList = new List<Employee>();
            // MessageBox.Show(cb.Name);
            string selectcommand = "";
            if (cb.Name.ToString() == "employeeListBox")
            {
                selectcommand = "select empl_no, empl_name from Employee where department_no not in ('21','51','61') order by department_no";
            }
            else
            {
                selectcommand = "select empl_no, empl_name from Employee where department_no in ('21','51') order by department_no";
            }

            cb.DataSource = DataAccess.RetrieveDataTable(selectcommand);
            cb.DisplayMember = "empl_name";
            cb.ValueMember = "empl_no";
            cb.SelectedIndex = 0;
        }

        public static void UpdateEmployeeItem(DataGridView dg)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ERPConnectionString"].ConnectionString;
            string commandText = "UPDATE part SET [empl_no] = @empl_no WHERE [part_no] = @part_no";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                //command.CommandType = System.Data.CommandType.Text;
                int count = 0;
                command.Parameters.AddWithValue("@empl_no", "");
                command.Parameters.AddWithValue("@part_no", "");
                foreach (DataGridViewRow row in dg.Rows)
                {
                    try
                    {
                        if (row.Cells[0].Value != null)
                        {
                            //MessageBox.Show(row.Cells[1].Value.ToString() + row.Cells[2].Value.ToString() + row.Cells[7].Value.ToString());
                            command.Parameters["@part_no"].Value = row.Cells["part_no"].Value.ToString();
                            command.Parameters["@empl_no"].Value = row.Cells["employeeCbColumn"].Value.ToString();
                            connection.Open();
                            //MessageBox.Show(connection.State.ToString());
                            int rowsAffected = command.ExecuteNonQuery();
                            //MessageBox.Show("RowsAffected: " + rowsAffected);
                            connection.Close();
                            //MessageBox.Show(connection.State.ToString());
                            //MessageBox.Show("The count is: " + count);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        MessageBox.Show("The count is: " + count);
                    }
                }
            }
            MessageBox.Show("完成");
        }
    }
}