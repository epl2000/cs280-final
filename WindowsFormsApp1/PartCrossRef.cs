using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;
using System.Data;

namespace WindowsFormsApp1
{
    internal class PartCrossRef
    {
        public static void SavePartCrossRef(DataGridView dg)
        {
            //select 1 from table where key = value;
            //INSERT INTO Store_Information(Store_Name, Sales, Txn_Date)VALUES('Los Angeles', 900, 'Jan-10-1999');
            string connectionString = ConfigurationManager.ConnectionStrings["ERPConnectionString"].ConnectionString;
            string commandText = "UPDATE partPrideCtmCrossRef SET [ctm_key] = @ctm_key WHERE [part_no] = @part_no and [ctm_no]=@ctm_no";
            string commandText2 = "INSERT into partPrideCtmCrossRef([part_no],[ctm_no],[ctm_key])VALUES(@part_no,@ctm_no,@ctm_key)";
            string commandText3 = "SELECT distinct 1 from partPrideCtmCrossRef where [part_no] =@part_no and [ctm_no] =@ctm_no";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command1 = new SqlCommand(commandText, connection);
                command1.Parameters.AddWithValue("@part_no", "");
                command1.Parameters.AddWithValue("@ctm_no", "");
                command1.Parameters.AddWithValue("@ctm_key", "");
                SqlCommand command2 = new SqlCommand(commandText2, connection);
                command2.Parameters.AddWithValue("@part_no", "");
                command2.Parameters.AddWithValue("@ctm_no", "");
                command2.Parameters.AddWithValue("@ctm_key", "");
                SqlCommand command3 = new SqlCommand(commandText3, connection);
                command3.Parameters.AddWithValue("@part_no", "");
                command3.Parameters.AddWithValue("@ctm_no", "");

                foreach (DataGridViewRow row in dg.Rows)
                {
                    try
                    {
                        if (row.Cells["trade_no"].Value != null)
                        {
                            command3.Parameters["@part_no"].Value = row.Cells["part_no"].Value.ToString();
                            command3.Parameters["@ctm_no"].Value = row.Cells["ctm_no"].Value.ToString();
                            connection.Open();
                            object rowsAffected = command3.ExecuteScalar();

                            if (rowsAffected != null)
                            {
                                command1.Parameters["@part_no"].Value = row.Cells["part_no"].Value.ToString();
                                command1.Parameters["@ctm_no"].Value = row.Cells["ctm_no"].Value.ToString();
                                command1.Parameters["@ctm_key"].Value = row.Cells["ctm_key"].Value.ToString().Trim();
                                command1.ExecuteNonQuery();
                            }
                            else
                            {
                                command2.Parameters["@part_no"].Value = row.Cells["part_no"].Value.ToString().Trim();
                                command2.Parameters["@ctm_no"].Value = row.Cells["ctm_no"].Value.ToString().Trim();
                                command2.Parameters["@ctm_key"].Value = row.Cells["ctm_key"].Value.ToString().Trim();
                                command2.ExecuteNonQuery();
                            }

                            //MessageBox.Show(row.Cells[1].Value.ToString() + row.Cells[2].Value.ToString() + row.Cells[7].Value.ToString());

                            //MessageBox.Show(connection.State.ToString());
                            //rowsAffected = command.ExecuteNonQuery();
                            //MessageBox.Show("RowsAffected: " + rowsAffected);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    connection.Close();
                }
            }
            MessageBox.Show("完成");
        }

        public static void SetPartCrossRefGridView(DataGridView dg, DataGridViewComboBoxColumn dgcbc, string tradeno)
        {
            //List<Employee> employeeList = new List<Employee>();
            DataTable dt = new DataTable();

            string selectcommand = @"declare @ctm_no nvarchar(50)
                                    set @ctm_no = (select ctm_no from quot where trade_no ='" + tradeno + @"')
                                    select q.trade_no,q.ctm_no,q.ctm_name,q1.part_no,concat(q1.part_no,q1.part_name) AS part_name,CONVERT(VARCHAR(45),'沒有索引沒有索引沒有索引沒有索引') as ctm_key into #tempCR
                                    from quot1 q1
                                    inner join quot q on q.trade_no = q1.trade_no
                                    where q.trade_no='" + tradeno + @"'
                                    update #tempCR
                                    set ctm_key =pc.ctm_key
                                    FROM #tempCR AS tq1
                                    INNER JOIN partPrideCtmCrossRef AS pc ON tq1.part_no = pc.part_no
                                    where pc.ctm_no =@ctm_no
                                    select * from #tempCR order by part_no
                                    drop table #tempCR";

            dt = DataAccess.RetrieveDataTable(selectcommand);
            dg.DataSource = dt;
            //MessageBox.Show("hehe");

            foreach (DataGridViewRow row in dg.Rows)
            {
                try
                {
                    DataGridViewComboBoxCell dc = new DataGridViewComboBoxCell();
                    dc = (DataGridViewComboBoxCell)row.Cells[0];

                    //MessageBox.Show("hehe" + row.Cells["part_no"].Value.ToString());

                    dc.Value = row.Cells["part_no"].Value.ToString();
                }
                catch
                {
                }
            }
            dg.Columns["part_name"].Visible = false;
            dg.Columns[0].DisplayIndex = 5;
            Renderer.RenderUI(dg);
        }
    }
}