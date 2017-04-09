using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Renderer
    {
        public static void RenderUI(object view)
        {
            //MessageBox.Show("viewtype" + view.GetType().ToString());

            if (view is DataGridView)
            {
                DataGridView dg = (DataGridView)view;
                dg.DefaultCellStyle.Font = new Font("Tahoma", 12);
                dg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dg.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                foreach (DataGridViewColumn column in dg.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            if (view is ListBox)
            {
                ListBox lb = (ListBox)view;
                lb.Font = new Font("Tahoma", 12);

                lb.BackColor = Color.LightGray;
            }
        }
    }
}