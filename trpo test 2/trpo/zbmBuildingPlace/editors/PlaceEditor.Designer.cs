namespace trpo.zbmBuildingPlace.editors
{
    partial class PlaceEditor
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
            tableLayoutPanel2 = new TableLayoutPanel();
            cancelButton = new Button();
            saveButton = new Button();
            windowLabel = new Label();
            label2 = new Label();
            pNum = new TextBox();
            label1 = new Label();
            empDataGrid = new DataGridView();
            employeeBindingSource = new BindingSource(components);
            tabNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bDayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iNNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passportSaNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sNILSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 628F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(windowLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(pNum, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(empDataGrid, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 314F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4886665F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.5113335F));
            tableLayoutPanel2.Controls.Add(cancelButton, 0, 0);
            tableLayoutPanel2.Controls.Add(saveButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 403);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(794, 44);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Location = new Point(388, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(403, 38);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Fill;
            saveButton.Location = new Point(3, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(379, 38);
            saveButton.TabIndex = 6;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // windowLabel
            // 
            windowLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(windowLabel, 2);
            windowLabel.Dock = DockStyle.Fill;
            windowLabel.Location = new Point(3, 0);
            windowLabel.Name = "windowLabel";
            windowLabel.Size = new Size(794, 40);
            windowLabel.TabIndex = 0;
            windowLabel.Text = "Добавление помещения";
            windowLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(166, 30);
            label2.TabIndex = 1;
            label2.Text = "Номер помещения";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pNum
            // 
            pNum.Location = new Point(175, 43);
            pNum.MaxLength = 5;
            pNum.Name = "pNum";
            pNum.Size = new Size(622, 27);
            pNum.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 86);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 6;
            label1.Text = "Ответственное лицо";
            // 
            // empDataGrid
            // 
            empDataGrid.AllowUserToAddRows = false;
            empDataGrid.AllowUserToDeleteRows = false;
            empDataGrid.AutoGenerateColumns = false;
            empDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            empDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empDataGrid.Columns.AddRange(new DataGridViewColumn[] { tabNumDataGridViewTextBoxColumn, fNameDataGridViewTextBoxColumn, lNameDataGridViewTextBoxColumn, pNameDataGridViewTextBoxColumn, pNumDataGridViewTextBoxColumn, bDayDataGridViewTextBoxColumn, iNNDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, passportSaNDataGridViewTextBoxColumn, sNILSDataGridViewTextBoxColumn, postIdDataGridViewTextBoxColumn });
            empDataGrid.DataSource = employeeBindingSource;
            empDataGrid.Dock = DockStyle.Fill;
            empDataGrid.Location = new Point(175, 89);
            empDataGrid.MultiSelect = false;
            empDataGrid.Name = "empDataGrid";
            empDataGrid.ReadOnly = true;
            empDataGrid.RowHeadersVisible = false;
            empDataGrid.RowHeadersWidth = 51;
            empDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            empDataGrid.Size = new Size(622, 308);
            empDataGrid.TabIndex = 7;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(trpo_test_2.models.Employee);
            // 
            // tabNumDataGridViewTextBoxColumn
            // 
            tabNumDataGridViewTextBoxColumn.DataPropertyName = "TabNum";
            tabNumDataGridViewTextBoxColumn.HeaderText = "Таб. номер";
            tabNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            tabNumDataGridViewTextBoxColumn.Name = "tabNumDataGridViewTextBoxColumn";
            tabNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            fNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            fNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            lNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            lNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            pNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            pNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            pNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pNumDataGridViewTextBoxColumn
            // 
            pNumDataGridViewTextBoxColumn.DataPropertyName = "PNum";
            pNumDataGridViewTextBoxColumn.HeaderText = "PNum";
            pNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            pNumDataGridViewTextBoxColumn.Name = "pNumDataGridViewTextBoxColumn";
            pNumDataGridViewTextBoxColumn.ReadOnly = true;
            pNumDataGridViewTextBoxColumn.Visible = false;
            // 
            // bDayDataGridViewTextBoxColumn
            // 
            bDayDataGridViewTextBoxColumn.DataPropertyName = "BDay";
            bDayDataGridViewTextBoxColumn.HeaderText = "BDay";
            bDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            bDayDataGridViewTextBoxColumn.Name = "bDayDataGridViewTextBoxColumn";
            bDayDataGridViewTextBoxColumn.ReadOnly = true;
            bDayDataGridViewTextBoxColumn.Visible = false;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            iNNDataGridViewTextBoxColumn.HeaderText = "INN";
            iNNDataGridViewTextBoxColumn.MinimumWidth = 6;
            iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            iNNDataGridViewTextBoxColumn.ReadOnly = true;
            iNNDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // passportSaNDataGridViewTextBoxColumn
            // 
            passportSaNDataGridViewTextBoxColumn.DataPropertyName = "PassportSaN";
            passportSaNDataGridViewTextBoxColumn.HeaderText = "PassportSaN";
            passportSaNDataGridViewTextBoxColumn.MinimumWidth = 6;
            passportSaNDataGridViewTextBoxColumn.Name = "passportSaNDataGridViewTextBoxColumn";
            passportSaNDataGridViewTextBoxColumn.ReadOnly = true;
            passportSaNDataGridViewTextBoxColumn.Visible = false;
            // 
            // sNILSDataGridViewTextBoxColumn
            // 
            sNILSDataGridViewTextBoxColumn.DataPropertyName = "SNILS";
            sNILSDataGridViewTextBoxColumn.HeaderText = "SNILS";
            sNILSDataGridViewTextBoxColumn.MinimumWidth = 6;
            sNILSDataGridViewTextBoxColumn.Name = "sNILSDataGridViewTextBoxColumn";
            sNILSDataGridViewTextBoxColumn.ReadOnly = true;
            sNILSDataGridViewTextBoxColumn.Visible = false;
            // 
            // postIdDataGridViewTextBoxColumn
            // 
            postIdDataGridViewTextBoxColumn.DataPropertyName = "PostId";
            postIdDataGridViewTextBoxColumn.HeaderText = "PostId";
            postIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            postIdDataGridViewTextBoxColumn.Name = "postIdDataGridViewTextBoxColumn";
            postIdDataGridViewTextBoxColumn.ReadOnly = true;
            postIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // PlaceEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "PlaceEditor";
            Text = "PersonEditor";
            Load += PlaceEditor_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)empDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label windowLabel;
        private Label label2;
        private TextBox pNum;
        private TableLayoutPanel tableLayoutPanel2;
        private Button cancelButton;
        private Button saveButton;
        private Label label1;
        private DataGridView empDataGrid;
        private BindingSource employeeBindingSource;
        private DataGridViewTextBoxColumn tabNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bDayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passportSaNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sNILSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postIdDataGridViewTextBoxColumn;
    }
}