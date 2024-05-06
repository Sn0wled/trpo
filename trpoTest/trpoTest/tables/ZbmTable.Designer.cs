namespace trpoTest.tables
{
    partial class ZbmTable
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
            zbmDataGrid = new DataGridView();
            zbmId = new DataGridViewTextBoxColumn();
            zbmName = new DataGridViewTextBoxColumn();
            tableName = new Label();
            panel2 = new Panel();
            searchName = new Label();
            searchText = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)zbmDataGrid).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // zbmDataGrid
            // 
            zbmDataGrid.AllowUserToAddRows = false;
            zbmDataGrid.AllowUserToDeleteRows = false;
            zbmDataGrid.AllowUserToResizeRows = false;
            zbmDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            zbmDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            zbmDataGrid.Columns.AddRange(new DataGridViewColumn[] { zbmId, zbmName });
            zbmDataGrid.Dock = DockStyle.Fill;
            zbmDataGrid.Location = new Point(0, 0);
            zbmDataGrid.MultiSelect = false;
            zbmDataGrid.Name = "zbmDataGrid";
            zbmDataGrid.ReadOnly = true;
            zbmDataGrid.RowHeadersVisible = false;
            zbmDataGrid.RowTemplate.Height = 25;
            zbmDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            zbmDataGrid.Size = new Size(288, 82);
            zbmDataGrid.StandardTab = true;
            zbmDataGrid.TabIndex = 3;
            // 
            // zbmId
            // 
            zbmId.Frozen = true;
            zbmId.HeaderText = "ИД";
            zbmId.Name = "zbmId";
            zbmId.ReadOnly = true;
            zbmId.Visible = false;
            // 
            // zbmName
            // 
            zbmName.HeaderText = "Название";
            zbmName.Name = "zbmName";
            zbmName.ReadOnly = true;
            // 
            // tableName
            // 
            tableName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tableName.Location = new Point(0, 0);
            tableName.Margin = new Padding(5);
            tableName.Name = "tableName";
            tableName.Size = new Size(288, 30);
            tableName.TabIndex = 0;
            tableName.Text = "ЗБМ";
            tableName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(searchName);
            panel2.Controls.Add(searchText);
            panel2.Location = new Point(3, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 30);
            panel2.TabIndex = 2;
            // 
            // searchName
            // 
            searchName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchName.Location = new Point(0, 0);
            searchName.Name = "searchName";
            searchName.Size = new Size(85, 30);
            searchName.TabIndex = 5;
            searchName.Text = "Название";
            searchName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchText
            // 
            searchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchText.Location = new Point(91, 2);
            searchText.Name = "searchText";
            searchText.Size = new Size(197, 25);
            searchText.TabIndex = 4;
            searchText.TextChanged += searchText_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableName);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 30);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(zbmDataGrid);
            panel3.Location = new Point(3, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 82);
            panel3.TabIndex = 6;
            // 
            // ZbmTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MinimumSize = new Size(294, 160);
            Name = "ZbmTable";
            Size = new Size(294, 160);
            ((System.ComponentModel.ISupportInitialize)zbmDataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label tableName;
        private Panel panel2;
        private Label searchName;
        private TextBox searchText;
        private DataGridView zbmDataGrid;
        private DataGridViewTextBoxColumn zbmId;
        private DataGridViewTextBoxColumn zbmName;
        private Panel panel1;
        private Panel panel3;
    }
}
