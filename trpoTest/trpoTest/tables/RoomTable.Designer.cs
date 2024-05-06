namespace trpoTest.tables
{
    partial class RoomTable
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
            panel1 = new Panel();
            tableName = new Label();
            panel2 = new Panel();
            searchText = new TextBox();
            searchLabel = new Label();
            panel3 = new Panel();
            roomDataGrid = new DataGridView();
            zbmId = new DataGridViewTextBoxColumn();
            buildingNumber = new DataGridViewTextBoxColumn();
            roomNumber = new DataGridViewTextBoxColumn();
            respTabNum = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableName);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 30);
            panel1.TabIndex = 0;
            // 
            // tableName
            // 
            tableName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tableName.Location = new Point(0, 0);
            tableName.Name = "tableName";
            tableName.Size = new Size(288, 30);
            tableName.TabIndex = 0;
            tableName.Text = "Помещение";
            tableName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(searchText);
            panel2.Controls.Add(searchLabel);
            panel2.Location = new Point(3, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 30);
            panel2.TabIndex = 1;
            // 
            // searchText
            // 
            searchText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchText.Location = new Point(73, 2);
            searchText.Name = "searchText";
            searchText.Size = new Size(215, 25);
            searchText.TabIndex = 2;
            searchText.TextChanged += searchText_TextChanged;
            // 
            // searchLabel
            // 
            searchLabel.Anchor = AnchorStyles.Left;
            searchLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchLabel.Location = new Point(0, 0);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(67, 30);
            searchLabel.TabIndex = 0;
            searchLabel.Text = "Номер";
            searchLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(roomDataGrid);
            panel3.Location = new Point(3, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 82);
            panel3.TabIndex = 2;
            // 
            // roomDataGrid
            // 
            roomDataGrid.AllowUserToAddRows = false;
            roomDataGrid.AllowUserToDeleteRows = false;
            roomDataGrid.AllowUserToOrderColumns = true;
            roomDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomDataGrid.Columns.AddRange(new DataGridViewColumn[] { zbmId, buildingNumber, roomNumber, respTabNum });
            roomDataGrid.Dock = DockStyle.Fill;
            roomDataGrid.Location = new Point(0, 0);
            roomDataGrid.MultiSelect = false;
            roomDataGrid.Name = "roomDataGrid";
            roomDataGrid.ReadOnly = true;
            roomDataGrid.RowHeadersVisible = false;
            roomDataGrid.RowTemplate.Height = 25;
            roomDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomDataGrid.Size = new Size(288, 82);
            roomDataGrid.TabIndex = 0;
            // 
            // zbmId
            // 
            zbmId.HeaderText = "zbmId";
            zbmId.Name = "zbmId";
            zbmId.ReadOnly = true;
            zbmId.Visible = false;
            // 
            // buildingNumber
            // 
            buildingNumber.HeaderText = "buildingNumber";
            buildingNumber.Name = "buildingNumber";
            buildingNumber.ReadOnly = true;
            buildingNumber.Visible = false;
            // 
            // roomNumber
            // 
            roomNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            roomNumber.HeaderText = "Номер";
            roomNumber.Name = "roomNumber";
            roomNumber.ReadOnly = true;
            roomNumber.Width = 70;
            // 
            // respTabNum
            // 
            respTabNum.HeaderText = "Таб. номер отв. сотр.";
            respTabNum.Name = "respTabNum";
            respTabNum.ReadOnly = true;
            // 
            // RoomTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(294, 160);
            Name = "RoomTable";
            Size = new Size(294, 160);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roomDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label tableName;
        private Panel panel2;
        private Label searchLabel;
        private TextBox searchText;
        private Panel panel3;
        private DataGridView roomDataGrid;
        private DataGridViewTextBoxColumn zbmId;
        private DataGridViewTextBoxColumn buildingNumber;
        private DataGridViewTextBoxColumn roomNumber;
        private DataGridViewTextBoxColumn respTabNum;
    }
}
