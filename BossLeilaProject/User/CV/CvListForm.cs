using BossLeilaProject.AppCode.Data_Source;
using BossLeilaProject.AppCode.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossLeilaProject.User.CV
{
    public partial class CvListForm : Form
    {
        public CvListForm()
        {
            InitializeComponent();
            dataGridView1.InitDefault();
            yeniləToolStripMenuItem_Click(null, null);

        }

        private void CvListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bossDataSet.VwCv' table. You can move, or remove it, as needed.
            this.vwCvTableAdapter.Fill(this.bossDataSet.VwCv);
            // TODO: This line of code loads data into the 'bossDataSet.VwSubCategory' table. You can move, or remove it, as needed.
            this.vwSubCategoryTableAdapter.Fill(this.bossDataSet.VwSubCategory);

        }

        private void əlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fm = new CVForm())
            {
                var result = fm.ShowDialog();
                if (result == DialogResult.OK)
                {

                    vwCvTableAdapter.Fill(bossDataSet.VwCv);
                    yeniləToolStripMenuItem_Click(null, null);



                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var selected = dataGridView1.GetSelectedRow<BossDataSet.VwCvRow>();
            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            if (MessageBox.Show("Silmek istediyinizden eminsinizmi?", "Sorgu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                vwCvTableAdapter.DeleteCV(Program.userİd, selected.Id);
                vwCvTableAdapter.Fill(bossDataSet.VwCv);
                yeniləToolStripMenuItem_Click(null, null);

            }
        }

        private void yeniləToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vwCvTableAdapter.Fill(bossDataSet.VwCv);

        }

        private void redaktəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = vwCvBindingSource.Current as DataRowView;
            var selecteEdu = selected.Row as BossDataSet.VwCvRow;

            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            using (var fm = new CVForm(selecteEdu))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    vwCvTableAdapter.Fill(bossDataSet.VwCv);
                    yeniləToolStripMenuItem_Click(null, null);


                }
            }
        }
    }
}
