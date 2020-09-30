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

namespace BossLeilaProject.Admin.Companies2
{
    public partial class CompaniesUserControl : UserControl
    {
        public CompaniesUserControl()
        {
            InitializeComponent();
            dataGridView1.InitDefault();
            vwCompaniesTableAdapter.Fill(bossDataSet.VwCompanies);
            yeniləToolStripMenuItem_Click(null, null);
        }

        private void əlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fm = new CompaniesForm())
            {
                var result = fm.ShowDialog();
                if (result == DialogResult.OK)
                {

                    vwCompaniesTableAdapter.Fill(bossDataSet.VwCompanies);
                    yeniləToolStripMenuItem_Click(null, null);


                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.GetSelectedRow<BossDataSet.VwCompaniesRow>();
            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            if (MessageBox.Show("Silmek istediyinizden eminsinizmi?", "Sorgu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                vwCompaniesTableAdapter.DeleteCompany(Program.userİd, selected.Id);
                vwCompaniesTableAdapter.Fill(bossDataSet.VwCompanies);
                yeniləToolStripMenuItem_Click(null, null);


            }
        }

        private void yeniləToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vwCompaniesTableAdapter.Fill(bossDataSet.VwCompanies);

        }

        private void redaktəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = vwCompaniesBindingSource.Current as DataRowView;
            var selecteEdu = selected.Row as BossDataSet.VwCompaniesRow;

            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            using (var fm = new CompaniesForm(selecteEdu))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    vwCompaniesTableAdapter.Fill(bossDataSet.VwCompanies);
                    yeniləToolStripMenuItem_Click(null, null);


                }
            }
        }
    }
}
