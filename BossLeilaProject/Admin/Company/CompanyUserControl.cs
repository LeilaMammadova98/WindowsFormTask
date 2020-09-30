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

namespace BossLeilaProject.Admin.City
{
    public partial class CityUserControl : UserControl
    {
        public CityUserControl()
        {
            InitializeComponent();
            dataGridView1.InitDefault();
            vwCityTableAdapter.Fill(bossDataSet.VwCity);
            yeniləToolStripMenuItem_Click(null, null);
        }

        private void elaveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fm = new CityForm())
            {
                var result = fm.ShowDialog();
                if (result == DialogResult.OK)
                {

                    vwCityTableAdapter.Fill(bossDataSet.VwCity);
                    yeniləToolStripMenuItem_Click(null, null);


                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.GetSelectedRow<BossDataSet.VwCityRow>();
            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            if (MessageBox.Show("Silmek istediyinizden eminsinizmi?", "Sorgu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                vwCityTableAdapter.DeleteCity(Program.userİd, selected.Id);
                vwCityTableAdapter.Fill(bossDataSet.VwCity);
                yeniləToolStripMenuItem_Click(null, null);


            }
        }

        private void redakteEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = vwCityBindingSource.Current as DataRowView;
            var selecteEdu = selected.Row as BossDataSet.VwCityRow;

            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            using (var fm = new CityForm(selecteEdu))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    vwCityTableAdapter.Fill(bossDataSet.VwCity);
                    yeniləToolStripMenuItem_Click(null, null);


                }
            }
    }

        private void yeniləToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vwCityTableAdapter.Fill(bossDataSet.VwCity);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }