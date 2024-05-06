namespace trpoTest.buttons
{
    partial class ButtonsForTable
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
            deleteButton = new Button();
            editButton = new Button();
            createButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(createButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 36);
            panel1.TabIndex = 2;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(195, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(90, 30);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top;
            editButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            editButton.Location = new Point(99, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(90, 30);
            editButton.TabIndex = 1;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            createButton.AutoSize = true;
            createButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            createButton.Location = new Point(3, 3);
            createButton.Name = "createButton";
            createButton.Size = new Size(90, 30);
            createButton.TabIndex = 0;
            createButton.Text = "Добавить";
            createButton.UseVisualStyleBackColor = true;
            // 
            // ButtonsForTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            MaximumSize = new Size(0, 42);
            MinimumSize = new Size(294, 42);
            Name = "ButtonsForTable";
            Size = new Size(294, 42);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button deleteButton;
        private Button editButton;
        private Button createButton;
    }
}
