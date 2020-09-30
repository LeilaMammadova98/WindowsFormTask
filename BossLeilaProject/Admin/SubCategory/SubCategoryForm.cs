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

namespace BossLeilaProject.Admin.SubCategory
{
    public partial class SubCategoryForm : Form
    {
        public SubCategoryForm()
        {
            InitializeComponent();
            btnYes.InitDefault(type: ButtonType.Success);
            btnCancel.InitDefault(type: ButtonType.Danger);
        }
        BossDataSet.VwSubCategoryRow selected1;
        public SubCategoryForm(BossDataSet.VwSubCategoryRow selected)
           : this()
        {
            selected1 = selected;
            textBox1.Text = selected.Name;
            comboCategory.SelectedItem = selected.Category_Name;

           
            this.Tag = selected.Id;
        }

        private void SubCategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bossDataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.bossDataSet1.Categories);
            // TODO: This line of code loads data into the 'bossDataSet.VwEducation' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bossDataSet.VwCategories' table. You can move, or remove it, as needed.
            this.vwCategoriesTableAdapter.Fill(this.bossDataSet.VwCategories);
            // TODO: This line of code loads data into the 'bossDataSet.VwSubCategory' table. You can move, or remove it, as needed.
            this.vwSubCategoryTableAdapter.Fill(this.bossDataSet.VwSubCategory);
            comboCategory.SelectedValue = selected1.CategoryId;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(comboCategory.SelectedValue);

            if (this.Tag == null)
            {

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    return;
                }
                vwSubCategoryTableAdapter.InsertSub(textBox1.Text, Program.userİd,categoryId);

                this.DialogResult = DialogResult.OK;

            }
            else
            {
                int id = Convert.ToInt32(this.Tag);
                vwSubCategoryTableAdapter.UpdateSub(textBox1.Text, Program.userİd,categoryId,id);
              this.DialogResult = DialogResult.OK;
            }
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

       
    }
}
