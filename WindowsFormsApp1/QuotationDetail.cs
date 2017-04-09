using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class QuotationDetail
    {
        public static void SaveQuoteSheet(DataGridView dg)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ERPConnectionString"].ConnectionString;
            string commandText = "UPDATE Quot1 SET [price] = @price WHERE [trade_no] = @trade_no and [part_no] = @part_no";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                //command.CommandType = System.Data.CommandType.Text;
                int count = 0;
                command.Parameters.AddWithValue("@price", 0);
                command.Parameters.AddWithValue("@trade_no", "");
                command.Parameters.AddWithValue("@part_no", "");
                foreach (DataGridViewRow row in dg.Rows)
                {
                    try
                    {
                        if (row.Cells[0].Value != null)
                        {
                            //MessageBox.Show(row.Cells[1].Value.ToString() + row.Cells[2].Value.ToString() + row.Cells[7].Value.ToString());
                            command.Parameters["@trade_no"].Value = row.Cells["trade_no"].Value.ToString();
                            command.Parameters["@part_no"].Value = row.Cells["part_no"].Value.ToString();
                            command.Parameters["@price"].Value = int.Parse(row.Cells["下期報價"].Value.ToString());
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
                        //MessageBox.Show(e.Message);
                        //MessageBox.Show("The count is: " + count);
                    }
                }
            }
            MessageBox.Show("完成");
        }

        public static void SetOrderDetailGridView(DataGridView dg, string tradeno, string empl_no)
        {
            //List<Employee> employeeList = new List<Employee>();

            string selectcommand = @"
                declare @trade_date datetime
                declare @recordcnt int
                declare @recordmax int
                declare @ctm_no nvarchar(50)
                declare @cost money
                set @trade_date = GETDATE()
                set @ctm_no = (select ctm_no from quot where trade_no ='" + tradeno + @"')
                select Identity(int, 1,1) AS pk,q.ctm_no,q.ctm_name,q.trade_no,p.empl_no ,q1.part_no,q1.part_name,CONVERT(VARCHAR(45),'沒有索引沒有索引沒有索引沒有索引') as ctm_key,q1.price as '本期報價',q1.unit,0 as '成本', q1.price as '下期報價' into #tempQ
                from quot1 q1
                inner join quot q on q1.trade_no = q.trade_no
                inner join part p on p.part_no = q1.part_no
                where q.trade_no ='" + tradeno + @"'
                update tq1
                set ctm_key =pc.ctm_key
                FROM #tempQ AS tq1
                INNER JOIN partPrideCtmCrossRef AS pc ON tq1.part_no = pc.part_no
                where pc.ctm_no =@ctm_no
                set @recordcnt = 1
                set @recordmax = (select count(part_no) from #tempQ)+1
                WHILE @recordcnt<@recordmax
                BEGIN
                    set @cost = round((SELECT TOP(1) input1.price
                    FROM input
                    INNER JOIN input1 ON input.trade_no = input1.trade_no
                    where input1.part_no in (select part_no from #tempQ where pk =@recordcnt) and input.trade_Date > (@trade_Date-10)
                    ORDER BY trade_date desc, price DESC),0)
                    if (@cost is not null)
                    BEGIN
                        update #tempQ set 成本= @cost where pk =@recordcnt
                    END
                set @recordcnt = @recordcnt + 1
                END
                select * from #tempQ where empl_no in('" + empl_no + @"','') order  by part_no
                drop table #tempQ";

            dg.DataSource = DataAccess.RetrieveDataTable(selectcommand);
            dg.Columns["pk"].Visible = false;

            foreach (DataGridViewRow row in dg.Rows)
            {
                try
                {
                    DataGridViewComboBoxCell dc = new DataGridViewComboBoxCell();
                    dc = (DataGridViewComboBoxCell)row.Cells[0];

                    //MessageBox.Show("hehe" + row.Cells["part_no"].Value.ToString());

                    dc.Value = row.Cells["empl_no"].Value.ToString();
                }
                catch (Exception e)
                {
                    //MessageBox.Show(row.Cells["part_name"].Value.ToString() + "沒設採購報價人員");
                }
            }
            dg.Columns["empl_no"].Visible = false;
            dg.Columns[0].DisplayIndex = 5;
            Renderer.RenderUI(dg);
        }
    }
}