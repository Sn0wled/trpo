namespace trpo.scales
{
    partial class ScalesForm
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
            scaleDataGrid = new DataGridView();
            invNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calibrationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxWeightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            errorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            scalesBindingSource = new BindingSource(components);
            addButton = new Button();
            changeButton = new Button();
            delButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scaleDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scalesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(scaleDataGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(addButton, 0, 2);
            tableLayoutPanel1.Controls.Add(changeButton, 1, 2);
            tableLayoutPanel1.Controls.Add(delButton, 2, 2);
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
            tableLayoutPanel1.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(794, 40);
            label1.TabIndex = 0;
            label1.Text = "Весы";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scaleDataGrid
            // 
            scaleDataGrid.AllowUserToAddRows = false;
            scaleDataGrid.AllowUserToDeleteRows = false;
            scaleDataGrid.AutoGenerateColumns = false;
            scaleDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            scaleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scaleDataGrid.Columns.AddRange(new DataGridViewColumn[] { invNumDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, calibrationDateDataGridViewTextBoxColumn, maxWeightDataGridViewTextBoxColumn, errorDataGridViewTextBoxColumn });
            tableLayoutPanel1.SetColumnSpan(scaleDataGrid, 3);
            scaleDataGrid.DataSource = scalesBindingSource;
            scaleDataGrid.Dock = DockStyle.Fill;
            scaleDataGrid.Location = new Point(3, 43);
            scaleDataGrid.MultiSelect = false;
            scaleDataGrid.Name = "scaleDataGrid";
            scaleDataGrid.ReadOnly = true;
            scaleDataGrid.RowHeadersVisible = false;
            scaleDataGrid.RowHeadersWidth = 51;
            scaleDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            scaleDataGrid.Size = new Size(794, 344);
            scaleDataGrid.TabIndex = 1;
            // 
            // invNumDataGridViewTextBoxColumn
            // 
            invNumDataGridViewTextBoxColumn.DataPropertyName = "InvNum";
            invNumDataGridViewTextBoxColumn.FillWeight = 75F;
            invNumDataGridViewTextBoxColumn.HeaderText = "Инв. номер";
            invNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            invNumDataGridViewTextBoxColumn.Name = "invNumDataGridViewTextBoxColumn";
            invNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Модель";
            brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calibrationDateDataGridViewTextBoxColumn
            // 
            calibrationDateDataGridViewTextBoxColumn.DataPropertyName = "CalibrationDate";
            calibrationDateDataGridViewTextBoxColumn.HeaderText = "Дата калибровки";
            calibrationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            calibrationDateDataGridViewTextBoxColumn.Name = "calibrationDateDataGridViewTextBoxColumn";
            calibrationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxWeightDataGridViewTextBoxColumn
            // 
            maxWeightDataGridViewTextBoxColumn.DataPropertyName = "MaxWeight";
            maxWeightDataGridViewTextBoxColumn.HeaderText = "Максимальный вес";
            maxWeightDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxWeightDataGridViewTextBoxColumn.Name = "maxWeightDataGridViewTextBoxColumn";
            maxWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // errorDataGridViewTextBoxColumn
            // 
            errorDataGridViewTextBoxColumn.DataPropertyName = "Error";
            errorDataGridViewTextBoxColumn.FillWeight = 60F;
            errorDataGridViewTextBoxColumn.HeaderText = "Погрешность";
            errorDataGridViewTextBoxColumn.MinimumWidth = 6;
            errorDataGridViewTextBoxColumn.Name = "errorDataGridViewTextBoxColumn";
            errorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scalesBindingSource
            // 
            scalesBindingSource.DataSource = typeof(trpo_test_2.models.Scales);
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Location = new Point(3, 393);
            addButton.Name = "addButton";
            addButton.Size = new Size(260, 54);
            addButton.TabIndex = 2;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // changeButton
            // 
            changeButton.Dock = DockStyle.Fill;
            changeButton.Location = new Point(269, 393);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(260, 54);
            changeButton.TabIndex = 3;
            changeButton.Text = "Изменить";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // delButton
            // 
            delButton.Dock = DockStyle.Fill;
            delButton.Location = new Point(535, 393);
            delButton.Name = "delButton";
            delButton.Size = new Size(262, 54);
            delButton.TabIndex = 4;
            delButton.Text = "Удалить";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // ScalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ScalesForm";
            Text = "ScalesForm";
            Load += ScalesForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scaleDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)scalesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView scaleDataGrid;
        private Button addButton;
        private Button changeButton;
        private Button delButton;
        private BindingSource scalesBindingSource;
        private DataGridViewTextBoxColumn invNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calibrationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxWeightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn errorDataGridViewTextBoxColumn;
    }
}