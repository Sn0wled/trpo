namespace trpoTest.editors
{
    partial class RoomEditor
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
            editorLabel = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            button4 = new Button();
            buildingNumberText = new Label();
            label6 = new Label();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            button2 = new Button();
            zbmNameText = new Label();
            label3 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            respEmpTabNumText = new Label();
            label2 = new Label();
            panel3 = new Panel();
            roomNum = new TextBox();
            label1 = new Label();
            buttonsForTable1 = new buttons.ButtonsForTable();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(editorLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 48);
            panel1.TabIndex = 0;
            // 
            // editorLabel
            // 
            editorLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            editorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editorLabel.Location = new Point(0, 0);
            editorLabel.Name = "editorLabel";
            editorLabel.Size = new Size(456, 48);
            editorLabel.TabIndex = 0;
            editorLabel.Text = "label1";
            editorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 160);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Controls.Add(buildingNumberText);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(3, 115);
            panel6.Name = "panel6";
            panel6.Size = new Size(447, 35);
            panel6.TabIndex = 3;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(347, 0);
            button4.Name = "button4";
            button4.Size = new Size(100, 35);
            button4.TabIndex = 9;
            button4.Text = "Выбрать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += EmployeeButton_Click;
            // 
            // buildingNumberText
            // 
            buildingNumberText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buildingNumberText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buildingNumberText.Location = new Point(118, 0);
            buildingNumberText.Name = "buildingNumberText";
            buildingNumberText.Size = new Size(223, 35);
            buildingNumberText.TabIndex = 8;
            buildingNumberText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 35);
            label6.TabIndex = 7;
            label6.Text = "Номер здания";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(594, 0);
            button3.Name = "button3";
            button3.Size = new Size(100, 0);
            button3.TabIndex = 6;
            button3.Text = "Выбрать";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(74, 0);
            label4.Name = "label4";
            label4.Size = new Size(514, 0);
            label4.TabIndex = 5;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 0);
            label5.TabIndex = 4;
            label5.Text = "ЗБМ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Controls.Add(zbmNameText);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(3, 77);
            panel5.Name = "panel5";
            panel5.Size = new Size(447, 35);
            panel5.TabIndex = 2;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(347, 0);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 6;
            button2.Text = "Выбрать";
            button2.UseVisualStyleBackColor = true;
            // 
            // zbmNameText
            // 
            zbmNameText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zbmNameText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            zbmNameText.Location = new Point(74, 0);
            zbmNameText.Name = "zbmNameText";
            zbmNameText.Size = new Size(267, 35);
            zbmNameText.TabIndex = 5;
            zbmNameText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 35);
            label3.TabIndex = 4;
            label3.Text = "ЗБМ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(respEmpTabNumText);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(447, 37);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(347, 0);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 2;
            button1.Text = "Выбрать";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabNumText
            // 
            respEmpTabNumText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            respEmpTabNumText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            respEmpTabNumText.Location = new Point(215, 0);
            respEmpTabNumText.Name = "tabNumText";
            respEmpTabNumText.Size = new Size(123, 37);
            respEmpTabNumText.TabIndex = 4;
            respEmpTabNumText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 37);
            label2.TabIndex = 3;
            label2.Text = "Таб. номер ответственного";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(roomNum);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 31);
            panel3.TabIndex = 0;
            // 
            // roomNum
            // 
            roomNum.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            roomNum.Location = new Point(151, 1);
            roomNum.Name = "roomNum";
            roomNum.Size = new Size(296, 23);
            roomNum.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 31);
            label1.TabIndex = 1;
            label1.Text = "Номер помещения";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonsForTable1
            // 
            buttonsForTable1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonsForTable1.Location = new Point(0, 217);
            buttonsForTable1.MaximumSize = new Size(0, 42);
            buttonsForTable1.MinimumSize = new Size(294, 42);
            buttonsForTable1.Name = "buttonsForTable1";
            buttonsForTable1.Size = new Size(456, 42);
            buttonsForTable1.TabIndex = 2;
            // 
            // RoomEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonsForTable1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(0, 260);
            Name = "RoomEditor";
            Size = new Size(456, 260);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label editorLabel;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Button button1;
        private Label respEmpTabNumText;
        private Label label2;
        private TextBox roomNum;
        private buttons.ButtonsForTable buttonsForTable1;
        private Panel panel5;
        private Button button2;
        private Label zbmNameText;
        private Label label3;
        private Panel panel6;
        private Button button4;
        private Label buildingNumberText;
        private Label label6;
        private Button button3;
        private Label label4;
        private Label label5;
    }
}
