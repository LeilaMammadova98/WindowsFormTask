using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossLeilaProject.AppCode.Helpers
{
    static partial class Extension
    {
        static public DataGridView InitDefault(this DataGridView dgv, bool @readonly = true)
        {
            var font = new Font(dgv.Font.FontFamily, 10);
            var fontBold = new Font(dgv.Font.FontFamily, 10, FontStyle.Bold);
            var padding = new Padding(2);

            dgv.RowTemplate.Height = 28;
            dgv.ColumnHeadersDefaultCellStyle.Padding = padding;
            dgv.ColumnHeadersDefaultCellStyle.Font = fontBold;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Cursor = Cursors.Hand;
            dgv.Font = font;
            dgv.BackgroundColor = SystemColors.Control;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F3F3F3");
            dgv.RowsDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#808080");
            dgv.RowsDefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#ffffff");

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.ReadOnly = @readonly;
                col.DefaultCellStyle.Padding = padding;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

                if (col.HeaderText == "#" || col.HeaderText == "Id" ||col.HeaderText == "№" )
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    col.Resizable = DataGridViewTriState.False;
                    col.Width = 50;
                    col.MinimumWidth = 50;
                }
            }


            dgv.MouseDown += delegate (object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Right)
                {
                    var hti = dgv.HitTest(e.X, e.Y);
                    dgv.ClearSelection();
                    if (hti.RowIndex < 0)
                        dgv.Rows[0].Selected = true;
                    else
                        dgv.Rows[hti.RowIndex].Selected = true;
                }
            };

            return dgv;
        }

        static public T GetSelectedRow<T>(this DataGridView dgv)
            where T : DataRow
        {
            if (dgv.SelectedRows.Count < 1)
                return null;

            var selectedRow = dgv.SelectedRows[0];

            DataRow dataRow = (selectedRow.DataBoundItem as DataRowView)?.Row;

            var boundedRow = dataRow as T;

            return boundedRow;
        }
        static public IEnumerable<T> GetSelectedRows<T>(this DataGridView dgv)
            where T : DataRow
        {
            var selecteds = Enumerable.Empty<T>().ToList();

            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                var dataRow = (row.DataBoundItem as DataRowView)?.Row;

                var boundedRow = dataRow as T;

                if (boundedRow == null)
                    break;

                selecteds.Add(boundedRow);
            }

            return selecteds;
        }
    }
}
