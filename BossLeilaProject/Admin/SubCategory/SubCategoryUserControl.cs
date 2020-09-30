using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BossLeilaProject.AppCode.Helpers;
using BossLeilaProject.AppCode.Data_Source;

namespace BossLeilaProject.Admin.SubCategory
{
    public partial class SubCategoryUserControl : UserControl
    {
        public SubCategoryUserControl()
        {
            InitializeComponent();
            dataGridView1.InitDefault();
            vwSubCategoryTableAdapter.Fill(bossDataSet1.VwSubCategory);
            yeniləToolStripMenuItem_Click(null, null);
        }

        private void əlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var fm = new SubCategoryForm())
            {
                var result = fm.ShowDialog();
                if (result == DialogResult.OK)
                {

                    vwSubCategoryTableAdapter.Fill(bossDataSet1.VwSubCategory);
                    yeniləToolStripMenuItem_Click(null, null);


                }
            }
        }

        private void yeniləToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vwSubCategoryTableAdapter.Fill(bossDataSet1.VwSubCategory);

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.GetSelectedRow<BossDataSet.VwSubCategoryRow>();
            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            if (MessageBox.Show("Silmek istediyinizden eminsinizmi?", "Sorgu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                vwSubCategoryTableAdapter.DeleteSub(Program.userİd, selected.Id);
                vwSubCategoryTableAdapter.Fill(bossDataSet1.VwSubCategory);
                yeniləToolStripMenuItem_Click(null, null);


            }
        }

        private void redaktəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = vwSubCategoryBindingSource.Current as DataRowView;
            var selecteEdu = selected.Row as BossDataSet.VwSubCategoryRow;

            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            using (var fm = new SubCategoryForm(selecteEdu))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    vwSubCategoryTableAdapter.Fill(bossDataSet1.VwSubCategory);
                    yeniləToolStripMenuItem_Click(null, null);


                }
            }
        }
    }
}
