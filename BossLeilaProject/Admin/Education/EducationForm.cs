using BossLeilaProject.AppCode.Data_Source;
using BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters;
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

namespace BossLeilaProject.Admin.Education
{
    public partial class EducationForm : Form
    {
     //   BossDataSet.VwEducationRow selected = null;

        public EducationForm()
        {
            InitializeComponent();
            btnYes.InitDefault(type: ButtonType.Success);
            btnCancel.InitDefault(type: ButtonType.Danger);
        }
        public EducationForm(BossDataSet.VwEducationRow selected)
            : this()
        {
            textBox1.Text = selected.Name;
            this.Tag = selected.Id;
                
                }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnYes_Click_1(object sender, EventArgs e)
        {

            if (this.Tag == null)
            {

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    return;
                }

                vwEducationTableAdapter.İnsertEducation(textBox1.Text, Program.userİd);


              
            }
            else
            {
                int id = Convert.ToInt32(this.Tag);
                vwEducationTableAdapter.UpdateEdu(textBox1.Text, Program.userİd, id);
            }
  this.DialogResult = DialogResult.OK;
        }

    }
    
}
