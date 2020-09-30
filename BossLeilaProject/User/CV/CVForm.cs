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

namespace BossLeilaProject.User.CV
{
    public partial class CVForm : Form
    {
        public CVForm()
        {
            InitializeComponent();
            btnYes.InitDefault(type: ButtonType.Success);
            btnCancel.InitDefault(type: ButtonType.Danger);
            toolTip1.SetToolTip(txtNumber, "Telefon: 012-333-33-33");
            toolTip1.SetToolTip(txtAdditİnfo, "Burada əlavə məlumatlar qeyd olunmalıdır");
            toolTip1.SetToolTip(txtSkills, "Burada bacarıqlarınız qeyd olunmalıdır");
            toolTip1.SetToolTip(txtSalary, "Burada maaşın həcmi qeyd olunmalıdır");
            toolTip1.SetToolTip(txtEmail, "Burada email ünvanınız qeyd olunmalıdır");

        }
        BossDataSet.VwCvRow selected1;

        public CVForm(BossDataSet.VwCvRow selected)
   : this()
        {
            selected1 = selected;
            txtNumber.Text = selected.Number;
            txtExperienceAdd.Text = selected.ExperienceInformation;
            txtAdditİnfo.Text = selected.AdditionalInformation;
            txtEduAdd.Text = selected.EduInformation;
            txtSkills.Text = selected.SkillsInformation;
            txtFather.Text = selected.FatherName;
            txtEmail.Text = selected.Email;
            txtName.Text = selected.Name;
            txtSurname.Text = selected.SurName;
            txtSalary.Text = selected.MinSalary;
            txtGender.Text = selected.Gender;
      
            comboCateg.SelectedValue = selected.Category;
            comboCity.SelectedValue = selected.City;
            comboDuty.SelectedValue = selected.Sub_Category;
            comboEdu.SelectedValue = selected.Education;
            comboExperience.SelectedValue = selected.Experience;
            var main = selected.Language;
            string[] words = main.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (Array.IndexOf(words, checkedListBox1.Items[i].ToString()) != -1)
                {
                    checkedListBox1.SetItemChecked(i, true);

                }

            }
            this.Tag = selected.Id;

        }

        private void CVForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bossDataSet.VwCity' table. You can move, or remove it, as needed.
            this.vwCityTableAdapter.Fill(this.bossDataSet.VwCity);
            // TODO: This line of code loads data into the 'bossDataSet.VwSubCategory' table. You can move, or remove it, as needed.
            this.vwSubCategoryTableAdapter.Fill(this.bossDataSet.VwSubCategory);
            // TODO: This line of code loads data into the 'bossDataSet.VwCategories' table. You can move, or remove it, as needed.
            this.vwCategoriesTableAdapter.Fill(this.bossDataSet.VwCategories);
            // TODO: This line of code loads data into the 'bossDataSet.VwExperience' table. You can move, or remove it, as needed.
            this.vwExperienceTableAdapter.Fill(this.bossDataSet.VwExperience);
            // TODO: This line of code loads data into the 'bossDataSet.VwEducation' table. You can move, or remove it, as needed.
            this.vwEducationTableAdapter.Fill(this.bossDataSet.VwEducation);
            if (this.Tag != null)
            {

                comboCateg.SelectedValue = selected1.CategoriesId;
                comboCity.SelectedValue = selected1.CityId;
                comboDuty.SelectedValue = selected1.SubCategryId;
                comboEdu.SelectedValue = selected1.EducationId;
                comboExperience.SelectedValue = selected1.ExperienceId;

                var main = selected1.Language;
                string[] words = main.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (Array.IndexOf(words, checkedListBox1.Items[i].ToString()) != -1)
                    {
                        checkedListBox1.SetItemChecked(i, true);

                    }

                }

            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (this.Tag == null)
            {
                int cityId = Convert.ToInt32(comboCity.SelectedValue);
                int categ = Convert.ToInt32(comboCateg.SelectedValue);
           
            foreach (var item in checkedListBox1.CheckedItems)
            {
                    sb.Append($",{item}");
                        }
                string selectedBulk = sb.ToString();
                if (!string.IsNullOrWhiteSpace(selectedBulk))
                {
                    selectedBulk = selectedBulk.Substring(1);
                }
                    
                    int eduId = Convert.ToInt32(comboEdu.SelectedValue);
                int experienceId = Convert.ToInt32(comboExperience.SelectedValue);


                int subcategId = Convert.ToInt32(comboDuty.SelectedValue);
                errorProvider1.Clear();
                if (string.IsNullOrWhiteSpace(txtAdditİnfo.Text) || string.IsNullOrWhiteSpace(txtSalary.Text) || string.IsNullOrWhiteSpace(txtNumber.Text) || string.IsNullOrWhiteSpace(txtGender.Text) || string.IsNullOrWhiteSpace(txtEduAdd.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtExperienceAdd.Text) || string.IsNullOrWhiteSpace(txtFather.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSkills.Text))
                {
                    MessageBox.Show("Form tamamlanmayıb,bütün xanalar doludurmalıdır");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtNumber.Text) && !txtNumber.Text.isHomeNum())
                {
                    errorProvider1.SetError(txtNumber, "Telefon formatı düz deyil");
                    return;
                }
                if (int.TryParse(txtSalary.Text,out int a)==false) {
                    errorProvider1.SetError(txtSalary, "Rəqəm qeyd olunmalıdır");
                    return;
                
                }
               

                vwCvTableAdapter1.InsertCv(txtName.Text, txtSurname.Text, txtFather.Text, txtNumber.Text, txtEmail.Text, txtEduAdd.Text, txtExperienceAdd.Text, txtSkills.Text,txtAdditİnfo.Text, txtSalary.Text, Program.userİd, txtGender.Text, cityId, categ, eduId, experienceId, subcategId, ageMin.Value, selectedBulk);   
                    this.DialogResult = DialogResult.OK;


            }
            else
            {
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    sb.Append($",{item}");
                }
                string selectedBulk = sb.ToString();
                if (!string.IsNullOrWhiteSpace(selectedBulk))
                {
                    selectedBulk = selectedBulk.Substring(1);
                }
                int id = Convert.ToInt32(this.Tag);
                errorProvider1.Clear();
                if (string.IsNullOrWhiteSpace(txtAdditİnfo.Text) || string.IsNullOrWhiteSpace(txtSalary.Text) || string.IsNullOrWhiteSpace(txtNumber.Text) || string.IsNullOrWhiteSpace(txtGender.Text) || string.IsNullOrWhiteSpace(txtEduAdd.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtExperienceAdd.Text) || string.IsNullOrWhiteSpace(txtFather.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSkills.Text))
                {
                    MessageBox.Show("Form tamamlanmayıb,bütün xanalar doludurmalıdır");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtNumber.Text) && !txtNumber.Text.isHomeNum())
                {
                    errorProvider1.SetError(txtNumber, "Telefon formatı düz deyil");
                    return;
                }
                if (int.TryParse(txtSalary.Text, out int a) == false)
                {
                    errorProvider1.SetError(txtSalary, "Rəqəm qeyd olunmalıdır");
                    return;

                }
                vwCvTableAdapter1.UpdateCv(txtName.Text,txtSurname.Text,txtFather.Text,txtNumber.Text, txtEmail.Text,txtEduAdd.Text,txtExperienceAdd.Text,txtSkills.Text,txtAdditİnfo.Text, txtSalary.Text,txtGender.Text,Convert.ToInt32(comboCity.SelectedValue), Convert.ToInt32(comboCateg.SelectedValue), Convert.ToInt32(comboEdu.SelectedValue), Convert.ToInt32(comboExperience.SelectedValue), Convert.ToInt32(comboDuty.SelectedValue),ageMin.Value,Program.userİd, selectedBulk, id);
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
            vwSubCategoryTableAdapter.FillByCategory(bossDataSet.VwSubCategory, catId);
        }

     
    }
}
