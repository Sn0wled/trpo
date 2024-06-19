namespace trpo.scales
{
    partial class ScalesEditor
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
            label5 = new Label();
            errorTB = new TextBox();
            label4 = new Label();
            maxWTB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            brandTB = new TextBox();
            title = new Label();
            label1 = new Label();
            invNumTB = new TextBox();
            calDateDP = new DateTimePicker();
            tableLayoutPanel2 = new TableLayoutPanel();
            cancelButton = new Button();
            saveButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(errorTB, 1, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(maxWTB, 1, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(brandTB, 1, 2);
            tableLayoutPanel1.Controls.Add(title, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(invNumTB, 1, 1);
            tableLayoutPanel1.Controls.Add(calDateDP, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 160);
            label5.Name = "label5";
            label5.Size = new Size(182, 30);
            label5.TabIndex = 9;
            label5.Text = "Погрешность";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorTB
            // 
            errorTB.Dock = DockStyle.Bottom;
            errorTB.Location = new Point(191, 163);
            errorTB.MaxLength = 10;
            errorTB.Name = "errorTB";
            errorTB.Size = new Size(606, 27);
            errorTB.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 130);
            label4.Name = "label4";
            label4.Size = new Size(182, 30);
            label4.TabIndex = 7;
            label4.Text = "Предельный вес";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // maxWTB
            // 
            maxWTB.Dock = DockStyle.Bottom;
            maxWTB.Location = new Point(191, 133);
            maxWTB.MaxLength = 10;
            maxWTB.Name = "maxWTB";
            maxWTB.Size = new Size(606, 27);
            maxWTB.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 100);
            label3.Name = "label3";
            label3.Size = new Size(182, 30);
            label3.TabIndex = 5;
            label3.Text = "Дата калибровки";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 70);
            label2.Name = "label2";
            label2.Size = new Size(182, 30);
            label2.TabIndex = 3;
            label2.Text = "Марка";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // brandTB
            // 
            brandTB.Dock = DockStyle.Bottom;
            brandTB.Location = new Point(191, 73);
            brandTB.MaxLength = 50;
            brandTB.Name = "brandTB";
            brandTB.Size = new Size(606, 27);
            brandTB.TabIndex = 4;
            // 
            // title
            // 
            title.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(title, 2);
            title.Dock = DockStyle.Fill;
            title.Location = new Point(3, 0);
            title.Name = "title";
            title.Size = new Size(794, 40);
            title.TabIndex = 0;
            title.Text = "Добавление весов";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 1;
            label1.Text = "Инв. номер";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // invNumTB
            // 
            invNumTB.Dock = DockStyle.Bottom;
            invNumTB.Location = new Point(191, 43);
            invNumTB.MaxLength = 10;
            invNumTB.Name = "invNumTB";
            invNumTB.Size = new Size(606, 27);
            invNumTB.TabIndex = 2;
            // 
            // calDateDP
            // 
            calDateDP.Dock = DockStyle.Fill;
            calDateDP.Location = new Point(191, 103);
            calDateDP.MaxDate = new DateTime(2110, 2, 6, 0, 0, 0, 0);
            calDateDP.MinDate = new DateTime(1959, 12, 29, 0, 0, 0, 0);
            calDateDP.Name = "calDateDP";
            calDateDP.Size = new Size(606, 27);
            calDateDP.TabIndex = 11;
            calDateDP.Value = new DateTime(2024, 6, 19, 0, 0, 0, 0);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel2.Controls.Add(saveButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 393);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 54);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Location = new Point(400, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(391, 48);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Fill;
            saveButton.Location = new Point(3, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(391, 48);
            saveButton.TabIndex = 0;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // ScalesEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "ScalesEditor";
            Text = "ScalesEditor";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private TextBox errorTB;
        private Label label4;
        private TextBox maxWTB;
        private Label label3;
        private Label label2;
        private TextBox brandTB;
        private Label title;
        private Label label1;
        private TextBox invNumTB;
        private DateTimePicker calDateDP;
        private TableLayoutPanel tableLayoutPanel2;
        private Button saveButton;
        private Button cancelButton;
    }
}