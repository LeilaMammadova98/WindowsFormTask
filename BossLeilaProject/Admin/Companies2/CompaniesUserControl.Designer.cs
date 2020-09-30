namespace BossLeilaProject.Admin.Companies2
{
    partial class CompaniesUserControl
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
            this.bossDataSet = new BossLeilaProject.AppCode.Data_Source.BossDataSet();
            this.vwCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCompaniesTableAdapter = new BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.VwCompaniesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.əlavəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redaktəEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniləToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompaniesBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.vwCompaniesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(150, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bossDataSet
            // 
            this.bossDataSet.DataSetName = "BossDataSet";
            this.bossDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCompaniesBindingSource
            // 
            this.vwCompaniesBindingSource.DataMember = "VwCompanies";
            this.vwCompaniesBindingSource.DataSource = this.bossDataSet;
            // 
            // vwCompaniesTableAdapter
            // 
            this.vwCompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            this.əlavəEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.əlavəEtToolStripMenuItem.Text = "Əlavə et";
            this.əlavəEtToolStripMenuItem.Click += new System.EventHandler(this.əlavəEtToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // redaktəEtToolStripMenuItem
            // 
            this.redaktəEtToolStripMenuItem.Name = "redaktəEtToolStripMenuItem";
            this.redaktəEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redaktəEtToolStripMenuItem.Text = "Redaktə et";
            this.redaktəEtToolStripMenuItem.Click += new System.EventHandler(this.redaktəEtToolStripMenuItem_Click);
            // 
            // yeniləToolStripMenuItem
            // 
            this.yeniləToolStripMenuItem.Name = "yeniləToolStripMenuItem";
            this.yeniləToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniləToolStripMenuItem.Text = "Yenilə";
            this.yeniləToolStripMenuItem.Click += new System.EventHandler(this.yeniləToolStripMenuItem_Click);
            // 
            // CompaniesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "CompaniesUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCompaniesBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwCompaniesBindingSource;
        private AppCode.Data_Source.BossDataSet bossDataSet;
        private AppCode.Data_Source.BossDataSetTableAdapters.VwCompaniesTableAdapter vwCompaniesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem əlavəEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redaktəEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniləToolStripMenuItem;
    }
}
