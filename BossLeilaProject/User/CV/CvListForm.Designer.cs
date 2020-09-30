namespace BossLeilaProject.User.CV
{
    partial class CvListForm
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
            this.components = new System.ComponentModel.Container();
            this.vwSubCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bossDataSet = new BossLeilaProject.AppCode.Data_Source.BossDataSet();
            this.vwSubCategoryTableAdapter = new BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.VwSubCategoryTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vwCvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCvTableAdapter = new BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.VwCvTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.əlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redaktəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniləToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eduInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillsInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCvBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vwSubCategoryBindingSource
            // 
            this.vwSubCategoryBindingSource.DataMember = "VwSubCategory";
            this.vwSubCategoryBindingSource.DataSource = this.bossDataSet;
            // 
            // bossDataSet
            // 
            this.bossDataSet.DataSetName = "BossDataSet";
            this.bossDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwSubCategoryTableAdapter
            // 
            this.vwSubCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Language,
            this.nameDataGridViewTextBoxColumn,
            this.surNameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.eduInformationDataGridViewTextBoxColumn,
            this.experienceInformationDataGridViewTextBoxColumn,
            this.skillsInformationDataGridViewTextBoxColumn,
            this.additionalInformationDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.finishDateDataGridViewTextBoxColumn,
            this.minSalaryDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.createdUserIdDataGridViewTextBoxColumn,
            this.updatedDateDataGridViewTextBoxColumn,
            this.updatedUserIdDataGridViewTextBoxColumn,
            this.deletedDateDataGridViewTextBoxColumn,
            this.deletedUserIdDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.cityIdDataGridViewTextBoxColumn,
            this.categoriesIdDataGridViewTextBoxColumn,
            this.educationIdDataGridViewTextBoxColumn,
            this.experienceIdDataGridViewTextBoxColumn,
            this.subCategryIdDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.educationDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.subCategoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwCvBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // vwCvBindingSource
            // 
            this.vwCvBindingSource.DataMember = "VwCv";
            this.vwCvBindingSource.DataSource = this.bossDataSet;
            // 
            // vwCvTableAdapter
            // 
            this.vwCvTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.əlavəEtToolStripMenuItem,
            this.silToolStripMenuItem,
            this.redaktəEtToolStripMenuItem,
            this.yeniləToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 92);
            // 
            // əlavəEtToolStripMenuItem
            // 
            this.əlavəEtToolStripMenuItem.Name = "əlavəEtToolStripMenuItem";
            this.əlavəEtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.əlavəEtToolStripMenuItem.Text = "Əlavə et";
            this.əlavəEtToolStripMenuItem.Click += new System.EventHandler(this.əlavəEtToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // redaktəEtToolStripMenuItem
            // 
            this.redaktəEtToolStripMenuItem.Name = "redaktəEtToolStripMenuItem";
            this.redaktəEtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.redaktəEtToolStripMenuItem.Text = "Redaktə et";
            this.redaktəEtToolStripMenuItem.Click += new System.EventHandler(this.redaktəEtToolStripMenuItem_Click);
            // 
            // yeniləToolStripMenuItem
            // 
            this.yeniləToolStripMenuItem.Name = "yeniləToolStripMenuItem";
            this.yeniləToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.yeniləToolStripMenuItem.Text = "Yenilə";
            this.yeniləToolStripMenuItem.Click += new System.EventHandler(this.yeniləToolStripMenuItem_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Language
            // 
            this.Language.DataPropertyName = "Language";
            this.Language.HeaderText = "Dil";
            this.Language.Name = "Language";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "Ata adı";
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Nömrə";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // eduInformationDataGridViewTextBoxColumn
            // 
            this.eduInformationDataGridViewTextBoxColumn.DataPropertyName = "EduInformation";
            this.eduInformationDataGridViewTextBoxColumn.HeaderText = "Təhsil haqda məlumat";
            this.eduInformationDataGridViewTextBoxColumn.Name = "eduInformationDataGridViewTextBoxColumn";
            // 
            // experienceInformationDataGridViewTextBoxColumn
            // 
            this.experienceInformationDataGridViewTextBoxColumn.DataPropertyName = "ExperienceInformation";
            this.experienceInformationDataGridViewTextBoxColumn.HeaderText = "Təcrübə haqda məlumat";
            this.experienceInformationDataGridViewTextBoxColumn.Name = "experienceInformationDataGridViewTextBoxColumn";
            // 
            // skillsInformationDataGridViewTextBoxColumn
            // 
            this.skillsInformationDataGridViewTextBoxColumn.DataPropertyName = "SkillsInformation";
            this.skillsInformationDataGridViewTextBoxColumn.HeaderText = "Bacarıqlar haqda məlumat";
            this.skillsInformationDataGridViewTextBoxColumn.Name = "skillsInformationDataGridViewTextBoxColumn";
            // 
            // additionalInformationDataGridViewTextBoxColumn
            // 
            this.additionalInformationDataGridViewTextBoxColumn.DataPropertyName = "AdditionalInformation";
            this.additionalInformationDataGridViewTextBoxColumn.HeaderText = "Əlavə məlumat";
            this.additionalInformationDataGridViewTextBoxColumn.Name = "additionalInformationDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // finishDateDataGridViewTextBoxColumn
            // 
            this.finishDateDataGridViewTextBoxColumn.DataPropertyName = "FinishDate";
            this.finishDateDataGridViewTextBoxColumn.HeaderText = "FinishDate";
            this.finishDateDataGridViewTextBoxColumn.Name = "finishDateDataGridViewTextBoxColumn";
            this.finishDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // minSalaryDataGridViewTextBoxColumn
            // 
            this.minSalaryDataGridViewTextBoxColumn.DataPropertyName = "MinSalary";
            this.minSalaryDataGridViewTextBoxColumn.HeaderText = "Minimum maaş";
            this.minSalaryDataGridViewTextBoxColumn.Name = "minSalaryDataGridViewTextBoxColumn";
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdUserIdDataGridViewTextBoxColumn
            // 
            this.createdUserIdDataGridViewTextBoxColumn.DataPropertyName = "CreatedUserId";
            this.createdUserIdDataGridViewTextBoxColumn.HeaderText = "CreatedUserId";
            this.createdUserIdDataGridViewTextBoxColumn.Name = "createdUserIdDataGridViewTextBoxColumn";
            this.createdUserIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatedDateDataGridViewTextBoxColumn
            // 
            this.updatedDateDataGridViewTextBoxColumn.DataPropertyName = "UpdatedDate";
            this.updatedDateDataGridViewTextBoxColumn.HeaderText = "UpdatedDate";
            this.updatedDateDataGridViewTextBoxColumn.Name = "updatedDateDataGridViewTextBoxColumn";
            this.updatedDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatedUserIdDataGridViewTextBoxColumn
            // 
            this.updatedUserIdDataGridViewTextBoxColumn.DataPropertyName = "UpdatedUserId";
            this.updatedUserIdDataGridViewTextBoxColumn.HeaderText = "UpdatedUserId";
            this.updatedUserIdDataGridViewTextBoxColumn.Name = "updatedUserIdDataGridViewTextBoxColumn";
            this.updatedUserIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDateDataGridViewTextBoxColumn
            // 
            this.deletedDateDataGridViewTextBoxColumn.DataPropertyName = "DeletedDate";
            this.deletedDateDataGridViewTextBoxColumn.HeaderText = "DeletedDate";
            this.deletedDateDataGridViewTextBoxColumn.Name = "deletedDateDataGridViewTextBoxColumn";
            this.deletedDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedUserIdDataGridViewTextBoxColumn
            // 
            this.deletedUserIdDataGridViewTextBoxColumn.DataPropertyName = "DeletedUserId";
            this.deletedUserIdDataGridViewTextBoxColumn.HeaderText = "DeletedUserId";
            this.deletedUserIdDataGridViewTextBoxColumn.Name = "deletedUserIdDataGridViewTextBoxColumn";
            this.deletedUserIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Cins";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
            this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            this.cityIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoriesIdDataGridViewTextBoxColumn
            // 
            this.categoriesIdDataGridViewTextBoxColumn.DataPropertyName = "CategoriesId";
            this.categoriesIdDataGridViewTextBoxColumn.HeaderText = "CategoriesId";
            this.categoriesIdDataGridViewTextBoxColumn.Name = "categoriesIdDataGridViewTextBoxColumn";
            this.categoriesIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // educationIdDataGridViewTextBoxColumn
            // 
            this.educationIdDataGridViewTextBoxColumn.DataPropertyName = "EducationId";
            this.educationIdDataGridViewTextBoxColumn.HeaderText = "EducationId";
            this.educationIdDataGridViewTextBoxColumn.Name = "educationIdDataGridViewTextBoxColumn";
            this.educationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // experienceIdDataGridViewTextBoxColumn
            // 
            this.experienceIdDataGridViewTextBoxColumn.DataPropertyName = "ExperienceId";
            this.experienceIdDataGridViewTextBoxColumn.HeaderText = "ExperienceId";
            this.experienceIdDataGridViewTextBoxColumn.Name = "experienceIdDataGridViewTextBoxColumn";
            this.experienceIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // subCategryIdDataGridViewTextBoxColumn
            // 
            this.subCategryIdDataGridViewTextBoxColumn.DataPropertyName = "SubCategryId";
            this.subCategryIdDataGridViewTextBoxColumn.HeaderText = "SubCategryId";
            this.subCategryIdDataGridViewTextBoxColumn.Name = "subCategryIdDataGridViewTextBoxColumn";
            this.subCategryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Yaş";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // educationDataGridViewTextBoxColumn
            // 
            this.educationDataGridViewTextBoxColumn.DataPropertyName = "Education";
            this.educationDataGridViewTextBoxColumn.HeaderText = "Təhsil";
            this.educationDataGridViewTextBoxColumn.Name = "educationDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Təcrübə ";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Şəhər";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Kateqoriya";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // subCategoryDataGridViewTextBoxColumn
            // 
            this.subCategoryDataGridViewTextBoxColumn.DataPropertyName = "Sub Category";
            this.subCategoryDataGridViewTextBoxColumn.HeaderText = "Vəzifə";
            this.subCategoryDataGridViewTextBoxColumn.Name = "subCategoryDataGridViewTextBoxColumn";
            // 
            // CvListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Name = "CvListForm";
            this.Text = "CvListForm";
            this.Load += new System.EventHandler(this.CvListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwSubCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCvBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AppCode.Data_Source.BossDataSet bossDataSet;
        private System.Windows.Forms.BindingSource vwSubCategoryBindingSource;
        private AppCode.Data_Source.BossDataSetTableAdapters.VwSubCategoryTableAdapter vwSubCategoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vwCvBindingSource;
        private AppCode.Data_Source.BossDataSetTableAdapters.VwCvTableAdapter vwCvTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem əlavəEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redaktəEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniləToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eduInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillsInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoryDataGridViewTextBoxColumn;
    }
}