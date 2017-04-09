using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    internal class ItemPacker
    {
        public static void SetItemPackerDataGridView(DataGridView dg, string supplierNo)
        {
            //List<Employee> employeeList = new List<Employee>();

            string selectcommand = "select part_no,part_name ,sales_no from part where ctm_no ='" + supplierNo + "'";
            dg.DataSource = DataAccess.RetrieveDataTable(selectcommand);
            Renderer.RenderUI(dg);
        }

        public static void SetItemPackerLabelDataGridView(DataGridView dg, string supplierNo, string packerNo, DateTime orderDate)
        {
            //List<Employee> employeeList = new List<Employee>();

            string selectcommand = @"select o.require_date As 銷貨日,o.sales_no AS 業務,c.ctm_short As 客戶,p.part_name AS 品項,o1.qty_case AS 數量,o1.unit AS 單位,p.ctm_NO AS 共應商
                                            from[order] AS o
                                            INNER JOIN CTM AS c ON c.ctm_no = o.ctm_no
                                            INNER JOIN ORDER1 AS o1 ON o1.trade_no = o.trade_no
                                            INNER JOIN PART AS p ON p.part_no = o1.part_no1
                                            where trade_date = '" + orderDate + @"'
                                            and require_date > '" + orderDate + @"'
                                            and p.ctm_no = '" + supplierNo + @"'
                                            order by o1.part_name,o1.unit,o1.qty_case";
            dg.DataSource = DataAccess.RetrieveDataTable(selectcommand);
            Renderer.RenderUI(dg);
        }

        public static void SaveItemPacker(DataGridView dg)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ERPConnectionString"].ConnectionString;
            string commandText = "UPDATE part SET [sales_no] = @sales_no WHERE [part_no] = @part_no";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                //command.CommandType = System.Data.CommandType.Text;
                int count = 0;
                command.Parameters.AddWithValue("@sales_no", "");
                command.Parameters.AddWithValue("@part_no", "");
                foreach (DataGridViewRow row in dg.Rows)
                {
                    try
                    {
                        if (row.Cells[0].Value != null)
                        {
                            //MessageBox.Show(row.Cells[1].Value.ToString() + row.Cells[2].Value.ToString() + row.Cells[7].Value.ToString());
                            command.Parameters["@part_no"].Value = row.Cells["part_no"].Value.ToString();
                            command.Parameters["@sales_no"].Value = row.Cells["sales_no"].Value.ToString();
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