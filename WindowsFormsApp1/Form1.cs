using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ExcelSheetCore excelFile = new ExcelSheetCore();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Quotation.SetQuotationListBox(QuoteListBox);
            QuoteListBox.SelectedIndex = 0;
            Employee.SetEmployeeComboBox(employeeComboBox);
        }

        private void QuoteListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CustomComboBox.SetEmployeeGridComboBox(employeeCbColumn);
                QuotationDetail.SetOrderDetailGridView(orderDetailGridView, QuoteListBox.SelectedValue.ToString(), employeeComboBox.SelectedValue.ToString());
            }
            catch
            {
            }
            excelFile.XLWorkBook = null;
        }

        private void quoteSaveButton_Click(object sender, EventArgs e)
        {
            QuotationDetail.SaveQuoteSheet(orderDetailGridView);
        }

        private void openExcelButton_Click(object sender, EventArgs e)
        {
            string fileExcel;
            OpenFileDialog openDialogbox1 = new OpenFileDialog();
            openDialogbox1.Title = "Open Excel";
            openDialogbox1.Filter = "Excel Files|*.xls;*.xlsx";
            if (openDialogbox1.ShowDialog() == DialogResult.OK)
            {
                fileExcel = openDialogbox1.FileName;
            }
            else return;
            excelFile.SetWorkBook(fileExcel);
        }

        private void saveExcelButton_Click(object sender, EventArgs e)
        {
            if (excelFile.XLWorkBook != null)
            {
                try
                {
                    excelFile.PriceUpDate(int.Parse(excelIndexOffest.Text.ToString()), orderDetailGridView);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("請輸入客戶報價欄位離客戶識別碼的格數");
                }
            }
            else
            {
                MessageBox.Show("請打開EXCEL檔");
            }
        }

        private void quoteNumberLabel_TextChanged(object sender, EventArgs e)
        {
        }

        private void writeDbButton_Click(object sender, EventArgs e)
        {
            if (excelFile.XLWorkBook != null)
            {
                try
                {
                    excelFile.DatagridPriceUpdate(int.Parse(excelIndexOffest.Text.ToString()), orderDetailGridView);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("請輸入客戶報價欄位離客戶識別碼的格數");
                }
            }
            else
            {
                MessageBox.Show("請打開EXCEL檔");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("tabindex" + tabControl1.SelectedTab);
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    Quotation.SetQuotationListBox(QuoteListBox2);

                    break;

                case 2:
                    Supplier.SetSupplierListBox(supplierListBox);

                    break;

                case 3:
                    Employee.SetEmployeeComboBox(employeeListBox);

                    break;

                default:
                    break;
            }
        }

        private void QuoteListBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            //quoteNumberLabel.Text = QuoteListBox.SelectedValue.ToString();
            CustomComboBox.SetDataGridComboBox(partNoComboBox);
            PartCrossRef.SetPartCrossRefGridView(partCrossRefDataGridView, partNoComboBox, QuoteListBox2.SelectedValue.ToString());
            //MessageBox.Show("Column1" + partCrossRefDataGridView.Columns[0].CellType.ToString());
        }

        private void employeeItemSaveButton_Click(object sender, EventArgs e)
        {
            Employee.UpdateEmployeeItem(orderDetailGridView);
        }

        private void supplierListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemPacker.SetItemPackerDataGridView(itemPackerDataGridView, supplierListBox.SelectedValue.ToString());
        }

        private void saveItemPackerButton_Click(object sender, EventArgs e)
        {
            ItemPacker.SaveItemPacker(itemPackerDataGridView);
        }

        private void saveCrossRefButton_Click(object sender, EventArgs e)
        {
            PartCrossRef.SavePartCrossRef(partCrossRefDataGridView);
        }

        private void employeeListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(employeeListBox.SelectedValue.ToString().Trim());
            if (employeeListBox.SelectedValue.ToString().Trim() == "C")
            {
                Supplier.SetSupplierListBox(supplierListBox2);
            }
            else
            {
                //ItemPacker.SetItemPackerLabelDataGridView(itemPackerLabelDataGridView);
            }
        }
    }
}