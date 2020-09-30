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
using BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters;

namespace BossLeilaProject.Client
{
    public partial class CvCard : UserControl
    {
        
       readonly BossDataSet.VwCvRow cv;

        public CvCard()
        {
            InitializeComponent();
        }
        public CvCard(BossDataSet.VwCvRow cvAdd)
        : this()
        {
            this.label1.Text = cvAdd.Sub_Category;
            this.label2.Text = cvAdd.MinSalary + " ₼";
            this.label3.Text = cvAdd.Name + " " + cvAdd.SurName; ;
            this.Tag = cvAdd.Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (var fm = new CvDescription(Convert.ToInt32(this.Tag)))
            {

                fm.ShowDialog();


            }
        }

    
    }
}
