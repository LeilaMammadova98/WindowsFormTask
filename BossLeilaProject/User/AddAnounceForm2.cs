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
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace BossLeilaProject.User
{
    public partial class AddAnounceForm2 : Form
    {
        public AddAnounceForm2()
        {
            InitializeComponent();
      

            btnYes.InitDefault(type: ButtonType.Success);
            btnCancel.InitDefault(type: ButtonType.Danger);
            toolTip1.SetToolTip(txtNumber, "Telefon: 012-333-33-33");
            toolTip1.SetToolTip(txtİnfo, "Burad vakansiya barədə məlumatlar qeyd olunmalıdır");
            toolTip1.SetToolTip(txtRequir, "Burada vakansiya üçün tələblər qeyd olunmalıdır");
            toolTip1.SetToolTip(txtSalary, "Burada maaşın həcmi qeyd olunmalıdır");
            toolTip1.SetToolTip(txtEmail, "Burada email ünvanınız qeyd olunmalıdır");



        }
        BossDataSet.VwAnnounceRow selected1;

        public AddAnounceForm2(BossDataSet.VwAnnounceRow selected)
   : this()
        {
       selected1 = selected;
            txtNumber.Text = selected.Number; ;
            txtRequir.Text = selected.Requirements;
            txtEmail.Text = selected.Email;
            txtSalary.Text = selected.Salary;
            txtİnfo.Text = selected.Information;
            txtGender.Text = selected.Gender;
            comboCateg.SelectedValue = selected.Category;
            comboCity.SelectedValue = selected.City  ;
            comboComp.SelectedValue = selected.Company      ;   
            comboDuty.SelectedValue = selected.Sub_Category ;
            comboEdu.SelectedValue = selected.Education  ;
            comboExperience.SelectedValue = selected.Experience;
            this.Tag = selected.Id;

        }

        private void AddAnounceForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bossDataSet1.VwExperience' table. You can move, or remove it, as needed.
            this.vwExperienceTableAdapter.Fill(this.bossDataSet1.VwExperience);
            // TODO: This line of code loads data into the 'bossDataSet1.VwEducation' table. You can move, or remove it, as needed.
            this.vwEducationTableAdapter.Fill(this.bossDataSet1.VwEducation);
            // TODO: This line of code loads data into the 'bossDataSet1.VwSubCategory' table. You can move, or remove it, as needed.
            this.vwSubCategoryTableAdapter.Fill(this.bossDataSet1.VwSubCategory);
            // TODO: This line of code loads data into the 'bossDataSet1.VwCity' table. You can move, or remove it, as needed.
            this.vwCityTableAdapter.Fill(this.bossDataSet1.VwCity);
            // TODO: This line of code loads data into the 'bossDataSet1.VwCategories' table. You can move, or remove it, as needed.
            this.vwCategoriesTableAdapter.Fill(this.bossDataSet1.VwCategories);
            // TODO: This line of code loads data into the 'bossDataSet1.VwCompanies' table. You can move, or remove it, as needed.
            this.vwCompaniesTableAdapter.Fill(this.bossDataSet1.VwCompanies);
            // TODO: This line of code loads data into the 'bossDataSet.Companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.bossDataSet.Companies);
            // TODO: This line of code loads data into the 'bossDataSet.VwAnnounce' table. You can move, or remove it, as needed.
            this.vwAnnounceTableAdapter1.Fill(this.bossDataSet.VwAnnounce);
            if (this.Tag != null)
            {

                comboCateg.SelectedValue = selected1.CategoriesId;
                comboCity.SelectedValue = selected1.CityId;
                comboComp.SelectedValue = selected1.CompaniesId;
                comboDuty.SelectedValue = selected1.SubCategryId;
                comboEdu.SelectedValue = selected1.EducationId;
                comboExperience.SelectedValue = selected1.ExperienceId;

            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
          
            if (this.Tag == null)
            {
                int cityId = Convert.ToInt32(comboCity.SelectedValue);
                int categ = Convert.ToInt32(comboCateg.SelectedValue);
                int eduId = Convert.ToInt32(comboEdu.SelectedValue);
                int experienceId = Convert.ToInt32(comboExperience.SelectedValue);

                int companyId = Convert.ToInt32(comboComp.SelectedValue);

                int subcategId = Convert.ToInt32(comboDuty.SelectedValue);
  errorProvider1.Clear();
                if(string.IsNullOrWhiteSpace(txtRequir.Text)|| string.IsNullOrWhiteSpace(txtSalary.Text) || string.IsNullOrWhiteSpace(txtNumber.Text) || string.IsNullOrWhiteSpace(txtGender.Text) || string.IsNullOrWhiteSpace(txtİnfo.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Form tamamlanmayıb,bütün xanalar doludurmalıdır");
                    return;
                }
                if (int.TryParse(txtSalary.Text, out int a) == false)
                {
                    errorProvider1.SetError(txtSalary, "Rəqəm qeyd olunmalıdır");
                    return;

                }
                if (!string.IsNullOrWhiteSpace(txtNumber.Text) && !txtNumber.Text.isHomeNum())
                {
                    errorProvider1.SetError(txtNumber, "Telefon formatı düz deyil");
                    return;
                }
               

                vwAnnounceTableAdapter1.İnsertAnnounce(Program.userİd,txtNumber.Text,txtEmail.Text,txtİnfo.Text,txtRequir.Text,txtSalary.Text,txtGender.Text,cityId,categ,companyId,eduId,experienceId,subcategId,ageMin.Value,ageMax.Value);
                this.DialogResult = DialogResult.OK;


            }
            else
            {
                int id = Convert.ToInt32(this.Tag);
                errorProvider1.Clear();
                if (string.IsNullOrWhiteSpace(txtRequir.Text) || string.IsNullOrWhiteSpace(txtSalary.Text) || string.IsNullOrWhiteSpace(txtNumber.Text) || string.IsNullOrWhiteSpace(txtGender.Text) || string.IsNullOrWhiteSpace(txtİnfo.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Form tamamlanmayıb,bütün xanalar doludurmalıdır");
                    return;
                }
                if (int.TryParse(txtSalary.Text, out int a) == false)
                {
                    errorProvider1.SetError(txtSalary, "Rəqəm qeyd olunmalıdır");
                    return;

                }
                if (!string.IsNullOrWhiteSpace(txtNumber.Text) && !txtNumber.Text.isHomeNum())
                {
                    errorProvider1.SetError(txtNumber, "Telefon formatı düz deyil");
                    return;
                }
                vwAnnounceTableAdapter1.UpdateAnnounce(txtNumber.Text,txtEmail.Text,txtİnfo.Text,txtRequir. Text,txtSalary.Text,Program.userİd,txtGender.Text,Convert.ToInt32(comboCity.SelectedValue),Convert.ToInt32(comboCateg.SelectedValue), Convert.ToInt32(comboComp.SelectedValue), Convert.ToInt32(comboEdu.SelectedValue), Convert.ToInt32(comboExperience.SelectedValue), Convert.ToInt32(comboDuty.SelectedValue), ageMax.Value,ageMin.Value,id);
            this.DialogResult = DialogResult.OK;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void comboCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            var catId = Convert.ToInt32(comboCateg.SelectedValue);
            vwSubCategoryTableAdapter.FillByCategory(bossDataSet1.VwSubCategory, catId);
        }
    }
}
