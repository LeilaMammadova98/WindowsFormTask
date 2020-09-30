namespace BossLeilaProject.Admin.City
{
    partial class CityUserControl
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.elaveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniləToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redakteEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vwCityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bossDataSet = new BossLeilaProject.AppCode.Data_Source.BossDataSet();
            this.vwCityTableAdapter = new BossLeilaProject.AppCode.Data_Source.BossDataSetTableAdapters.VwCityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwCityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet)).BeginInit();
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
            this.dataGridView1.DataSource = this.vwCityBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elaveEtToolStripMenuItem,
            this.silToolStripMenuItem,
            this.yeniləToolStripMenuItem,
            this.redakteEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 92);
            // 
            // elaveEtToolStripMenuItem
            // 
            this.elaveEtToolStripMenuItem.Name = "elaveEtToolStripMenuItem";
            this.elaveEtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.elaveEtToolStripMenuItem.Text = "Elave et";
            this.elaveEtToolStripMenuItem.Click += new System.EventHandler(this.elaveEtToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // yeniləToolStripMenuItem
            // 
            this.yeniləToolStripMenuItem.Name = "yeniləToolStripMenuItem";
            this.yeniləToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.yeniləToolStripMenuItem.Text = "Yenilə";
            this.yeniləToolStripMenuItem.Click += new System.EventHandler(this.yeniləToolStripMenuItem_Click);
            // 
            // redakteEtToolStripMenuItem
            // 
            this.redakteEtToolStripMenuItem.Name = "redakteEtToolStripMenuItem";
            this.redakteEtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.redakteEtToolStripMenuItem.Text = "Redakte et";
            this.redakteEtToolStripMenuItem.Click += new System.EventHandler(this.redakteEtToolStripMenuItem_Click);
            // 
            // vwCityBindingSource
            // 
            this.vwCityBindingSource.DataMember = "VwCity";
            this.vwCityBindingSource.DataSource = this.bossDataSet;
            // 
            // bossDataSet
            // 
            this.bossDataSet.DataSetName = "BossDataSet";
            this.bossDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwCityTableAdapter
            // 
            this.vwCityTableAdapter.ClearBeforeFill = true;
            // 
            // CityUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "CityUserControl";
            this.Size = new System.Drawing.Size(302, 219);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vwCityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwCityBindingSource;
        private AppCode.Data_Source.BossDataSet bossDataSet;
        private AppCode.Data_Source.BossDataSetTableAdapters.VwCityTableAdapter vwCityTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elaveEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniləToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redakteEtToolStripMenuItem;
    }
}
