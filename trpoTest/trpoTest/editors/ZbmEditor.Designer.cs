namespace trpoTest.editors
{
    partial class ZbmEditor
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
            zbmNameText = new TextBox();
            zbmNameLabel = new Label();
            buttonsPanel = new Panel();
            cancelButton = new Button();
            saveButton = new Button();
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
            editorTextPanel.Location = new Point(3, 3);
            editorTextPanel.Name = "editorTextPanel";
            editorTextPanel.Size = new Size(194, 32);
            editorTextPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 0;
            label1.Text = "Добавление ЗБМ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // propsPanel
            // 
            propsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            propsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            propsPanel.Controls.Add(zbmNamePanel);
            propsPanel.Location = new Point(3, 37);
            propsPanel.Name = "propsPanel";
            propsPanel.Size = new Size(194, 36);
            propsPanel.TabIndex = 1;
            // 
            // zbmNamePanel
            // 
            zbmNamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            zbmNamePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            zbmNamePanel.Controls.Add(zbmNameText);
            zbmNamePanel.Controls.Add(zbmNameLabel);
            zbmNamePanel.Location = new Point(3, 4);
            zbmNamePanel.Name = "zbmNamePanel";
            zbmNamePanel.Size = new Size(188, 29);
            zbmNamePanel.TabIndex = 0;
            // 
            // zbmNameText
            // 
            zbmNameText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            zbmNameText.Location = new Point(91, 3);
            zbmNameText.MaxLength = 20;
            zbmNameText.Name = "zbmNameText";
            zbmNameText.Size = new Size(94, 23);
            zbmNameText.TabIndex = 1;
            zbmNameText.TextChanged += zbmNameText_TextChanged;
            // 
            // zbmNameLabel
            // 
            zbmNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zbmNameLabel.Location = new Point(3, 0);
            zbmNameLabel.Name = "zbmNameLabel";
            zbmNameLabel.Size = new Size(82, 23);
            zbmNameLabel.TabIndex = 0;
            zbmNameLabel.Text = "Название";
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Top;
            buttonsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Controls.Add(saveButton);
            buttonsPanel.Location = new Point(3, 83);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(194, 37);
            buttonsPanel.TabIndex = 2;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top;
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(119, 4);
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
            saveButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(93, 30);
            saveButton.TabIndex = 0;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // ZbmEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonsPanel);
            Controls.Add(propsPanel);
            Controls.Add(editorTextPanel);
            MaximumSize = new Size(0, 124);
            MinimumSize = new Size(200, 124);
            Name = "ZbmEditor";
            Size = new Size(200, 124);
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
        private TextBox zbmNameText;
        private Label zbmNameLabel;
        private Panel buttonsPanel;
        private Button saveButton;
        private Button cancelButton;
    }
}
