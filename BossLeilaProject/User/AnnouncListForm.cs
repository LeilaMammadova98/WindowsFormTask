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

namespace BossLeilaProject.User
{
    public partial class AnnouncListForm : Form
    {
        public AnnouncListForm()
        {
            InitializeComponent();
            dataGridView1.InitDefault();
            yeniləToolStripMenuItem_Click(null, null);

        }

        private void AnnouncListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bossDataSet.VwAnnounce' table. You can move, or remove it, as needed.
            this.vwAnnounceTableAdapter.Fill(this.bossDataSet.VwAnnounce);

        }

        private void əlavəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fm = new AddAnounceForm2())
            {
                var result = fm.ShowDialog();
                if (result == DialogResult.OK)
                {

                    vwAnnounceTableAdapter.Fill(bossDataSet.VwAnnounce);
                    yeniləToolStripMenuItem_Click(null, null);


                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.GetSelectedRow<BossDataSet.VwAnnounceRow>();
            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            if (MessageBox.Show("Silmek istediyinizden eminsinizmi?", "Sorgu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                vwAnnounceTableAdapter.DeleteAnnounce(Program.userİd, selected.Id);
                vwAnnounceTableAdapter.Fill(bossDataSet.VwAnnounce);
                yeniləToolStripMenuItem_Click(null, null);

            }
        }

        private void yeniləToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vwAnnounceTableAdapter.Fill(bossDataSet.VwAnnounce);

        }

        private void redaktəEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = vwAnnounceBindingSource.Current as DataRowView;
            var selecteEdu = selected.Row as BossDataSet.VwAnnounceRow;

            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            using (var fm = new AddAnounceForm2(selecteEdu))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    vwAnnounceTableAdapter.Fill(bossDataSet.VwAnnounce);
                    yeniləToolStripMenuItem_Click(null, null);


                }
            }
        }
    }
}
