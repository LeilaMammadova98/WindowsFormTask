﻿using BossLeilaProject.AppCode.Data_Source;
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

namespace BossLeilaProject.Admin.Companies2
{
    public partial class CompaniesForm : Form
    {
        public CompaniesForm()
        {
            InitializeComponent();
            btnYes.InitDefault(type: ButtonType.Success);
            btnCancel.InitDefault(type: ButtonType.Danger);
        }
        public CompaniesForm(BossDataSet.VwCompaniesRow selected)
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

                vwCompaniesTableAdapter1.InsertCompany(textBox1.Text, Program.userİd);


                this.DialogResult = DialogResult.OK;

            }
            else
            {
                int id = Convert.ToInt32(this.Tag);
                vwCompaniesTableAdapter1.UpdateCompany(textBox1.Text, Program.userİd, id);
                this.DialogResult = DialogResult.OK;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
