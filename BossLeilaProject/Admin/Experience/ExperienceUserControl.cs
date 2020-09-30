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

namespace BossLeilaProject.Admin.Experience
{
    public partial class ExperienceUserControl : UserControl
    {
        public ExperienceUserControl()
        {
            InitializeComponent();
              dataGridView1.InitDefault();
            vwExperienceTableAdapter.Fill(bossDataSet.VwExperience);
        }
    }
}
