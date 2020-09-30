namespace BossLeilaProject.Admin.SubCategory
{
    partial class SubCategoryForm
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
            System.Windows.Forms.Label category_NameLabel;
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bossDataSet = new BossLeilaProject.AppCode.Data_Source.BossDataSet();
            this.vwSubCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwSubCategoryTableAdapter = new BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.VwSubCategoryTableAdapter();
            this.tableAdapterManager = new BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.TableAdapterManager();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bossDataSet1 = new BossLeilaProject.AppCode.Data_Source.BossDataSet();
            this.vwCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCategoriesTableAdapter = new BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.VwCategoriesTableAdapter();
            this.vwCategoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.CategoriesTableAdapter();
            this.categoriesTableAdapter1 = new BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.CategoriesTableAdapter();
            category_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // category_NameLabel
            // 
            category_NameLabel.AutoSize = true;
            category_NameLabel.Location = new System.Drawing.Point(10, 60);
            category_NameLabel.Name = "category_NameLabel";
            category_NameLabel.Size = new System.Drawing.Size(83, 13);
            category_NameLabel.TabIndex = 13;
            category_NameLabel.Text = "Category Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 42);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Ləğv et";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(130, 110);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(68, 42);
            this.btnYes.TabIndex = 11;
            this.btnYes.Text = "Təsdiqlə";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vəzifə";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 9;
            // 
            // bossDataSet
            // 
            this.bossDataSet.DataSetName = "BossDataSet";
            this.bossDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwSubCategoryBindingSource
            // 
            this.vwSubCategoryBindingSource.DataMember = "VwSubCategory";
            this.vwSubCategoryBindingSource.DataSource = this.bossDataSet;
            // 
            // vwSubCategoryTableAdapter
            // 
            this.vwSubCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboCategory
            // 
            this.comboCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwSubCategoryBindingSource, "CategoryId", true));
            this.comboCategory.DataSource = this.categoriesBindingSource;
            this.comboCategory.DisplayMember = "Name";
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(8, 76);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(264, 21);
            this.comboCategory.TabIndex = 14;
            this.comboCategory.ValueMember = "Id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.bossDataSet1;
            // 
            // bossDataSet1
            // 
            this.bossDataSet1.DataSetName = "BossDataSet";
            this.bossDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCategoriesBindingSource
            // 
            this.vwCategoriesBindingSource.DataMember = "VwCategories";
            this.vwCategoriesBindingSource.DataSource = this.bossDataSet;
            // 
            // vwCategoriesTableAdapter
            // 
            this.vwCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // vwCategoriesBindingSource1
            // 
            this.vwCategoriesBindingSource1.DataMember = "VwCategories";
            this.vwCategoriesBindingSource1.DataSource = this.bossDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // SubCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 162);
            this.Controls.Add(category_NameLabel);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SubCategoryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubCategoryForm";
            this.Load += new System.EventHandler(this.SubCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSubCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCategoriesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private AppCode.Data_Source.BossDataSet bossDataSet;
        private System.Windows.Forms.BindingSource vwSubCategoryBindingSource;
        private AppCode.Data_Source.BossDataSetTableAdapters.VwSubCategoryTableAdapter vwSubCategoryTableAdapter;
        private AppCode.Data_Source.BossDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.BindingSource vwCategoriesBindingSource;
        private AppCode.Data_Source.BossDataSetTableAdapters.VwCategoriesTableAdapter vwCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource vwCategoriesBindingSource1;
        private AppCode.Data_Source.BossDataSet bossDataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private AppCode.Data_Source.BossDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private AppCode.Data_Source.BossDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
    }
}