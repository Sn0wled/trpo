namespace trpoTest.tables
{
    partial class BuildingTable
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
            label1 = new Label();
            panel2 = new Panel();
            buildingDataGrid = new DataGridView();
            zbmId = new DataGridViewTextBoxColumn();
            buildingNumber = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            searchPropText = new TextBox();
            searchPropName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buildingDataGrid).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(3, 0, 3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 30);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(288, 30);
            label1.TabIndex = 0;
            label1.Text = "Здание";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(buildingDataGrid);
            panel2.Location = new Point(3, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 82);
            panel2.TabIndex = 1;
            // 
            // buildingDataGrid
            // 
            buildingDataGrid.AllowUserToAddRows = false;
            buildingDataGrid.AllowUserToDeleteRows = false;
            buildingDataGrid.AllowUserToOrderColumns = true;
            buildingDataGrid.AllowUserToResizeRows = false;
            buildingDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            buildingDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            buildingDataGrid.Columns.AddRange(new DataGridViewColumn[] { zbmId, buildingNumber });
            buildingDataGrid.Dock = DockStyle.Fill;
            buildingDataGrid.Location = new Point(0, 0);
            buildingDataGrid.MultiSelect = false;
            buildingDataGrid.Name = "buildingDataGrid";
            buildingDataGrid.ReadOnly = true;
            buildingDataGrid.RowHeadersVisible = false;
            buildingDataGrid.RowTemplate.Height = 25;
            buildingDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            buildingDataGrid.Size = new Size(288, 82);
            buildingDataGrid.StandardTab = true;
            buildingDataGrid.TabIndex = 0;
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
            buildingNumber.HeaderText = "Номер";
            buildingNumber.Name = "buildingNumber";
            buildingNumber.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(searchPropText);
            panel3.Controls.Add(searchPropName);
            panel3.Location = new Point(3, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 30);
            panel3.TabIndex = 2;
            // 
            // searchPropText
            // 
            searchPropText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchPropText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchPropText.Location = new Point(69, 2);
            searchPropText.MaxLength = 5;
            searchPropText.Name = "searchPropText";
            searchPropText.Size = new Size(219, 25);
            searchPropText.TabIndex = 1;
            searchPropText.TextChanged += searchPropText_TextChanged;
            // 
            // searchPropName
            // 
            searchPropName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            searchPropName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchPropName.Location = new Point(0, 0);
            searchPropName.Name = "searchPropName";
            searchPropName.Size = new Size(63, 30);
            searchPropName.TabIndex = 0;
            searchPropName.Text = "Номер";
            searchPropName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BuildingTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(294, 160);
            Name = "BuildingTable";
            Size = new Size(294, 160);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buildingDataGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView buildingDataGrid;
        private DataGridViewTextBoxColumn zbmId;
        private DataGridViewTextBoxColumn buildingNumber;
        private Panel panel3;
        private Label searchPropName;
        private TextBox searchPropText;
    }
}
