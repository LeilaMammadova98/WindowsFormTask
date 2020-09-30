using BossLeilaProject.AppCode.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossLeilaProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnYes.InitDefault(type: ButtonType.Success);
            btnCancel.InitDefault(type: ButtonType.Danger);

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "İstifadəçi adı qeyd olunmayıb");
                return;
            }

            if (!Regex.IsMatch(txtName.Text,@"[a-zA-Z0-9._%-]+@[a-zA-Z0-9._%-]+\.[a-zA-Z]{2,4}"))
            {
                errorProvider1.SetError(txtName, "Email qeyd olunmayıb");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Şifrə qeyd olunmayıb");
                return;
            }
            if (txtPassword.Text.Length<3)
            {
                errorProvider1.SetError(txtPassword, "Şifrə minimum 3 simvoldan ibarət olmalıdır");
                return;
            }

            string pwdHash = txtPassword.Text.Md5();
           var userTable= vwUserTableAdapter1.GetDataByCred(txtName.Text, pwdHash).FirstOrDefault();
            if (userTable == null)
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır", "Xəta", 0, MessageBoxIcon.Warning);


            }
    
        
        else if (userTable.RolesId == 1)
            {
                this.Hide();
                using (var frmadmin=new Form1())
                {
                    frmadmin.ShowDialog();
                }
            }
            else if (userTable.RolesId == 2)
            {
                this.Hide();
                using (var frmadmin = new ClientFrameForm())
                {
                    frmadmin.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("İstifadəçi qeydiyyatlı deyil", "Xəta", 0, MessageBoxIcon.Warning);

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
