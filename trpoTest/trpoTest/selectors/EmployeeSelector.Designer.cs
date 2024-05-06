namespace trpoTest.selectors
{
    partial class EmployeeSelector
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
            employeeTable1 = new tables.EmployeeTable();
            saveButton = new Button();
            delButton = new Button();
            SuspendLayout();
            // 
            // employeeTable1
            // 
            employeeTable1.DataSource = null;
            employeeTable1.Location = new Point(12, 12);
            employeeTable1.Name = "employeeTable1";
            employeeTable1.Size = new Size(776, 470);
            employeeTable1.TabIndex = 0;
            employeeTable1.SelectionChanged += employeeTable1_SelectionChanged;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            saveButton.Location = new Point(614, 488);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(93, 35);
            saveButton.TabIndex = 1;
            saveButton.Text = "Выбрать";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // delButton
            // 
            delButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            delButton.Location = new Point(713, 488);
            delButton.Name = "delButton";
            delButton.Size = new Size(75, 35);
            delButton.TabIndex = 2;
            delButton.Text = "Отмена";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // EmployeeSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(delButton);
            Controls.Add(saveButton);
            Controls.Add(employeeTable1);
            Name = "EmployeeSelector";
            Text = " Выбор сотрудника";
            ResumeLayout(false);
        }

        #endregion

        private tables.EmployeeTable employeeTable1;
        private Button saveButton;
        private Button delButton;
    }
}