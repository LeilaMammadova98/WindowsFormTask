namespace BossLeilaProject.Admin.Experience
{
    partial class ExperienceUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwExperienceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bossDataSet = new BossLeilaProject.AppCode.Data_Source.BossDataSet();
            this.vwExperienceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwExperienceTableAdapter = new BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.VwExperienceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwExperienceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwExperienceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwExperienceBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // vwExperienceBindingSource1
            // 
            this.vwExperienceBindingSource1.DataMember = "VwExperience";
            this.vwExperienceBindingSource1.DataSource = this.bossDataSet;
            // 
            // bossDataSet
            // 
            this.bossDataSet.DataSetName = "BossDataSet";
            this.bossDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwExperienceBindingSource
            // 
            this.vwExperienceBindingSource.DataMember = "VwExperience";
            this.vwExperienceBindingSource.DataSource = this.bossDataSet;
            // 
            // vwExperienceTableAdapter
            // 
            this.vwExperienceTableAdapter.ClearBeforeFill = true;
            // 
            // ExperienceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExperienceUserControl";
            this.Size = new System.Drawing.Size(378, 278);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwExperienceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwExperienceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwExperienceBindingSource;
        private AppCode.Data_Source.BossDataSet bossDataSet;
        private AppCode.Data_Source.BossDataSetTableAdapters.VwExperienceTableAdapter vwExperienceTableAdapter;
        private System.Windows.Forms.BindingSource vwExperienceBindingSource1;
    }
}
