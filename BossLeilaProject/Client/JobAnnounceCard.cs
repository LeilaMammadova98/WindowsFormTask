using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BossLeilaProject.AppCode.Data_Source;
using BossLeilaProject.Client.Description;

namespace BossLeilaProject.Client
{
    public partial class JobAnnounceCard : UserControl
    {
      //  readonly BossDataSet.VwAnnounceRow jobAnnounce;
        public JobAnnounceCard()
        {
            InitializeComponent();
        }
        public JobAnnounceCard(BossDataSet.VwAnnounceRow jobAnnounce)
           : this()
        {
            this.label1.Text = jobAnnounce.Sub_Category;
            this.label2.Text = jobAnnounce.Salary+ " ₼";
            this.label3.Text = jobAnnounce.Company;
            this.Tag = jobAnnounce.Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fm = new AnnounceDescription(Convert.ToInt32(this.Tag)))
            {

                fm.ShowDialog();


            }

        }
    }
}
