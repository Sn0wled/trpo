namespace trpo.containers
{
    partial class CylContainerEditor
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
            heightTB = new TextBox();
            weightTB = new TextBox();
            typeTB = new TextBox();
            label5 = new Label();
            label3 = new Label();
            title = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            saveButton = new Button();
            cancelButton = new Button();
            invNumTB = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            diameterTB = new TextBox();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // heightTB
            // 
            heightTB.Dock = DockStyle.Fill;
            heightTB.Location = new Point(169, 133);
            heightTB.Name = "heightTB";
            heightTB.Size = new Size(628, 27);
            heightTB.TabIndex = 19;
            // 
            // weightTB
            // 
            weightTB.Dock = DockStyle.Fill;
            weightTB.Location = new Point(169, 103);
            weightTB.MaxLength = 3;
            weightTB.Name = "weightTB";
            weightTB.PlaceholderText = "000";
            weightTB.Size = new Size(628, 27);
            weightTB.TabIndex = 16;
            // 
            // typeTB
            // 
            typeTB.Dock = DockStyle.Fill;
            typeTB.Location = new Point(169, 73);
            typeTB.MaxLength = 20;
            typeTB.Name = "typeTB";
            typeTB.Size = new Size(628, 27);
            typeTB.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 100);
            label5.Name = "label5";
            label5.Size = new Size(160, 30);
            label5.TabIndex = 5;
            label5.Text = "Вес";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(160, 30);
            label3.TabIndex = 3;
            label3.Text = "Тип";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            title.Text = "Добавление кубического контейнера";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 1;
            label2.Text = "Инв. номер";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 130);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 13;
            label1.Text = "Высота";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(saveButton, 0, 0);
            tableLayoutPanel2.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 409);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 38);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Fill;
            saveButton.Location = new Point(3, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(391, 32);
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
            cancelButton.Size = new Size(391, 32);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // invNumTB
            // 
            invNumTB.Dock = DockStyle.Fill;
            invNumTB.Location = new Point(169, 43);
            invNumTB.MaxLength = 5;
            invNumTB.Name = "invNumTB";
            invNumTB.PlaceholderText = "00000";
            invNumTB.Size = new Size(628, 27);
            invNumTB.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 166F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(heightTB, 1, 4);
            tableLayoutPanel1.Controls.Add(weightTB, 1, 3);
            tableLayoutPanel1.Controls.Add(typeTB, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(title, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(invNumTB, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(diameterTB, 1, 5);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 160);
            label4.Name = "label4";
            label4.Size = new Size(160, 30);
            label4.TabIndex = 22;
            label4.Text = "Диаметр";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // diameterTB
            // 
            diameterTB.Dock = DockStyle.Fill;
            diameterTB.Location = new Point(169, 163);
            diameterTB.Name = "diameterTB";
            diameterTB.Size = new Size(628, 27);
            diameterTB.TabIndex = 23;
            // 
            // CylContainerEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "CylContainerEditor";
            Text = "CylContainerEditor";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox heightTB;
        private TextBox weightTB;
        private TextBox typeTB;
        private Label label5;
        private Label label3;
        private Label title;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button saveButton;
        private Button cancelButton;
        private TextBox invNumTB;
        private Label label4;
        private TextBox diameterTB;
    }
}