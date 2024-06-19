namespace trpo.empl
{
    partial class EmployeeForm
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
            dataGridView1 = new DataGridView();
            tabNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bDayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iNNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passportSaNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sNILSDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            label2 = new Label();
            empDataGrid = new DataGridView();
            tabNumDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            postNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pNumDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            passportSaNDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            iNNDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            sNILSDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bDayDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            postIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            scalesBindingSource = new BindingSource(components);
            addButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            changeButton = new Button();
            delButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            searchParam = new ComboBox();
            searchTB = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scalesBindingSource).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(1073, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1067, 40);
            label1.TabIndex = 0;
            label1.Text = "Сотрудники";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tabNumDataGridViewTextBoxColumn, lNameDataGridViewTextBoxColumn, fNameDataGridViewTextBoxColumn, pNameDataGridViewTextBoxColumn, pNumDataGridViewTextBoxColumn, bDayDataGridViewTextBoxColumn, iNNDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, passportSaNDataGridViewTextBoxColumn, sNILSDataGridViewTextBoxColumn, postIdDataGridViewTextBoxColumn, postNameDataGridViewTextBoxColumn });
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 3);
            dataGridView1.DataSource = employeeBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 43);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1067, 344);
            dataGridView1.TabIndex = 1;
            // 
            // tabNumDataGridViewTextBoxColumn
            // 
            tabNumDataGridViewTextBoxColumn.DataPropertyName = "TabNum";
            tabNumDataGridViewTextBoxColumn.HeaderText = "Таб. номер";
            tabNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            tabNumDataGridViewTextBoxColumn.Name = "tabNumDataGridViewTextBoxColumn";
            tabNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            lNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            lNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            fNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            fNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            fNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            pNumDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            pNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            pNumDataGridViewTextBoxColumn.Name = "pNumDataGridViewTextBoxColumn";
            pNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDayDataGridViewTextBoxColumn
            // 
            bDayDataGridViewTextBoxColumn.DataPropertyName = "BDay";
            bDayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            bDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            bDayDataGridViewTextBoxColumn.Name = "bDayDataGridViewTextBoxColumn";
            bDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            iNNDataGridViewTextBoxColumn.HeaderText = "ИНН";
            iNNDataGridViewTextBoxColumn.MinimumWidth = 6;
            iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            iNNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passportSaNDataGridViewTextBoxColumn
            // 
            passportSaNDataGridViewTextBoxColumn.DataPropertyName = "PassportSaN";
            passportSaNDataGridViewTextBoxColumn.HeaderText = "Серия и номер паспорта";
            passportSaNDataGridViewTextBoxColumn.MinimumWidth = 6;
            passportSaNDataGridViewTextBoxColumn.Name = "passportSaNDataGridViewTextBoxColumn";
            passportSaNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sNILSDataGridViewTextBoxColumn
            // 
            sNILSDataGridViewTextBoxColumn.DataPropertyName = "SNILS";
            sNILSDataGridViewTextBoxColumn.HeaderText = "СНИЛС";
            sNILSDataGridViewTextBoxColumn.MinimumWidth = 6;
            sNILSDataGridViewTextBoxColumn.Name = "sNILSDataGridViewTextBoxColumn";
            sNILSDataGridViewTextBoxColumn.ReadOnly = true;
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
            // postNameDataGridViewTextBoxColumn
            // 
            postNameDataGridViewTextBoxColumn.DataPropertyName = "PostName";
            postNameDataGridViewTextBoxColumn.HeaderText = "Должность";
            postNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            postNameDataGridViewTextBoxColumn.Name = "postNameDataGridViewTextBoxColumn";
            postNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(trpo_test_2.models.Employee);
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label2, 3);
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(1067, 40);
            label2.TabIndex = 0;
            label2.Text = "Сотрудники";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // empDataGrid
            // 
            empDataGrid.AllowUserToAddRows = false;
            empDataGrid.AllowUserToDeleteRows = false;
            empDataGrid.AutoGenerateColumns = false;
            empDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            empDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empDataGrid.Columns.AddRange(new DataGridViewColumn[] { tabNumDataGridViewTextBoxColumn1, lNameDataGridViewTextBoxColumn1, fNameDataGridViewTextBoxColumn1, pNameDataGridViewTextBoxColumn1, postNameDataGridViewTextBoxColumn1, pNumDataGridViewTextBoxColumn1, passportSaNDataGridViewTextBoxColumn1, iNNDataGridViewTextBoxColumn1, sNILSDataGridViewTextBoxColumn1, bDayDataGridViewTextBoxColumn1, addressDataGridViewTextBoxColumn1, postIdDataGridViewTextBoxColumn1 });
            tableLayoutPanel2.SetColumnSpan(empDataGrid, 3);
            empDataGrid.DataSource = employeeBindingSource;
            empDataGrid.Dock = DockStyle.Fill;
            empDataGrid.Location = new Point(3, 83);
            empDataGrid.MultiSelect = false;
            empDataGrid.Name = "empDataGrid";
            empDataGrid.ReadOnly = true;
            empDataGrid.RowHeadersVisible = false;
            empDataGrid.RowHeadersWidth = 51;
            empDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            empDataGrid.Size = new Size(1067, 304);
            empDataGrid.TabIndex = 1;
            // 
            // tabNumDataGridViewTextBoxColumn1
            // 
            tabNumDataGridViewTextBoxColumn1.DataPropertyName = "TabNum";
            tabNumDataGridViewTextBoxColumn1.HeaderText = "Таб. номер";
            tabNumDataGridViewTextBoxColumn1.MinimumWidth = 6;
            tabNumDataGridViewTextBoxColumn1.Name = "tabNumDataGridViewTextBoxColumn1";
            tabNumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn1
            // 
            lNameDataGridViewTextBoxColumn1.DataPropertyName = "LName";
            lNameDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            lNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            lNameDataGridViewTextBoxColumn1.Name = "lNameDataGridViewTextBoxColumn1";
            lNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn1
            // 
            fNameDataGridViewTextBoxColumn1.DataPropertyName = "FName";
            fNameDataGridViewTextBoxColumn1.HeaderText = "Имя";
            fNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            fNameDataGridViewTextBoxColumn1.Name = "fNameDataGridViewTextBoxColumn1";
            fNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pNameDataGridViewTextBoxColumn1
            // 
            pNameDataGridViewTextBoxColumn1.DataPropertyName = "PName";
            pNameDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            pNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            pNameDataGridViewTextBoxColumn1.Name = "pNameDataGridViewTextBoxColumn1";
            pNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // postNameDataGridViewTextBoxColumn1
            // 
            postNameDataGridViewTextBoxColumn1.DataPropertyName = "PostName";
            postNameDataGridViewTextBoxColumn1.HeaderText = "Должность";
            postNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            postNameDataGridViewTextBoxColumn1.Name = "postNameDataGridViewTextBoxColumn1";
            postNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pNumDataGridViewTextBoxColumn1
            // 
            pNumDataGridViewTextBoxColumn1.DataPropertyName = "PNum";
            pNumDataGridViewTextBoxColumn1.HeaderText = "Номер телефона";
            pNumDataGridViewTextBoxColumn1.MinimumWidth = 6;
            pNumDataGridViewTextBoxColumn1.Name = "pNumDataGridViewTextBoxColumn1";
            pNumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // passportSaNDataGridViewTextBoxColumn1
            // 
            passportSaNDataGridViewTextBoxColumn1.DataPropertyName = "PassportSaN";
            passportSaNDataGridViewTextBoxColumn1.HeaderText = "Паспортные данные";
            passportSaNDataGridViewTextBoxColumn1.MinimumWidth = 6;
            passportSaNDataGridViewTextBoxColumn1.Name = "passportSaNDataGridViewTextBoxColumn1";
            passportSaNDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iNNDataGridViewTextBoxColumn1
            // 
            iNNDataGridViewTextBoxColumn1.DataPropertyName = "INN";
            iNNDataGridViewTextBoxColumn1.HeaderText = "ИНН";
            iNNDataGridViewTextBoxColumn1.MinimumWidth = 6;
            iNNDataGridViewTextBoxColumn1.Name = "iNNDataGridViewTextBoxColumn1";
            iNNDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sNILSDataGridViewTextBoxColumn1
            // 
            sNILSDataGridViewTextBoxColumn1.DataPropertyName = "SNILS";
            sNILSDataGridViewTextBoxColumn1.HeaderText = "СНИЛС";
            sNILSDataGridViewTextBoxColumn1.MinimumWidth = 6;
            sNILSDataGridViewTextBoxColumn1.Name = "sNILSDataGridViewTextBoxColumn1";
            sNILSDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bDayDataGridViewTextBoxColumn1
            // 
            bDayDataGridViewTextBoxColumn1.DataPropertyName = "BDay";
            bDayDataGridViewTextBoxColumn1.HeaderText = "Дата рождения";
            bDayDataGridViewTextBoxColumn1.MinimumWidth = 6;
            bDayDataGridViewTextBoxColumn1.Name = "bDayDataGridViewTextBoxColumn1";
            bDayDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn1.HeaderText = "Адрес";
            addressDataGridViewTextBoxColumn1.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            addressDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // postIdDataGridViewTextBoxColumn1
            // 
            postIdDataGridViewTextBoxColumn1.DataPropertyName = "PostId";
            postIdDataGridViewTextBoxColumn1.HeaderText = "PostId";
            postIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            postIdDataGridViewTextBoxColumn1.Name = "postIdDataGridViewTextBoxColumn1";
            postIdDataGridViewTextBoxColumn1.ReadOnly = true;
            postIdDataGridViewTextBoxColumn1.Visible = false;
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
            addButton.Size = new Size(351, 54);
            addButton.TabIndex = 2;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(empDataGrid, 0, 2);
            tableLayoutPanel2.Controls.Add(addButton, 0, 3);
            tableLayoutPanel2.Controls.Add(changeButton, 1, 3);
            tableLayoutPanel2.Controls.Add(delButton, 2, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(1073, 450);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // changeButton
            // 
            changeButton.Dock = DockStyle.Fill;
            changeButton.Location = new Point(360, 393);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(351, 54);
            changeButton.TabIndex = 3;
            changeButton.Text = "Изменить";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // delButton
            // 
            delButton.Dock = DockStyle.Fill;
            delButton.Location = new Point(717, 393);
            delButton.Name = "delButton";
            delButton.Size = new Size(353, 54);
            delButton.TabIndex = 4;
            delButton.Text = "Удалить";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 3);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 312F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(searchParam, 0, 0);
            tableLayoutPanel3.Controls.Add(searchTB, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 43);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1067, 34);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // searchParam
            // 
            searchParam.Dock = DockStyle.Fill;
            searchParam.DropDownStyle = ComboBoxStyle.DropDownList;
            searchParam.FormattingEnabled = true;
            searchParam.Items.AddRange(new object[] { "Таб. номер", "Фамилия", "Имя", "Отчество", "Должность", "Номер телефона", "Серия и номер паспорта", "ИНН", "СНИЛС" });
            searchParam.Location = new Point(3, 3);
            searchParam.Name = "searchParam";
            searchParam.Size = new Size(199, 28);
            searchParam.TabIndex = 0;
            // 
            // searchTB
            // 
            searchTB.Dock = DockStyle.Fill;
            searchTB.Location = new Point(208, 3);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(306, 27);
            searchTB.TabIndex = 1;
            searchTB.TextChanged += textBox1_TextChanged;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)empDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)scalesBindingSource).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tabNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bDayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passportSaNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sNILSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postNameDataGridViewTextBoxColumn;
        private BindingSource employeeBindingSource;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView empDataGrid;
        private BindingSource scalesBindingSource;
        private Button addButton;
        private Button changeButton;
        private Button delButton;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox searchParam;
        private TextBox searchTB;
        private DataGridViewTextBoxColumn tabNumDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn postNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pNumDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn passportSaNDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sNILSDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bDayDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn postIdDataGridViewTextBoxColumn1;
    }
}