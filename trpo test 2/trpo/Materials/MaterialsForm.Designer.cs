namespace trpo.Materials
{
    partial class MaterialsForm
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
            matDataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atomicMassDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialBindingSource = new BindingSource(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            delButton = new Button();
            changeButton = new Button();
            addButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)matDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(matDataGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(794, 50);
            label1.TabIndex = 0;
            label1.Text = "Материалы";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // matDataGrid
            // 
            matDataGrid.AllowUserToAddRows = false;
            matDataGrid.AllowUserToDeleteRows = false;
            matDataGrid.AutoGenerateColumns = false;
            matDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            matDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, atomicMassDataGridViewTextBoxColumn });
            matDataGrid.DataSource = materialBindingSource;
            matDataGrid.Dock = DockStyle.Fill;
            matDataGrid.Location = new Point(3, 53);
            matDataGrid.MultiSelect = false;
            matDataGrid.Name = "matDataGrid";
            matDataGrid.RowHeadersVisible = false;
            matDataGrid.RowHeadersWidth = 51;
            matDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            matDataGrid.Size = new Size(794, 345);
            matDataGrid.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // atomicMassDataGridViewTextBoxColumn
            // 
            atomicMassDataGridViewTextBoxColumn.DataPropertyName = "AtomicMass";
            atomicMassDataGridViewTextBoxColumn.HeaderText = "Атомная масса";
            atomicMassDataGridViewTextBoxColumn.MinimumWidth = 6;
            atomicMassDataGridViewTextBoxColumn.Name = "atomicMassDataGridViewTextBoxColumn";
            // 
            // materialBindingSource
            // 
            materialBindingSource.DataSource = typeof(trpo_test_2.models.Material);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(delButton, 2, 0);
            tableLayoutPanel2.Controls.Add(changeButton, 1, 0);
            tableLayoutPanel2.Controls.Add(addButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 404);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 43);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // delButton
            // 
            delButton.Dock = DockStyle.Fill;
            delButton.Location = new Point(531, 3);
            delButton.Name = "delButton";
            delButton.Size = new Size(260, 37);
            delButton.TabIndex = 2;
            delButton.Text = "Удалить";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // changeButton
            // 
            changeButton.Dock = DockStyle.Fill;
            changeButton.Location = new Point(267, 3);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(258, 37);
            changeButton.TabIndex = 1;
            changeButton.Text = "Изменить";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(258, 37);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // MaterialsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MaterialsForm";
            Text = "Materials";
            Load += Materials_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)matDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView matDataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn atomicMassDataGridViewTextBoxColumn;
        private BindingSource materialBindingSource;
        private TableLayoutPanel tableLayoutPanel2;
        private Button delButton;
        private Button changeButton;
        private Button addButton;
    }
}