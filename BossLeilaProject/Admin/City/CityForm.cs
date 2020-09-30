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

namespace BossLeilaProject.Admin.City
{
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();
            btnYes.InitDefault(type: ButtonType.Success);
            btnCancel.InitDefault(type: ButtonType.Danger);
        }

        public CityForm(BossDataSet.VwCityRow selected)
            : this()
        {
            textBox1.Text = selected.Name;
            this.Tag = selected.Id;

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    return;
                }

                vwCityTableAdapter1.InsertCity(textBox1.Text, Program.userİd);



            }
            else
            {
                int id = Convert.ToInt32(this.Tag);
                vwCityTableAdapter1.UpdateCity(textBox1.Text, Program.userİd, id);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }


    }
}
