namespace trpo
{
    partial class ZbmBuildingPlace
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
            components = new System.ComponentModel.Container();
            placeBindingSource = new BindingSource(components);
            buildingBindingSource = new BindingSource(components);
            zbmBindingSource = new BindingSource(components);
            zbmAddButton = new Button();
            zbmDataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            buildingDataGrid = new DataGridView();
            zbmIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            placeDataGrid = new DataGridView();
            zbmIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            buildingNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empTabNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buildAddButton = new Button();
            placeAddButton = new Button();
            zbmChangeButton = new Button();
            buildChangeButton = new Button();
            placeChangeButton = new Button();
            buildDelButton = new Button();
            placeDelButton = new Button();
            zbmDelButton = new Button();
            panel1 = new Panel();
            zbmSearch = new TextBox();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            buildingSearch = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            placeSearch = new TextBox();
            placeCombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)placeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buildingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zbmBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zbmDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buildingDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)placeDataGrid).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // placeBindingSource
            // 
            placeBindingSource.DataSource = typeof(trpo_test_2.models.Place);
            // 
            // buildingBindingSource
            // 
            buildingBindingSource.DataSource = typeof(trpo_test_2.models.Building);
            // 
            // zbmBindingSource
            // 
            zbmBindingSource.DataSource = typeof(trpo_test_2.models.Zbm);
            // 
            // zbmAddButton
            // 
            zbmAddButton.Dock = DockStyle.Fill;
            zbmAddButton.Location = new Point(3, 333);
            zbmAddButton.Name = "zbmAddButton";
            zbmAddButton.Size = new Size(247, 26);
            zbmAddButton.TabIndex = 9;
            zbmAddButton.Text = "Добавить";
            zbmAddButton.UseVisualStyleBackColor = true;
            zbmAddButton.Click += zbmAddButton_Click;
            // 
            // zbmDataGrid
            // 
            zbmDataGrid.AllowUserToAddRows = false;
            zbmDataGrid.AllowUserToDeleteRows = false;
            zbmDataGrid.AutoGenerateColumns = false;
            zbmDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            zbmDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            zbmDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            zbmDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            zbmDataGrid.DataSource = zbmBindingSource;
            zbmDataGrid.Dock = DockStyle.Fill;
            zbmDataGrid.Location = new Point(3, 53);
            zbmDataGrid.MultiSelect = false;
            zbmDataGrid.Name = "zbmDataGrid";
            zbmDataGrid.ReadOnly = true;
            zbmDataGrid.RowHeadersVisible = false;
            zbmDataGrid.RowHeadersWidth = 51;
            zbmDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            zbmDataGrid.Size = new Size(247, 274);
            zbmDataGrid.TabIndex = 3;
            zbmDataGrid.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Название";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildingDataGrid
            // 
            buildingDataGrid.AllowUserToAddRows = false;
            buildingDataGrid.AllowUserToDeleteRows = false;
            buildingDataGrid.AutoGenerateColumns = false;
            buildingDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            buildingDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            buildingDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            buildingDataGrid.Columns.AddRange(new DataGridViewColumn[] { zbmIdDataGridViewTextBoxColumn1, numberDataGridViewTextBoxColumn1 });
            buildingDataGrid.DataSource = buildingBindingSource;
            buildingDataGrid.Dock = DockStyle.Fill;
            buildingDataGrid.Location = new Point(256, 53);
            buildingDataGrid.MultiSelect = false;
            buildingDataGrid.Name = "buildingDataGrid";
            buildingDataGrid.ReadOnly = true;
            buildingDataGrid.RowHeadersVisible = false;
            buildingDataGrid.RowHeadersWidth = 51;
            buildingDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            buildingDataGrid.Size = new Size(247, 274);
            buildingDataGrid.TabIndex = 6;
            buildingDataGrid.SelectionChanged += buildingDataGrid_SelectionChanged;
            // 
            // zbmIdDataGridViewTextBoxColumn1
            // 
            zbmIdDataGridViewTextBoxColumn1.DataPropertyName = "ZbmId";
            zbmIdDataGridViewTextBoxColumn1.HeaderText = "ZbmId";
            zbmIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            zbmIdDataGridViewTextBoxColumn1.Name = "zbmIdDataGridViewTextBoxColumn1";
            zbmIdDataGridViewTextBoxColumn1.ReadOnly = true;
            zbmIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            numberDataGridViewTextBoxColumn1.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn1.HeaderText = "Номер";
            numberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            numberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // placeDataGrid
            // 
            placeDataGrid.AllowUserToAddRows = false;
            placeDataGrid.AllowUserToDeleteRows = false;
            placeDataGrid.AutoGenerateColumns = false;
            placeDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            placeDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            placeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            placeDataGrid.Columns.AddRange(new DataGridViewColumn[] { zbmIdDataGridViewTextBoxColumn, buildingNumberDataGridViewTextBoxColumn, numberDataGridViewTextBoxColumn, empTabNumDataGridViewTextBoxColumn });
            placeDataGrid.DataSource = placeBindingSource;
            placeDataGrid.Dock = DockStyle.Fill;
            placeDataGrid.Location = new Point(509, 53);
            placeDataGrid.MultiSelect = false;
            placeDataGrid.Name = "placeDataGrid";
            placeDataGrid.ReadOnly = true;
            placeDataGrid.RowHeadersVisible = false;
            placeDataGrid.RowHeadersWidth = 51;
            placeDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            placeDataGrid.Size = new Size(450, 274);
            placeDataGrid.TabIndex = 8;
            placeDataGrid.SelectionChanged += placeDataGrid_SelectionChanged;
            // 
            // zbmIdDataGridViewTextBoxColumn
            // 
            zbmIdDataGridViewTextBoxColumn.DataPropertyName = "ZbmId";
            zbmIdDataGridViewTextBoxColumn.HeaderText = "ZbmId";
            zbmIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            zbmIdDataGridViewTextBoxColumn.Name = "zbmIdDataGridViewTextBoxColumn";
            zbmIdDataGridViewTextBoxColumn.ReadOnly = true;
            zbmIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // buildingNumberDataGridViewTextBoxColumn
            // 
            buildingNumberDataGridViewTextBoxColumn.DataPropertyName = "BuildingNumber";
            buildingNumberDataGridViewTextBoxColumn.HeaderText = "BuildingNumber";
            buildingNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            buildingNumberDataGridViewTextBoxColumn.Name = "buildingNumberDataGridViewTextBoxColumn";
            buildingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            buildingNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.FillWeight = 106.951874F;
            numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            numberDataGridViewTextBoxColumn.ReadOnly = true;
            numberDataGridViewTextBoxColumn.Width = 86;
            // 
            // empTabNumDataGridViewTextBoxColumn
            // 
            empTabNumDataGridViewTextBoxColumn.DataPropertyName = "EmpTabNum";
            empTabNumDataGridViewTextBoxColumn.FillWeight = 93.04813F;
            empTabNumDataGridViewTextBoxColumn.HeaderText = "Табельный номер ответственного сотрудника";
            empTabNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            empTabNumDataGridViewTextBoxColumn.Name = "empTabNumDataGridViewTextBoxColumn";
            empTabNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(509, 0);
            label3.Name = "label3";
            label3.Size = new Size(450, 20);
            label3.TabIndex = 2;
            label3.Text = "Помещение";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(256, 0);
            label2.Name = "label2";
            label2.Size = new Size(247, 20);
            label2.TabIndex = 1;
            label2.Text = "Здание";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 20);
            label1.TabIndex = 0;
            label1.Text = "ЗБМ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buildAddButton
            // 
            buildAddButton.Dock = DockStyle.Fill;
            buildAddButton.Location = new Point(256, 333);
            buildAddButton.Name = "buildAddButton";
            buildAddButton.Size = new Size(247, 26);
            buildAddButton.TabIndex = 10;
            buildAddButton.Text = "Добавить";
            buildAddButton.UseVisualStyleBackColor = true;
            buildAddButton.Click += buildAddButton_Click;
            // 
            // placeAddButton
            // 
            placeAddButton.Dock = DockStyle.Fill;
            placeAddButton.Location = new Point(509, 333);
            placeAddButton.Name = "placeAddButton";
            placeAddButton.Size = new Size(450, 26);
            placeAddButton.TabIndex = 11;
            placeAddButton.Text = "Добавить";
            placeAddButton.UseVisualStyleBackColor = true;
            placeAddButton.Click += placeAddButton_Click;
            // 
            // zbmChangeButton
            // 
            zbmChangeButton.Dock = DockStyle.Fill;
            zbmChangeButton.Location = new Point(3, 365);
            zbmChangeButton.Name = "zbmChangeButton";
            zbmChangeButton.Size = new Size(247, 26);
            zbmChangeButton.TabIndex = 12;
            zbmChangeButton.Text = "Изменить";
            zbmChangeButton.UseVisualStyleBackColor = true;
            zbmChangeButton.Click += zbmChangeButton_Click;
            // 
            // buildChangeButton
            // 
            buildChangeButton.Dock = DockStyle.Fill;
            buildChangeButton.Location = new Point(256, 365);
            buildChangeButton.Name = "buildChangeButton";
            buildChangeButton.Size = new Size(247, 26);
            buildChangeButton.TabIndex = 16;
            buildChangeButton.Text = "Изменить";
            buildChangeButton.UseVisualStyleBackColor = true;
            buildChangeButton.Click += buildChangeButton_Click;
            // 
            // placeChangeButton
            // 
            placeChangeButton.Dock = DockStyle.Fill;
            placeChangeButton.Location = new Point(509, 365);
            placeChangeButton.Name = "placeChangeButton";
            placeChangeButton.Size = new Size(450, 26);
            placeChangeButton.TabIndex = 17;
            placeChangeButton.Text = "Изменить";
            placeChangeButton.UseVisualStyleBackColor = true;
            placeChangeButton.Click += placeChangeButton_Click;
            // 
            // buildDelButton
            // 
            buildDelButton.Dock = DockStyle.Fill;
            buildDelButton.Location = new Point(256, 397);
            buildDelButton.Name = "buildDelButton";
            buildDelButton.Size = new Size(247, 26);
            buildDelButton.TabIndex = 18;
            buildDelButton.Text = "Удалить";
            buildDelButton.UseVisualStyleBackColor = true;
            buildDelButton.Click += buildDelButton_Click;
            // 
            // placeDelButton
            // 
            placeDelButton.Dock = DockStyle.Fill;
            placeDelButton.Location = new Point(509, 397);
            placeDelButton.Name = "placeDelButton";
            placeDelButton.Size = new Size(450, 26);
            placeDelButton.TabIndex = 19;
            placeDelButton.Text = "Удалить";
            placeDelButton.UseVisualStyleBackColor = true;
            placeDelButton.Click += placeDelButton_Click;
            // 
            // zbmDelButton
            // 
            zbmDelButton.Dock = DockStyle.Fill;
            zbmDelButton.Location = new Point(3, 397);
            zbmDelButton.Name = "zbmDelButton";
            zbmDelButton.Size = new Size(247, 26);
            zbmDelButton.TabIndex = 20;
            zbmDelButton.Text = "Удалить";
            zbmDelButton.UseVisualStyleBackColor = true;
            zbmDelButton.Click += zbmDelButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(zbmSearch);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 24);
            panel1.TabIndex = 22;
            // 
            // zbmSearch
            // 
            zbmSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            zbmSearch.Location = new Point(83, -4);
            zbmSearch.Name = "zbmSearch";
            zbmSearch.Size = new Size(164, 27);
            zbmSearch.TabIndex = 1;
            zbmSearch.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Название";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3157883F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.36842F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(zbmDelButton, 0, 5);
            tableLayoutPanel1.Controls.Add(placeDelButton, 2, 5);
            tableLayoutPanel1.Controls.Add(buildDelButton, 1, 5);
            tableLayoutPanel1.Controls.Add(placeChangeButton, 2, 4);
            tableLayoutPanel1.Controls.Add(buildChangeButton, 1, 4);
            tableLayoutPanel1.Controls.Add(zbmChangeButton, 0, 4);
            tableLayoutPanel1.Controls.Add(placeAddButton, 2, 3);
            tableLayoutPanel1.Controls.Add(buildAddButton, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(placeDataGrid, 2, 2);
            tableLayoutPanel1.Controls.Add(buildingDataGrid, 1, 2);
            tableLayoutPanel1.Controls.Add(zbmDataGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(zbmAddButton, 0, 3);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 2, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(962, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buildingSearch);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(256, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 24);
            panel2.TabIndex = 23;
            // 
            // buildingSearch
            // 
            buildingSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buildingSearch.Location = new Point(63, -3);
            buildingSearch.Name = "buildingSearch";
            buildingSearch.Size = new Size(184, 27);
            buildingSearch.TabIndex = 2;
            buildingSearch.TextChanged += buildingSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 1;
            label5.Text = "Номер";
            // 
            // panel3
            // 
            panel3.Controls.Add(placeSearch);
            panel3.Controls.Add(placeCombo);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(509, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 24);
            panel3.TabIndex = 24;
            // 
            // placeSearch
            // 
            placeSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            placeSearch.Location = new Point(158, 0);
            placeSearch.Name = "placeSearch";
            placeSearch.Size = new Size(289, 27);
            placeSearch.TabIndex = 1;
            placeSearch.TextChanged += placeSearch_TextChanged;
            // 
            // placeCombo
            // 
            placeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            placeCombo.FormattingEnabled = true;
            placeCombo.Items.AddRange(new object[] { "Номер", "Таб. номер отв." });
            placeCombo.Location = new Point(1, -1);
            placeCombo.Name = "placeCombo";
            placeCombo.Size = new Size(151, 28);
            placeCombo.TabIndex = 0;
            // 
            // ZbmBuildingPlace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ZbmBuildingPlace";
            Text = "ZbmBuildingPlace";
            Load += ZbmBuildingPlace_Load;
            ((System.ComponentModel.ISupportInitialize)placeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)buildingBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)zbmBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)zbmDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)buildingDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)placeDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource zbmBindingSource;
        private BindingSource buildingBindingSource;
        private BindingSource placeBindingSource;
        private Button zbmAddButton;
        private DataGridView zbmDataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridView buildingDataGrid;
        private DataGridViewTextBoxColumn zbmIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private DataGridView placeDataGrid;
        private DataGridViewTextBoxColumn zbmIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn buildingNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empTabNumDataGridViewTextBoxColumn;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buildAddButton;
        private Button placeAddButton;
        private Button zbmChangeButton;
        private Button buildChangeButton;
        private Button placeChangeButton;
        private Button buildDelButton;
        private Button placeDelButton;
        private Button zbmDelButton;
        private Panel panel1;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox zbmSearch;
        private Panel panel2;
        private TextBox buildingSearch;
        private Label label5;
        private Panel panel3;
        private TextBox placeSearch;
        private ComboBox placeCombo;
    }
}