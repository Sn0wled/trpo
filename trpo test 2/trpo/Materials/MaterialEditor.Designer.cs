namespace trpo.Materials
{
    partial class MaterialEditor
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
            tableLayoutPanel1 = new TableLayoutPanel();
            am = new TextBox();
            lab = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            saveButton = new Button();
            cancelButton = new Button();
            windowLabel = new Label();
            label2 = new Label();
            matType = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(am, 1, 2);
            tableLayoutPanel1.Controls.Add(lab, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(windowLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(matType, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // am
            // 
            am.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            am.Location = new Point(153, 79);
            am.MaxLength = 30;
            am.Name = "am";
            am.Size = new Size(644, 27);
            am.TabIndex = 9;
            am.TextChanged += am_TextChanged;
            // 
            // lab
            // 
            lab.Location = new Point(3, 76);
            lab.Name = "lab";
            lab.Size = new Size(144, 30);
            lab.TabIndex = 8;
            lab.Text = "Атомная масса";
            lab.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(saveButton, 0, 0);
            tableLayoutPanel2.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 403);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 44);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Fill;
            saveButton.Location = new Point(3, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(391, 38);
            saveButton.TabIndex = 0;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Location = new Point(400, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(391, 38);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
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
            windowLabel.Text = "Добавление материала";
            windowLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 1;
            label2.Text = "Тип материала";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // matType
            // 
            matType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            matType.Location = new Point(153, 43);
            matType.MaxLength = 30;
            matType.Name = "matType";
            matType.Size = new Size(644, 27);
            matType.TabIndex = 4;
            // 
            // MaterialEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MaterialEditor";
            Text = "MaterialEditor";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lab;
        private TableLayoutPanel tableLayoutPanel2;
        private Button saveButton;
        private Button cancelButton;
        private Label windowLabel;
        private Label label2;
        private TextBox matType;
        private TextBox am;
    }
}