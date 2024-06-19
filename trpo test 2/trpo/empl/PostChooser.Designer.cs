namespace trpo.empl
{
    partial class PostChooser
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
            postDataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mCHIDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            mSUEDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            mAUEDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            mWUEDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            postBindingSource = new BindingSource(components);
            label2 = new Label();
            searchTB = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            chooseButton = new Button();
            cancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)postDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)postBindingSource).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 447F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(postDataGrid, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(searchTB, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
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
            label1.Size = new Size(794, 37);
            label1.TabIndex = 0;
            label1.Text = "Должности";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // postDataGrid
            // 
            postDataGrid.AllowUserToAddRows = false;
            postDataGrid.AllowUserToDeleteRows = false;
            postDataGrid.AutoGenerateColumns = false;
            postDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            postDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            postDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, mCHIDataGridViewCheckBoxColumn, mSUEDataGridViewCheckBoxColumn, mAUEDataGridViewCheckBoxColumn, mWUEDataGridViewCheckBoxColumn });
            tableLayoutPanel1.SetColumnSpan(postDataGrid, 3);
            postDataGrid.DataSource = postBindingSource;
            postDataGrid.Dock = DockStyle.Fill;
            postDataGrid.Location = new Point(3, 72);
            postDataGrid.MultiSelect = false;
            postDataGrid.Name = "postDataGrid";
            postDataGrid.ReadOnly = true;
            postDataGrid.RowHeadersVisible = false;
            postDataGrid.RowHeadersWidth = 51;
            postDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            postDataGrid.Size = new Size(794, 329);
            postDataGrid.TabIndex = 1;
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
            // mCHIDataGridViewCheckBoxColumn
            // 
            mCHIDataGridViewCheckBoxColumn.DataPropertyName = "MCHI";
            mCHIDataGridViewCheckBoxColumn.HeaderText = "Может изменять справочную информацию";
            mCHIDataGridViewCheckBoxColumn.MinimumWidth = 6;
            mCHIDataGridViewCheckBoxColumn.Name = "mCHIDataGridViewCheckBoxColumn";
            mCHIDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // mSUEDataGridViewCheckBoxColumn
            // 
            mSUEDataGridViewCheckBoxColumn.DataPropertyName = "MSUE";
            mSUEDataGridViewCheckBoxColumn.HeaderText = "Может отправлять УЕ";
            mSUEDataGridViewCheckBoxColumn.MinimumWidth = 6;
            mSUEDataGridViewCheckBoxColumn.Name = "mSUEDataGridViewCheckBoxColumn";
            mSUEDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // mAUEDataGridViewCheckBoxColumn
            // 
            mAUEDataGridViewCheckBoxColumn.DataPropertyName = "MAUE";
            mAUEDataGridViewCheckBoxColumn.HeaderText = "Может принимать УЕ";
            mAUEDataGridViewCheckBoxColumn.MinimumWidth = 6;
            mAUEDataGridViewCheckBoxColumn.Name = "mAUEDataGridViewCheckBoxColumn";
            mAUEDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // mWUEDataGridViewCheckBoxColumn
            // 
            mWUEDataGridViewCheckBoxColumn.DataPropertyName = "MWUE";
            mWUEDataGridViewCheckBoxColumn.HeaderText = "Может взвешивать УЕ";
            mWUEDataGridViewCheckBoxColumn.MinimumWidth = 6;
            mWUEDataGridViewCheckBoxColumn.Name = "mWUEDataGridViewCheckBoxColumn";
            mWUEDataGridViewCheckBoxColumn.ReadOnly = true;
            mWUEDataGridViewCheckBoxColumn.Visible = false;
            // 
            // postBindingSource
            // 
            postBindingSource.DataSource = typeof(trpo_test_2.models.Post);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 2;
            label2.Text = "Название";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchTB
            // 
            searchTB.Dock = DockStyle.Fill;
            searchTB.Location = new Point(121, 40);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(441, 27);
            searchTB.TabIndex = 3;
            searchTB.TextChanged += searchTB_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 161F));
            tableLayoutPanel2.Controls.Add(chooseButton, 1, 0);
            tableLayoutPanel2.Controls.Add(cancelButton, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 407);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 40);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // chooseButton
            // 
            chooseButton.Dock = DockStyle.Fill;
            chooseButton.Location = new Point(485, 3);
            chooseButton.Name = "chooseButton";
            chooseButton.Size = new Size(145, 34);
            chooseButton.TabIndex = 5;
            chooseButton.Text = "Выбрать";
            chooseButton.UseVisualStyleBackColor = true;
            chooseButton.Click += chooseButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Location = new Point(636, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(155, 34);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // PostChooser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "PostChooser";
            Text = "PostChooser";
            Load += PostChooser_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)postDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)postBindingSource).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView postDataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn mCHIDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn mSUEDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn mAUEDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn mWUEDataGridViewCheckBoxColumn;
        private BindingSource postBindingSource;
        private Label label2;
        private TextBox searchTB;
        private TableLayoutPanel tableLayoutPanel2;
        private Button chooseButton;
        private Button cancelButton;
    }
}