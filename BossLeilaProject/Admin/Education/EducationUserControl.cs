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

namespace BossLeilaProject.Admin.Education
{
    public partial class EducationUserControl : UserControl
        
    {
        public EducationUserControl()
        {
           
            InitializeComponent();
            dataGridView1.InitDefault();
            vwEducationTableAdapter.Fill(bossDataSet.VwEducation);
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var fm=new EducationForm())
            {
                var result = fm.ShowDialog();
                if (result == DialogResult.OK)
                {

                    vwEducationTableAdapter.Fill(bossDataSet.VwEducation);

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selected = vwEducationBindingSource.Current as DataRowView;
            var selecteEdu = selected.Row as BossDataSet.VwEducationRow;

            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
            using ( var fm=new EducationForm(selecteEdu))
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    vwEducationTableAdapter.Fill(bossDataSet.VwEducation);

                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selected = dataGridView1.GetSelectedRow<BossDataSet.VwEducationRow>();
            if (selected == null)
            {
                MessageBox.Show("Sətir seçilməyib", "Xəta");
                return;
            }
           if(MessageBox.Show("Silmek istediyinizden eminsinizmi?", "Sorgu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                vwEducationTableAdapter.DeleteMainEdu(Program.userİd, selected.Id);
                vwEducationTableAdapter.Fill(bossDataSet.VwEducation);

            }
        }

    }
}
