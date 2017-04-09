using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ExcelSheetCore
    {
        public Excel.Application XLApp { get; set; }
        public Excel.Workbook XLWorkBook { get; set; }
        public Excel.Sheets XLSheets { get; set; }

        public ExcelSheetCore()
        {
            XLApp = new Excel.Application();
        }

        public void SetWorkBook(string fileExcel)
        {
            XLWorkBook = XLApp.Workbooks.Open(fileExcel);
            XLSheets = XLWorkBook.Worksheets;
            foreach (Excel.Worksheet workSheet in XLWorkBook.Worksheets)
            {
                try
                {
                    //Excel.Range currentSheetRange = workSheet.UsedRange;
                    //Excel.Range currentFind = null;
                    //Excel.Range firstFind = null;
                    //int currentSheetRowCount = currentSheetRange.Rows.Count;
                    //currentFind = currentSheetRange.Find("去頭白蘿蔔");

                    //MessageBox.Show("the row pos is " + currentFind.Row.ToString() + " the column pos is " + currentFind.Column.ToString());
                }
                catch
                {
                    continue;
                }
            }

            //MessageBox.Show(xlWorkBook.Sheets);
            XLApp.Visible = true;
        }

        public void DatagridPriceUpdate(int offset, DataGridView dg)
        {
            string ctmKey = "";

            foreach (DataGridViewRow row in dg.Rows)
            {
                try
                {
                    if (row.Cells[0].Value != null)
                    {
                        //MessageBox.Show(row.Cells["part_name"].Value.ToString() + " " + row.Cells["ctm_key"].Value.ToString() + " " + row.Cells["nextq"].Value.ToString());
                        ctmKey = row.Cells["ctm_key"].Value.ToString().Trim();

                        foreach (Excel.Worksheet workSheet in XLWorkBook.Worksheets)
                        {
                            try
                            {
                                Excel.Range currentSheetRange = workSheet.UsedRange;
                                Excel.Range currentFind = null;
                                //Excel.Range firstFind = null;
                                int currentSheetRowCount = currentSheetRange.Rows.Count;
                                //MessageBox.Show("ctm_key" + ctmKey);
                                currentFind = currentSheetRange.Find(ctmKey);
                                if (currentFind != null)
                                {
                                    //MessageBox.Show("找到" + ctmKey + int.Parse(workSheet.Cells[currentFind.Row, currentFind.Column + offset]));
                                    row.Cells["下期報價"].Value = float.Parse(workSheet.Cells[currentFind.Row, currentFind.Column + offset].Value.ToString());
                                    //MessageBox.Show("EXCEL" + workSheet.Cells[currentFind.Row, currentFind.Column + offset].Value.ToString());
                                    //MessageBox.Show(ctmKey + " the row pos is " + currentFind.Row.ToString() + " the column pos is " + currentFind.Column.ToString());
                                }
                            }
                            catch
                            {
                                continue;
                            }
                        }
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
            }
            MessageBox.Show("完成");
        }

        public void PriceUpDate(int offset, DataGridView dg)
        {
            string ctmKey = "";
            float quotePrice = 0;
            foreach (DataGridViewRow row in dg.Rows)
            {
                try
                {
                    if (row.Cells[0].Value != null)
                    {
                        //MessageBox.Show(row.Cells["part_name"].Value.ToString() + " " + row.Cells["ctm_key"].Value.ToString() + " " + row.Cells["nextq"].Value.ToString());
                        ctmKey = row.Cells["ctm_key"].Value.ToString().Trim();
                        quotePrice = float.Parse(row.Cells["下期報價"].Value.ToString());
                        foreach (Excel.Worksheet workSheet in XLWorkBook.Worksheets)
                        {
                            try
                            {
                                Excel.Range currentSheetRange = workSheet.UsedRange;
                                Excel.Range currentFind = null;
                                //Excel.Range firstFind = null;
                                int currentSheetRowCount = currentSheetRange.Rows.Count;
                                //MessageBox.Show("ctm_key" + ctmKey);
                                currentFind = currentSheetRange.Find(ctmKey);
                                if (currentFind != null)
                                {
                                    workSheet.Cells[currentFind.Row, currentFind.Column + offset] = quotePrice;
                                    //MessageBox.Show(ctmKey + " the row pos is " + currentFind.Row.ToString() + " the column pos is " + currentFind.Column.ToString());
                                }
                            }
                            catch
                            {
                                continue;
                            }
                        }
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
            }
            MessageBox.Show("完成");
        }
    }
}