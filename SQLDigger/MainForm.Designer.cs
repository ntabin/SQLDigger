namespace SQLDigger
{
    partial class MainForm
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
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.splitContainer3 = new System.Windows.Forms.SplitContainer();
        	this.dgvTables = new System.Windows.Forms.DataGridView();
        	this.tableNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.tableDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
        	this.label5 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.dgvStoredProcs = new System.Windows.Forms.DataGridView();
        	this.Execute = new System.Windows.Forms.DataGridViewButtonColumn();
        	this.storedProcNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.storedProcDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
        	this.cmbDB = new System.Windows.Forms.ComboBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.label2 = new System.Windows.Forms.Label();
        	this.dgvColumns = new System.Windows.Forms.DataGridView();
        	this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        	this.columnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.dataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.isPrimaryKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        	this.isIdentityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        	this.columnDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
        	this.btnEdit = new System.Windows.Forms.Panel();
        	this.panel4 = new System.Windows.Forms.Panel();
        	this.button3 = new System.Windows.Forms.Button();
        	this.btnCopy = new System.Windows.Forms.Button();
        	this.btnUpdate = new System.Windows.Forms.Button();
        	this.btnAdd = new System.Windows.Forms.Button();
        	this.btnWhere = new System.Windows.Forms.Button();
        	this.dgvResult = new ADGV.AdvancedDataGridView();
        	this.cmsResult = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.MenuStripClone = new System.Windows.Forms.ToolStripMenuItem();
        	this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.bsResult = new System.Windows.Forms.BindingSource(this.components);
        	this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        	this.lblQuery = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.tbRow = new System.Windows.Forms.TextBox();
        	this.picBoxLoading = new System.Windows.Forms.PictureBox();
        	this.lblTable = new System.Windows.Forms.Label();
        	this.btnExec = new System.Windows.Forms.Button();
        	this.tbWhere = new System.Windows.Forms.TextBox();
        	this.bgTableQuery = new System.ComponentModel.BackgroundWorker();
        	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        	this.lblConnection = new System.Windows.Forms.Label();
        	this.splitContainer2 = new System.Windows.Forms.SplitContainer();
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.bwExecStoredProc = new System.ComponentModel.BackgroundWorker();
        	this.panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
        	this.splitContainer3.Panel1.SuspendLayout();
        	this.splitContainer3.Panel2.SuspendLayout();
        	this.splitContainer3.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.tableDetailBindingSource)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.dgvStoredProcs)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.storedProcDetailBindingSource)).BeginInit();
        	this.panel2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.columnDetailBindingSource)).BeginInit();
        	this.btnEdit.SuspendLayout();
        	this.panel4.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
        	this.cmsResult.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
        	this.tableLayoutPanel3.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.picBoxLoading)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        	this.splitContainer1.Panel1.SuspendLayout();
        	this.splitContainer1.Panel2.SuspendLayout();
        	this.splitContainer1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
        	this.splitContainer2.Panel1.SuspendLayout();
        	this.splitContainer2.Panel2.SuspendLayout();
        	this.splitContainer2.SuspendLayout();
        	this.menuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.panel1.Controls.Add(this.splitContainer3);
        	this.panel1.Controls.Add(this.cmbDB);
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(428, 140);
        	this.panel1.TabIndex = 0;
        	// 
        	// splitContainer3
        	// 
        	this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.splitContainer3.Location = new System.Drawing.Point(5, 25);
        	this.splitContainer3.Name = "splitContainer3";
        	// 
        	// splitContainer3.Panel1
        	// 
        	this.splitContainer3.Panel1.Controls.Add(this.dgvTables);
        	this.splitContainer3.Panel1.Controls.Add(this.label5);
        	// 
        	// splitContainer3.Panel2
        	// 
        	this.splitContainer3.Panel2.Controls.Add(this.label3);
        	this.splitContainer3.Panel2.Controls.Add(this.dgvStoredProcs);
        	this.splitContainer3.Size = new System.Drawing.Size(410, 113);
        	this.splitContainer3.SplitterDistance = 179;
        	this.splitContainer3.TabIndex = 3;
        	// 
        	// dgvTables
        	// 
        	this.dgvTables.AllowUserToAddRows = false;
        	this.dgvTables.AllowUserToDeleteRows = false;
        	this.dgvTables.AllowUserToOrderColumns = true;
        	this.dgvTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.dgvTables.AutoGenerateColumns = false;
        	this.dgvTables.BackgroundColor = System.Drawing.Color.White;
        	this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.tableNameDataGridViewTextBoxColumn});
        	this.dgvTables.DataSource = this.tableDetailBindingSource;
        	this.dgvTables.Location = new System.Drawing.Point(3, 16);
        	this.dgvTables.Name = "dgvTables";
        	this.dgvTables.ReadOnly = true;
        	this.dgvTables.RowHeadersVisible = false;
        	this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvTables.Size = new System.Drawing.Size(173, 94);
        	this.dgvTables.TabIndex = 0;
        	this.dgvTables.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTables_DataBindingComplete);
        	this.dgvTables.SelectionChanged += new System.EventHandler(this.dgvTables_SelectionChanged);
        	// 
        	// tableNameDataGridViewTextBoxColumn
        	// 
        	this.tableNameDataGridViewTextBoxColumn.DataPropertyName = "TableName";
        	this.tableNameDataGridViewTextBoxColumn.HeaderText = "TableName";
        	this.tableNameDataGridViewTextBoxColumn.Name = "tableNameDataGridViewTextBoxColumn";
        	this.tableNameDataGridViewTextBoxColumn.ReadOnly = true;
        	// 
        	// tableDetailBindingSource
        	// 
        	this.tableDetailBindingSource.DataSource = typeof(SQLDigger.TableDetail);
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.Location = new System.Drawing.Point(3, 0);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(39, 13);
        	this.label5.TabIndex = 5;
        	this.label5.Text = "Table";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(3, 2);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(99, 13);
        	this.label3.TabIndex = 4;
        	this.label3.Text = "Store Procedure";
        	// 
        	// dgvStoredProcs
        	// 
        	this.dgvStoredProcs.AllowUserToAddRows = false;
        	this.dgvStoredProcs.AllowUserToDeleteRows = false;
        	this.dgvStoredProcs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.dgvStoredProcs.AutoGenerateColumns = false;
        	this.dgvStoredProcs.BackgroundColor = System.Drawing.Color.White;
        	this.dgvStoredProcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgvStoredProcs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Execute,
			this.storedProcNameDataGridViewTextBoxColumn});
        	this.dgvStoredProcs.DataSource = this.storedProcDetailBindingSource;
        	this.dgvStoredProcs.Location = new System.Drawing.Point(3, 18);
        	this.dgvStoredProcs.Name = "dgvStoredProcs";
        	this.dgvStoredProcs.ReadOnly = true;
        	this.dgvStoredProcs.RowHeadersVisible = false;
        	this.dgvStoredProcs.Size = new System.Drawing.Size(221, 90);
        	this.dgvStoredProcs.TabIndex = 3;
        	this.dgvStoredProcs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoredProcs_CellContentClick);
        	this.dgvStoredProcs.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStoredProcs_DataBindingComplete);
        	// 
        	// Execute
        	// 
        	this.Execute.HeaderText = "";
        	this.Execute.Name = "Execute";
        	this.Execute.ReadOnly = true;
        	// 
        	// storedProcNameDataGridViewTextBoxColumn
        	// 
        	this.storedProcNameDataGridViewTextBoxColumn.DataPropertyName = "StoredProcName";
        	this.storedProcNameDataGridViewTextBoxColumn.HeaderText = "StoredProcName";
        	this.storedProcNameDataGridViewTextBoxColumn.Name = "storedProcNameDataGridViewTextBoxColumn";
        	this.storedProcNameDataGridViewTextBoxColumn.ReadOnly = true;
        	// 
        	// storedProcDetailBindingSource
        	// 
        	this.storedProcDetailBindingSource.DataSource = typeof(SQLDigger.StoredProcDetail);
        	// 
        	// cmbDB
        	// 
        	this.cmbDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.cmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbDB.FormattingEnabled = true;
        	this.cmbDB.Location = new System.Drawing.Point(63, 3);
        	this.cmbDB.Name = "cmbDB";
        	this.cmbDB.Size = new System.Drawing.Size(352, 21);
        	this.cmbDB.TabIndex = 2;
        	this.cmbDB.SelectedIndexChanged += new System.EventHandler(this.cmbDB_SelectedIndexChanged);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(4, 4);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(61, 13);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Database";
        	// 
        	// panel2
        	// 
        	this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.panel2.Controls.Add(this.label2);
        	this.panel2.Controls.Add(this.dgvColumns);
        	this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel2.Location = new System.Drawing.Point(0, 0);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(496, 140);
        	this.panel2.TabIndex = 1;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(4, 4);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(54, 13);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Columns";
        	// 
        	// dgvColumns
        	// 
        	this.dgvColumns.AllowUserToAddRows = false;
        	this.dgvColumns.AllowUserToDeleteRows = false;
        	this.dgvColumns.AllowUserToOrderColumns = true;
        	this.dgvColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.dgvColumns.AutoGenerateColumns = false;
        	this.dgvColumns.BackgroundColor = System.Drawing.Color.White;
        	this.dgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgvColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Chk,
			this.columnNameDataGridViewTextBoxColumn,
			this.dataTypeDataGridViewTextBoxColumn,
			this.isPrimaryKeyDataGridViewCheckBoxColumn,
			this.isIdentityDataGridViewCheckBoxColumn});
        	this.dgvColumns.DataSource = this.columnDetailBindingSource;
        	this.dgvColumns.Location = new System.Drawing.Point(3, 25);
        	this.dgvColumns.Name = "dgvColumns";
        	this.dgvColumns.ReadOnly = true;
        	this.dgvColumns.RowHeadersVisible = false;
        	this.dgvColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvColumns.Size = new System.Drawing.Size(486, 108);
        	this.dgvColumns.TabIndex = 0;
        	this.dgvColumns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColumns_CellContentClick);
        	this.dgvColumns.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvColumns_DataBindingComplete);
        	// 
        	// Chk
        	// 
        	this.Chk.HeaderText = "";
        	this.Chk.Name = "Chk";
        	this.Chk.ReadOnly = true;
        	// 
        	// columnNameDataGridViewTextBoxColumn
        	// 
        	this.columnNameDataGridViewTextBoxColumn.DataPropertyName = "ColumnName";
        	this.columnNameDataGridViewTextBoxColumn.HeaderText = "ColumnName";
        	this.columnNameDataGridViewTextBoxColumn.Name = "columnNameDataGridViewTextBoxColumn";
        	this.columnNameDataGridViewTextBoxColumn.ReadOnly = true;
        	// 
        	// dataTypeDataGridViewTextBoxColumn
        	// 
        	this.dataTypeDataGridViewTextBoxColumn.DataPropertyName = "DataType";
        	this.dataTypeDataGridViewTextBoxColumn.HeaderText = "DataType";
        	this.dataTypeDataGridViewTextBoxColumn.Name = "dataTypeDataGridViewTextBoxColumn";
        	this.dataTypeDataGridViewTextBoxColumn.ReadOnly = true;
        	// 
        	// isPrimaryKeyDataGridViewCheckBoxColumn
        	// 
        	this.isPrimaryKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsPrimaryKey";
        	this.isPrimaryKeyDataGridViewCheckBoxColumn.HeaderText = "IsPrimaryKey";
        	this.isPrimaryKeyDataGridViewCheckBoxColumn.Name = "isPrimaryKeyDataGridViewCheckBoxColumn";
        	this.isPrimaryKeyDataGridViewCheckBoxColumn.ReadOnly = true;
        	// 
        	// isIdentityDataGridViewCheckBoxColumn
        	// 
        	this.isIdentityDataGridViewCheckBoxColumn.DataPropertyName = "IsIdentity";
        	this.isIdentityDataGridViewCheckBoxColumn.HeaderText = "IsIdentity";
        	this.isIdentityDataGridViewCheckBoxColumn.Name = "isIdentityDataGridViewCheckBoxColumn";
        	this.isIdentityDataGridViewCheckBoxColumn.ReadOnly = true;
        	// 
        	// columnDetailBindingSource
        	// 
        	this.columnDetailBindingSource.DataSource = typeof(SQLDigger.ColumnDetail);
        	// 
        	// btnEdit
        	// 
        	this.btnEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.btnEdit.Controls.Add(this.panel4);
        	this.btnEdit.Controls.Add(this.btnWhere);
        	this.btnEdit.Controls.Add(this.dgvResult);
        	this.btnEdit.Controls.Add(this.tableLayoutPanel3);
        	this.btnEdit.Controls.Add(this.btnExec);
        	this.btnEdit.Controls.Add(this.tbWhere);
        	this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.btnEdit.Location = new System.Drawing.Point(0, 0);
        	this.btnEdit.Name = "btnEdit";
        	this.btnEdit.Size = new System.Drawing.Size(934, 285);
        	this.btnEdit.TabIndex = 1;
        	// 
        	// panel4
        	// 
        	this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
        	this.panel4.Controls.Add(this.button3);
        	this.panel4.Controls.Add(this.btnCopy);
        	this.panel4.Controls.Add(this.btnUpdate);
        	this.panel4.Controls.Add(this.btnAdd);
        	this.panel4.Location = new System.Drawing.Point(4, 31);
        	this.panel4.Name = "panel4";
        	this.panel4.Size = new System.Drawing.Size(33, 213);
        	this.panel4.TabIndex = 7;
        	// 
        	// button3
        	// 
        	this.button3.Image = global::SQLDigger.Properties.Resources.Export_16px;
        	this.button3.Location = new System.Drawing.Point(4, 78);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(29, 23);
        	this.button3.TabIndex = 3;
        	this.button3.UseVisualStyleBackColor = true;
        	// 
        	// btnCopy
        	// 
        	this.btnCopy.Image = global::SQLDigger.Properties.Resources.Copy_16x;
        	this.btnCopy.Location = new System.Drawing.Point(4, 53);
        	this.btnCopy.Name = "btnCopy";
        	this.btnCopy.Size = new System.Drawing.Size(29, 23);
        	this.btnCopy.TabIndex = 2;
        	this.btnCopy.UseVisualStyleBackColor = true;
        	this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
        	// 
        	// btnUpdate
        	// 
        	this.btnUpdate.Image = global::SQLDigger.Properties.Resources.Pen_16x;
        	this.btnUpdate.Location = new System.Drawing.Point(3, 28);
        	this.btnUpdate.Name = "btnUpdate";
        	this.btnUpdate.Size = new System.Drawing.Size(30, 23);
        	this.btnUpdate.TabIndex = 1;
        	this.btnUpdate.UseVisualStyleBackColor = true;
        	this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
        	// 
        	// btnAdd
        	// 
        	this.btnAdd.Image = global::SQLDigger.Properties.Resources.add_16px;
        	this.btnAdd.Location = new System.Drawing.Point(3, 3);
        	this.btnAdd.Name = "btnAdd";
        	this.btnAdd.Size = new System.Drawing.Size(30, 23);
        	this.btnAdd.TabIndex = 0;
        	this.btnAdd.UseVisualStyleBackColor = true;
        	this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        	// 
        	// btnWhere
        	// 
        	this.btnWhere.Location = new System.Drawing.Point(8, 2);
        	this.btnWhere.Name = "btnWhere";
        	this.btnWhere.Size = new System.Drawing.Size(60, 23);
        	this.btnWhere.TabIndex = 6;
        	this.btnWhere.Text = "Where";
        	this.btnWhere.UseVisualStyleBackColor = true;
        	// 
        	// dgvResult
        	// 
        	this.dgvResult.AllowUserToAddRows = false;
        	this.dgvResult.AllowUserToDeleteRows = false;
        	this.dgvResult.AllowUserToOrderColumns = true;
        	this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.dgvResult.AutoGenerateColumns = false;
        	this.dgvResult.AutoGenerateContextFilters = true;
        	this.dgvResult.BackgroundColor = System.Drawing.Color.White;
        	this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgvResult.ContextMenuStrip = this.cmsResult;
        	this.dgvResult.DataSource = this.bsResult;
        	this.dgvResult.DateWithTime = false;
        	this.dgvResult.Location = new System.Drawing.Point(43, 30);
        	this.dgvResult.Name = "dgvResult";
        	this.dgvResult.ReadOnly = true;
        	this.dgvResult.RowHeadersVisible = false;
        	this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvResult.Size = new System.Drawing.Size(881, 214);
        	this.dgvResult.TabIndex = 5;
        	this.dgvResult.TimeFilter = false;
        	this.dgvResult.SortStringChanged += new System.EventHandler(this.dgvResult_SortStringChanged);
        	this.dgvResult.FilterStringChanged += new System.EventHandler(this.dgvResult_FilterStringChanged);
        	this.dgvResult.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvResult_DataBindingComplete);
        	this.dgvResult.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvResult_DataError);
        	// 
        	// cmsResult
        	// 
        	this.cmsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.MenuStripClone,
			this.updateToolStripMenuItem,
			this.addToolStripMenuItem});
        	this.cmsResult.Name = "cmsResult";
        	this.cmsResult.Size = new System.Drawing.Size(110, 70);
        	// 
        	// MenuStripClone
        	// 
        	this.MenuStripClone.Name = "MenuStripClone";
        	this.MenuStripClone.Size = new System.Drawing.Size(109, 22);
        	this.MenuStripClone.Text = "Clone";
        	this.MenuStripClone.Click += new System.EventHandler(this.MenuStripClone_Click);
        	// 
        	// updateToolStripMenuItem
        	// 
        	this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
        	this.updateToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
        	this.updateToolStripMenuItem.Text = "Update";
        	this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
        	// 
        	// addToolStripMenuItem
        	// 
        	this.addToolStripMenuItem.Name = "addToolStripMenuItem";
        	this.addToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
        	this.addToolStripMenuItem.Text = "Add";
        	this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
        	// 
        	// bsResult
        	// 
        	this.bsResult.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsResult_ListChanged);
        	// 
        	// tableLayoutPanel3
        	// 
        	this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
        	this.tableLayoutPanel3.ColumnCount = 5;
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel3.Controls.Add(this.lblQuery, 1, 0);
        	this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
        	this.tableLayoutPanel3.Controls.Add(this.tbRow, 3, 0);
        	this.tableLayoutPanel3.Controls.Add(this.picBoxLoading, 0, 0);
        	this.tableLayoutPanel3.Controls.Add(this.lblTable, 4, 0);
        	this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 250);
        	this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        	this.tableLayoutPanel3.RowCount = 1;
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel3.Size = new System.Drawing.Size(921, 28);
        	this.tableLayoutPanel3.TabIndex = 4;
        	// 
        	// lblQuery
        	// 
        	this.lblQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
        	this.lblQuery.AutoSize = true;
        	this.lblQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblQuery.Location = new System.Drawing.Point(51, 7);
        	this.lblQuery.Name = "lblQuery";
        	this.lblQuery.Size = new System.Drawing.Size(53, 13);
        	this.lblQuery.TabIndex = 4;
        	this.lblQuery.Text = "lblQuery";
        	// 
        	// label4
        	// 
        	this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(113, 7);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(38, 13);
        	this.label4.TabIndex = 5;
        	this.label4.Text = "Rows";
        	// 
        	// tbRow
        	// 
        	this.tbRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
        	this.tbRow.BackColor = System.Drawing.SystemColors.InactiveBorder;
        	this.tbRow.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.tbRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.tbRow.Location = new System.Drawing.Point(160, 7);
        	this.tbRow.Name = "tbRow";
        	this.tbRow.Size = new System.Drawing.Size(694, 13);
        	this.tbRow.TabIndex = 6;
        	this.tbRow.Text = "0";
        	// 
        	// picBoxLoading
        	// 
        	this.picBoxLoading.Anchor = System.Windows.Forms.AnchorStyles.Left;
        	this.picBoxLoading.Image = global::SQLDigger.Properties.Resources.tenor;
        	this.picBoxLoading.Location = new System.Drawing.Point(6, 6);
        	this.picBoxLoading.Name = "picBoxLoading";
        	this.picBoxLoading.Size = new System.Drawing.Size(36, 16);
        	this.picBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.picBoxLoading.TabIndex = 7;
        	this.picBoxLoading.TabStop = false;
        	// 
        	// lblTable
        	// 
        	this.lblTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
        	this.lblTable.AutoSize = true;
        	this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblTable.Location = new System.Drawing.Point(863, 7);
        	this.lblTable.Name = "lblTable";
        	this.lblTable.Size = new System.Drawing.Size(52, 13);
        	this.lblTable.TabIndex = 8;
        	this.lblTable.Text = "lblTable";
        	// 
        	// btnExec
        	// 
        	this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnExec.Location = new System.Drawing.Point(885, 3);
        	this.btnExec.Name = "btnExec";
        	this.btnExec.Size = new System.Drawing.Size(39, 23);
        	this.btnExec.TabIndex = 3;
        	this.btnExec.Text = "Exec";
        	this.btnExec.UseVisualStyleBackColor = true;
        	this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
        	// 
        	// tbWhere
        	// 
        	this.tbWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.tbWhere.Location = new System.Drawing.Point(76, 4);
        	this.tbWhere.Name = "tbWhere";
        	this.tbWhere.Size = new System.Drawing.Size(803, 20);
        	this.tbWhere.TabIndex = 1;
        	// 
        	// bgTableQuery
        	// 
        	this.bgTableQuery.WorkerSupportsCancellation = true;
        	this.bgTableQuery.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgTableQuery_DoWork);
        	this.bgTableQuery.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgTableQuery_RunWorkerCompleted);
        	// 
        	// splitContainer1
        	// 
        	this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.splitContainer1.Location = new System.Drawing.Point(12, 27);
        	this.splitContainer1.Name = "splitContainer1";
        	this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
        	// 
        	// splitContainer1.Panel1
        	// 
        	this.splitContainer1.Panel1.Controls.Add(this.lblConnection);
        	this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
        	// 
        	// splitContainer1.Panel2
        	// 
        	this.splitContainer1.Panel2.Controls.Add(this.btnEdit);
        	this.splitContainer1.Size = new System.Drawing.Size(938, 453);
        	this.splitContainer1.SplitterDistance = 160;
        	this.splitContainer1.TabIndex = 1;
        	// 
        	// lblConnection
        	// 
        	this.lblConnection.AutoSize = true;
        	this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblConnection.ForeColor = System.Drawing.SystemColors.ActiveCaption;
        	this.lblConnection.Location = new System.Drawing.Point(0, 0);
        	this.lblConnection.Name = "lblConnection";
        	this.lblConnection.Size = new System.Drawing.Size(91, 13);
        	this.lblConnection.TabIndex = 3;
        	this.lblConnection.Text = "No Connection";
        	// 
        	// splitContainer2
        	// 
        	this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.splitContainer2.Location = new System.Drawing.Point(3, 13);
        	this.splitContainer2.Name = "splitContainer2";
        	// 
        	// splitContainer2.Panel1
        	// 
        	this.splitContainer2.Panel1.Controls.Add(this.panel1);
        	// 
        	// splitContainer2.Panel2
        	// 
        	this.splitContainer2.Panel2.Controls.Add(this.panel2);
        	this.splitContainer2.Size = new System.Drawing.Size(928, 140);
        	this.splitContainer2.SplitterDistance = 428;
        	this.splitContainer2.TabIndex = 2;
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.connectionToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(962, 24);
        	this.menuStrip1.TabIndex = 2;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// connectionToolStripMenuItem
        	// 
        	this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.sQLServerToolStripMenuItem});
        	this.connectionToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
        	this.connectionToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
        	this.connectionToolStripMenuItem.Text = "Connect";
        	// 
        	// sQLServerToolStripMenuItem
        	// 
        	this.sQLServerToolStripMenuItem.Name = "sQLServerToolStripMenuItem";
        	this.sQLServerToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
        	this.sQLServerToolStripMenuItem.Text = "SQL Server";
        	this.sQLServerToolStripMenuItem.Click += new System.EventHandler(this.sQLServerToolStripMenuItem_Click);
        	// 
        	// bwExecStoredProc
        	// 
        	this.bwExecStoredProc.WorkerSupportsCancellation = true;
        	this.bwExecStoredProc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwExecStoredProc_DoWork);
        	this.bwExecStoredProc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwExecStoredProc_RunWorkerCompleted);
        	// 
        	// MainForm
        	// 
        	this.AcceptButton = this.btnExec;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(962, 492);
        	this.Controls.Add(this.menuStrip1);
        	this.Controls.Add(this.splitContainer1);
        	this.KeyPreview = true;
        	this.MainMenuStrip = this.menuStrip1;
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "No Connection";
        	this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        	this.Load += new System.EventHandler(this.MainForm_Load);
        	this.Shown += new System.EventHandler(this.MainForm_Shown);
        	this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.splitContainer3.Panel1.ResumeLayout(false);
        	this.splitContainer3.Panel1.PerformLayout();
        	this.splitContainer3.Panel2.ResumeLayout(false);
        	this.splitContainer3.Panel2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
        	this.splitContainer3.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.tableDetailBindingSource)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.dgvStoredProcs)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.storedProcDetailBindingSource)).EndInit();
        	this.panel2.ResumeLayout(false);
        	this.panel2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.columnDetailBindingSource)).EndInit();
        	this.btnEdit.ResumeLayout(false);
        	this.btnEdit.PerformLayout();
        	this.panel4.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
        	this.cmsResult.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
        	this.tableLayoutPanel3.ResumeLayout(false);
        	this.tableLayoutPanel3.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.picBoxLoading)).EndInit();
        	this.splitContainer1.Panel1.ResumeLayout(false);
        	this.splitContainer1.Panel1.PerformLayout();
        	this.splitContainer1.Panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        	this.splitContainer1.ResumeLayout(false);
        	this.splitContainer2.Panel1.ResumeLayout(false);
        	this.splitContainer2.Panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
        	this.splitContainer2.ResumeLayout(false);
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel btnEdit;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.TextBox tbWhere;
        private System.Windows.Forms.Label lblQuery;
        private System.ComponentModel.BackgroundWorker bgTableQuery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRow;
        private System.Windows.Forms.PictureBox picBoxLoading;
        private ADGV.AdvancedDataGridView dgvResult;
        private System.Windows.Forms.BindingSource bsResult;
        private System.Windows.Forms.ContextMenuStrip cmsResult;
        private System.Windows.Forms.ToolStripMenuItem MenuStripClone;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLServerToolStripMenuItem;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.DataGridView dgvStoredProcs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewButtonColumn Execute;
        private System.Windows.Forms.BindingSource columnDetailBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPrimaryKeyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isIdentityDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableDetailBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn storedProcNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource storedProcDetailBindingSource;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bwExecStoredProc;
    }
}

