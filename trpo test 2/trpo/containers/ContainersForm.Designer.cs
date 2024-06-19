namespace trpo.containers
{
    partial class ContainersForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            containersTab = new TabControl();
            cubeContainers = new TabPage();
            cubeDataGrid = new DataGridView();
            invNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            widthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cubeContainerBindingSource = new BindingSource(components);
            cylConteiners = new TabPage();
            cylDataGrid = new DataGridView();
            invNumDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            diameterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cylindricalContainerBindingSource = new BindingSource(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            addButton = new Button();
            changeButton = new Button();
            delButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            containersTab.SuspendLayout();
            cubeContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cubeDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cubeContainerBindingSource).BeginInit();
            cylConteiners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cylDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cylindricalContainerBindingSource).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(containersTab, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(794, 40);
            label1.TabIndex = 0;
            label1.Text = "Контейнеры";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // containersTab
            // 
            containersTab.Controls.Add(cubeContainers);
            containersTab.Controls.Add(cylConteiners);
            containersTab.Dock = DockStyle.Fill;
            containersTab.Location = new Point(3, 43);
            containersTab.Name = "containersTab";
            containersTab.SelectedIndex = 0;
            containersTab.Size = new Size(794, 344);
            containersTab.TabIndex = 1;
            // 
            // cubeContainers
            // 
            cubeContainers.Controls.Add(cubeDataGrid);
            cubeContainers.Location = new Point(4, 29);
            cubeContainers.Name = "cubeContainers";
            cubeContainers.Padding = new Padding(3);
            cubeContainers.Size = new Size(786, 311);
            cubeContainers.TabIndex = 0;
            cubeContainers.Text = "Кубические контейнеры";
            cubeContainers.UseVisualStyleBackColor = true;
            // 
            // cubeDataGrid
            // 
            cubeDataGrid.AllowUserToAddRows = false;
            cubeDataGrid.AllowUserToDeleteRows = false;
            cubeDataGrid.AutoGenerateColumns = false;
            cubeDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cubeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cubeDataGrid.Columns.AddRange(new DataGridViewColumn[] { invNumDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, lengthDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, widthDataGridViewTextBoxColumn });
            cubeDataGrid.DataSource = cubeContainerBindingSource;
            cubeDataGrid.Dock = DockStyle.Fill;
            cubeDataGrid.Location = new Point(3, 3);
            cubeDataGrid.MultiSelect = false;
            cubeDataGrid.Name = "cubeDataGrid";
            cubeDataGrid.ReadOnly = true;
            cubeDataGrid.RowHeadersVisible = false;
            cubeDataGrid.RowHeadersWidth = 51;
            cubeDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cubeDataGrid.Size = new Size(780, 305);
            cubeDataGrid.TabIndex = 0;
            // 
            // invNumDataGridViewTextBoxColumn
            // 
            invNumDataGridViewTextBoxColumn.DataPropertyName = "InvNum";
            invNumDataGridViewTextBoxColumn.HeaderText = "Инв. номер";
            invNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            invNumDataGridViewTextBoxColumn.Name = "invNumDataGridViewTextBoxColumn";
            invNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.HeaderText = "Вес";
            weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            lengthDataGridViewTextBoxColumn.HeaderText = "Длина";
            lengthDataGridViewTextBoxColumn.MinimumWidth = 6;
            lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            lengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Высота";
            heightDataGridViewTextBoxColumn.MinimumWidth = 6;
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            heightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            widthDataGridViewTextBoxColumn.HeaderText = "Ширина";
            widthDataGridViewTextBoxColumn.MinimumWidth = 6;
            widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            widthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cubeContainerBindingSource
            // 
            cubeContainerBindingSource.DataSource = typeof(trpo_test_2.models.CubeContainer);
            cubeContainerBindingSource.CurrentChanged += cubeContainerBindingSource_CurrentChanged;
            // 
            // cylConteiners
            // 
            cylConteiners.Controls.Add(cylDataGrid);
            cylConteiners.Location = new Point(4, 29);
            cylConteiners.Name = "cylConteiners";
            cylConteiners.Padding = new Padding(3);
            cylConteiners.Size = new Size(786, 311);
            cylConteiners.TabIndex = 1;
            cylConteiners.Text = "Цилиндрические контейнеры";
            cylConteiners.UseVisualStyleBackColor = true;
            // 
            // cylDataGrid
            // 
            cylDataGrid.AllowUserToAddRows = false;
            cylDataGrid.AllowUserToDeleteRows = false;
            cylDataGrid.AutoGenerateColumns = false;
            cylDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cylDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cylDataGrid.Columns.AddRange(new DataGridViewColumn[] { invNumDataGridViewTextBoxColumn1, typeDataGridViewTextBoxColumn1, weightDataGridViewTextBoxColumn1, heightDataGridViewTextBoxColumn1, diameterDataGridViewTextBoxColumn });
            cylDataGrid.DataSource = cylindricalContainerBindingSource;
            cylDataGrid.Dock = DockStyle.Fill;
            cylDataGrid.Location = new Point(3, 3);
            cylDataGrid.MultiSelect = false;
            cylDataGrid.Name = "cylDataGrid";
            cylDataGrid.ReadOnly = true;
            cylDataGrid.RowHeadersVisible = false;
            cylDataGrid.RowHeadersWidth = 51;
            cylDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cylDataGrid.Size = new Size(780, 305);
            cylDataGrid.TabIndex = 0;
            // 
            // invNumDataGridViewTextBoxColumn1
            // 
            invNumDataGridViewTextBoxColumn1.DataPropertyName = "InvNum";
            invNumDataGridViewTextBoxColumn1.HeaderText = "Инв. номер";
            invNumDataGridViewTextBoxColumn1.MinimumWidth = 6;
            invNumDataGridViewTextBoxColumn1.Name = "invNumDataGridViewTextBoxColumn1";
            invNumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn1.HeaderText = "Тип";
            typeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            typeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn1
            // 
            weightDataGridViewTextBoxColumn1.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn1.HeaderText = "Вес";
            weightDataGridViewTextBoxColumn1.MinimumWidth = 6;
            weightDataGridViewTextBoxColumn1.Name = "weightDataGridViewTextBoxColumn1";
            weightDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // heightDataGridViewTextBoxColumn1
            // 
            heightDataGridViewTextBoxColumn1.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn1.HeaderText = "Высота";
            heightDataGridViewTextBoxColumn1.MinimumWidth = 6;
            heightDataGridViewTextBoxColumn1.Name = "heightDataGridViewTextBoxColumn1";
            heightDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // diameterDataGridViewTextBoxColumn
            // 
            diameterDataGridViewTextBoxColumn.DataPropertyName = "Diameter";
            diameterDataGridViewTextBoxColumn.HeaderText = "Диаметр";
            diameterDataGridViewTextBoxColumn.MinimumWidth = 6;
            diameterDataGridViewTextBoxColumn.Name = "diameterDataGridViewTextBoxColumn";
            diameterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cylindricalContainerBindingSource
            // 
            cylindricalContainerBindingSource.DataSource = typeof(trpo_test_2.models.CylindricalContainer);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(addButton, 0, 0);
            tableLayoutPanel2.Controls.Add(changeButton, 1, 0);
            tableLayoutPanel2.Controls.Add(delButton, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 393);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 54);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(258, 48);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // changeButton
            // 
            changeButton.Dock = DockStyle.Fill;
            changeButton.Location = new Point(267, 3);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(258, 48);
            changeButton.TabIndex = 1;
            changeButton.Text = "Изменить";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // delButton
            // 
            delButton.Dock = DockStyle.Fill;
            delButton.Location = new Point(531, 3);
            delButton.Name = "delButton";
            delButton.Size = new Size(260, 48);
            delButton.TabIndex = 2;
            delButton.Text = "Удалить";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // ContainersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ContainersForm";
            Text = "ContainersForm";
            Load += ContainersForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            containersTab.ResumeLayout(false);
            cubeContainers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cubeDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cubeContainerBindingSource).EndInit();
            cylConteiners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cylDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cylindricalContainerBindingSource).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TabControl containersTab;
        private TabPage cubeContainers;
        private TabPage cylConteiners;
        private DataGridView cubeDataGrid;
        private DataGridViewTextBoxColumn invNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private BindingSource cubeContainerBindingSource;
        private DataGridView cylDataGrid;
        private DataGridViewTextBoxColumn invNumDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn diameterDataGridViewTextBoxColumn;
        private BindingSource cylindricalContainerBindingSource;
        private TableLayoutPanel tableLayoutPanel2;
        private Button addButton;
        private Button changeButton;
        private Button delButton;
    }
}