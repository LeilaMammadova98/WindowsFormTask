namespace BossLeilaProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Təhsil = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.educationUserControl2 = new BossLeilaProject.Admin.Education.EducationUserControl();
            this.experienceUserControl1 = new BossLeilaProject.Admin.Experience.ExperienceUserControl();
            this.cityUserControl1 = new BossLeilaProject.Admin.City.CityUserControl();
            this.categoriesUserControl1 = new BossLeilaProject.Admin.Categories.CategoriesUserControl();
            this.subCategoryUserControl1 = new BossLeilaProject.Admin.SubCategory.SubCategoryUserControl();
            this.companiesUserControl1 = new BossLeilaProject.Admin.Companies2.CompaniesUserControl();
            this.tabControl1.SuspendLayout();
            this.Təhsil.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Təhsil);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 349);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // Təhsil
            // 
            this.Təhsil.Controls.Add(this.educationUserControl2);
            this.Təhsil.Location = new System.Drawing.Point(4, 22);
            this.Təhsil.Name = "Təhsil";
            this.Təhsil.Padding = new System.Windows.Forms.Padding(3);
            this.Təhsil.Size = new System.Drawing.Size(576, 323);
            this.Təhsil.TabIndex = 0;
            this.Təhsil.Text = "Təhsil";
            this.Təhsil.UseVisualStyleBackColor = true;
            this.Təhsil.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.experienceUserControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İş  təcrübəsi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cityUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 323);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Şəhərlər";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.categoriesUserControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(576, 323);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Kateqoriyalar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.subCategoryUserControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(576, 323);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Alt kateqoriyalar";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.companiesUserControl1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(576, 323);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Şirkətlər";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // educationUserControl2
            // 
            this.educationUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.educationUserControl2.Location = new System.Drawing.Point(3, 3);
            this.educationUserControl2.Name = "educationUserControl2";
            this.educationUserControl2.Size = new System.Drawing.Size(570, 317);
            this.educationUserControl2.TabIndex = 0;
            // 
            // experienceUserControl1
            // 
            this.experienceUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.experienceUserControl1.Location = new System.Drawing.Point(3, 3);
            this.experienceUserControl1.Name = "experienceUserControl1";
            this.experienceUserControl1.Size = new System.Drawing.Size(570, 317);
            this.experienceUserControl1.TabIndex = 0;
            // 
            // cityUserControl1
            // 
            this.cityUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityUserControl1.Location = new System.Drawing.Point(3, 3);
            this.cityUserControl1.Name = "cityUserControl1";
            this.cityUserControl1.Size = new System.Drawing.Size(570, 317);
            this.cityUserControl1.TabIndex = 0;
            // 
            // categoriesUserControl1
            // 
            this.categoriesUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesUserControl1.Location = new System.Drawing.Point(3, 3);
            this.categoriesUserControl1.Name = "categoriesUserControl1";
            this.categoriesUserControl1.Size = new System.Drawing.Size(570, 317);
            this.categoriesUserControl1.TabIndex = 0;
            // 
            // subCategoryUserControl1
            // 
            this.subCategoryUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subCategoryUserControl1.Location = new System.Drawing.Point(3, 3);
            this.subCategoryUserControl1.Name = "subCategoryUserControl1";
            this.subCategoryUserControl1.Size = new System.Drawing.Size(570, 317);
            this.subCategoryUserControl1.TabIndex = 0;
            this.subCategoryUserControl1.Load += new System.EventHandler(this.subCategoryUserControl1_Load);
            // 
            // companiesUserControl1
            // 
            this.companiesUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companiesUserControl1.Location = new System.Drawing.Point(3, 3);
            this.companiesUserControl1.Name = "companiesUserControl1";
            this.companiesUserControl1.Size = new System.Drawing.Size(570, 317);
            this.companiesUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 349);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.tabControl1.ResumeLayout(false);
            this.Təhsil.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Təhsil;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private Admin.Education.EducationUserControl educationUserControl2;
        private Admin.City.CityUserControl cityUserControl1;
        private Admin.Experience.ExperienceUserControl experienceUserControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Admin.Categories.CategoriesUserControl categoriesUserControl1;
        private Admin.SubCategory.SubCategoryUserControl subCategoryUserControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private Admin.Companies2.CompaniesUserControl companiesUserControl1;
    }
}

