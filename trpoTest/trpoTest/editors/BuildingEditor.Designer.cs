namespace trpoTest.editors
{
    partial class BuildingEditor
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
            editorTextPanel = new Panel();
            label1 = new Label();
            propsPanel = new Panel();
            zbmNamePanel = new Panel();
            buildingNumberText = new TextBox();
            buildingNumberLabel = new Label();
            buttonsPanel = new Panel();
            cancelButton = new Button();
            saveButton = new Button();
            zbmTable1 = new tables.ZbmTable();
            editorTextPanel.SuspendLayout();
            propsPanel.SuspendLayout();
            zbmNamePanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // editorTextPanel
            // 
            editorTextPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editorTextPanel.Controls.Add(label1);
            editorTextPanel.Location = new Point(3, 4);
            editorTextPanel.Name = "editorTextPanel";
            editorTextPanel.Size = new Size(311, 32);
            editorTextPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(311, 32);
            label1.TabIndex = 0;
            label1.Text = "Добавление здания";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // propsPanel
            // 
            propsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            propsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            propsPanel.Controls.Add(zbmNamePanel);
            propsPanel.Location = new Point(3, 42);
            propsPanel.Name = "propsPanel";
            propsPanel.Size = new Size(311, 36);
            propsPanel.TabIndex = 4;
            // 
            // zbmNamePanel
            // 
            zbmNamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            zbmNamePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            zbmNamePanel.Controls.Add(buildingNumberText);
            zbmNamePanel.Controls.Add(buildingNumberLabel);
            zbmNamePanel.Location = new Point(3, 4);
            zbmNamePanel.Name = "zbmNamePanel";
            zbmNamePanel.Size = new Size(302, 29);
            zbmNamePanel.TabIndex = 0;
            // 
            // buildingNumberText
            // 
            buildingNumberText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buildingNumberText.Location = new Point(91, 3);
            buildingNumberText.MaxLength = 5;
            buildingNumberText.Name = "buildingNumberText";
            buildingNumberText.Size = new Size(208, 23);
            buildingNumberText.TabIndex = 1;
            buildingNumberText.TextChanged += buildingNumberText_TextChanged;
            // 
            // buildingNumberLabel
            // 
            buildingNumberLabel.Font = new Font("Segoe UI", 12F);
            buildingNumberLabel.Location = new Point(3, 0);
            buildingNumberLabel.Name = "buildingNumberLabel";
            buildingNumberLabel.Size = new Size(82, 29);
            buildingNumberLabel.TabIndex = 0;
            buildingNumberLabel.Text = "Название";
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Top;
            buttonsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Controls.Add(saveButton);
            buttonsPanel.Location = new Point(6, 244);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(308, 37);
            buttonsPanel.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top;
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Font = new Font("Segoe UI", 11.25F);
            cancelButton.Location = new Point(173, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(72, 30);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top;
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.Font = new Font("Segoe UI", 11.25F);
            saveButton.Location = new Point(57, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(93, 30);
            saveButton.TabIndex = 0;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // zbmTable1
            // 
            zbmTable1.DataSource = null;
            zbmTable1.Location = new Point(3, 78);
            zbmTable1.MinimumSize = new Size(294, 160);
            zbmTable1.Name = "zbmTable1";
            zbmTable1.Size = new Size(311, 160);
            zbmTable1.TabIndex = 6;
            zbmTable1.SelectionChanged += zbmTable1_SelectionChanged;
            // 
            // BuildingEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(zbmTable1);
            Controls.Add(editorTextPanel);
            Controls.Add(propsPanel);
            Controls.Add(buttonsPanel);
            Name = "BuildingEditor";
            Size = new Size(317, 285);
            editorTextPanel.ResumeLayout(false);
            propsPanel.ResumeLayout(false);
            zbmNamePanel.ResumeLayout(false);
            zbmNamePanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel editorTextPanel;
        private Label label1;
        private Panel propsPanel;
        private Panel zbmNamePanel;
        private TextBox buildingNumberText;
        private Label buildingNumberLabel;
        private Panel buttonsPanel;
        private Button cancelButton;
        private Button saveButton;
        private tables.ZbmTable zbmTable1;
    }
}
