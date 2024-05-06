namespace trpoTest.tables
{
    partial class EmployeeTable
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tableName = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            employeeDataGrid = new DataGridView();
            tabNum = new DataGridViewTextBoxColumn();
            lName = new DataGridViewTextBoxColumn();
            fName = new DataGridViewTextBoxColumn();
            pName = new DataGridViewTextBoxColumn();
            phoneNumber = new DataGridViewTextBoxColumn();
            birthDate = new DataGridViewTextBoxColumn();
            inn = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            passportData = new DataGridViewTextBoxColumn();
            snils = new DataGridViewTextBoxColumn();
            post = new DataGridViewTextBoxColumn();
            postId = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableName);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 43);
            panel1.TabIndex = 0;
            // 
            // tableName
            // 
            tableName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableName.Location = new Point(0, 0);
            tableName.Name = "tableName";
            tableName.Size = new Size(910, 43);
            tableName.TabIndex = 0;
            tableName.Text = "Сотрудник";
            tableName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 30);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(144, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(763, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "табельный номер", "фамилия", "имя", "отчество", "номер телефона", "дата рождения", "ИНН", "Адрес", "Паспортные данные", "СНИЛС", "Должность" });
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 23);
            comboBox1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(employeeDataGrid);
            panel3.Location = new Point(0, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 367);
            panel3.TabIndex = 2;
            // 
            // employeeDataGrid
            // 
            employeeDataGrid.AllowUserToAddRows = false;
            employeeDataGrid.AllowUserToDeleteRows = false;
            employeeDataGrid.AllowUserToOrderColumns = true;
            employeeDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            employeeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGrid.Columns.AddRange(new DataGridViewColumn[] { tabNum, lName, fName, pName, phoneNumber, birthDate, inn, address, passportData, snils, post, postId });
            employeeDataGrid.Dock = DockStyle.Fill;
            employeeDataGrid.Location = new Point(0, 0);
            employeeDataGrid.MultiSelect = false;
            employeeDataGrid.Name = "employeeDataGrid";
            employeeDataGrid.ReadOnly = true;
            employeeDataGrid.RowHeadersVisible = false;
            employeeDataGrid.RowTemplate.Height = 25;
            employeeDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeDataGrid.Size = new Size(910, 367);
            employeeDataGrid.TabIndex = 0;
            // 
            // tabNum
            // 
            tabNum.HeaderText = "Табельный номер";
            tabNum.Name = "tabNum";
            tabNum.ReadOnly = true;
            tabNum.Width = 121;
            // 
            // lName
            // 
            lName.HeaderText = "Фамилия";
            lName.Name = "lName";
            lName.ReadOnly = true;
            lName.Width = 83;
            // 
            // fName
            // 
            fName.HeaderText = "Имя";
            fName.Name = "fName";
            fName.ReadOnly = true;
            fName.Width = 56;
            // 
            // pName
            // 
            pName.HeaderText = "Отчество";
            pName.Name = "pName";
            pName.ReadOnly = true;
            pName.Width = 83;
            // 
            // phoneNumber
            // 
            phoneNumber.HeaderText = "Номер телефона";
            phoneNumber.Name = "phoneNumber";
            phoneNumber.ReadOnly = true;
            phoneNumber.Width = 115;
            // 
            // birthDate
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            birthDate.DefaultCellStyle = dataGridViewCellStyle1;
            birthDate.HeaderText = "Дата рождения";
            birthDate.Name = "birthDate";
            birthDate.ReadOnly = true;
            birthDate.Width = 106;
            // 
            // inn
            // 
            inn.HeaderText = "ИНН";
            inn.Name = "inn";
            inn.ReadOnly = true;
            inn.Width = 59;
            // 
            // address
            // 
            address.HeaderText = "Адрес";
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 65;
            // 
            // passportData
            // 
            passportData.HeaderText = "Паспортные данные";
            passportData.Name = "passportData";
            passportData.ReadOnly = true;
            passportData.Width = 133;
            // 
            // snils
            // 
            snils.HeaderText = "СНИЛС";
            snils.Name = "snils";
            snils.ReadOnly = true;
            snils.Width = 74;
            // 
            // post
            // 
            post.HeaderText = "Должность";
            post.Name = "post";
            post.ReadOnly = true;
            post.Width = 94;
            // 
            // postId
            // 
            postId.HeaderText = "ИД должности";
            postId.Name = "postId";
            postId.ReadOnly = true;
            postId.Visible = false;
            postId.Width = 104;
            // 
            // EmployeeTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EmployeeTable";
            Size = new Size(910, 445);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label tableName;
        private Panel panel2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel panel3;
        private DataGridView employeeDataGrid;
        private DataGridViewTextBoxColumn tabNum;
        private DataGridViewTextBoxColumn lName;
        private DataGridViewTextBoxColumn fName;
        private DataGridViewTextBoxColumn pName;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn birthDate;
        private DataGridViewTextBoxColumn inn;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn passportData;
        private DataGridViewTextBoxColumn snils;
        private DataGridViewTextBoxColumn post;
        private DataGridViewTextBoxColumn postId;
    }
}
