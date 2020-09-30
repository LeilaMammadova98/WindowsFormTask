using BossLeilaProject.AppCode.Data_Source;
using BossLeilaProject.Client;
using BossLeilaProject.User;
using BossLeilaProject.User.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossLeilaProject
{
    public partial class ClientFrameForm : Form
    {
        public ClientFrameForm()
        {
            InitializeComponent();
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            using (var fm = new AddAnounceForm2())
            {
                var result = fm.ShowDialog();
                if (result == DialogResult.OK)
                {

                    vwAnnounceTableAdapter1.Fill(bossDataSet1.VwAnnounce);


                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var fm = new CVForm())
            {
                var result = fm.ShowDialog();
                if (result == DialogResult.OK)
                {


                    vwCvTableAdapter1.Fill(bossDataSet1.VwCv);


                }
            }
        }

        private void ClientFrameForm_Load(object sender, EventArgs e)
        {
           




            vwAnnounceTableAdapter1.Fill(bossDataSet1.VwAnnounce);
            announcePanel.Controls.Clear();
            foreach( BossDataSet.VwAnnounceRow jobAnnounce in bossDataSet1.VwAnnounce)
            {
                var announce = new JobAnnounceCard(jobAnnounce);
                announcePanel.Controls.Add(announce);
            }

            vwCvTableAdapter1.Fill(bossDataSet1.VwCv);
            cvPanel.Controls.Clear();
            foreach (BossDataSet.VwCvRow cvAdd in bossDataSet1.VwCv)
            {
                var cv = new CvCard(cvAdd);
                cvPanel.Controls.Add(cv);
            }

        }

        private void cvPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}