namespace trpo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkLabel1 = new LinkLabel();
            groupBox1 = new GroupBox();
            button1 = new Button();
            scalesButton = new Button();
            contButton = new Button();
            materialButton = new Button();
            zbmBuildPlaceButton = new Button();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(372, 219);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(scalesButton);
            groupBox1.Controls.Add(contButton);
            groupBox1.Controls.Add(materialButton);
            groupBox1.Controls.Add(zbmBuildPlaceButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Справочная информация";
            // 
            // button1
            // 
            button1.Location = new Point(6, 166);
            button1.Name = "button1";
            button1.Size = new Size(238, 29);
            button1.TabIndex = 4;
            button1.Text = "Сотрудники";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // scalesButton
            // 
            scalesButton.Location = new Point(6, 131);
            scalesButton.Name = "scalesButton";
            scalesButton.Size = new Size(238, 29);
            scalesButton.TabIndex = 3;
            scalesButton.Text = "Весы";
            scalesButton.UseVisualStyleBackColor = true;
            scalesButton.Click += scalesButton_Click;
            // 
            // contButton
            // 
            contButton.Location = new Point(6, 96);
            contButton.Name = "contButton";
            contButton.Size = new Size(238, 29);
            contButton.TabIndex = 2;
            contButton.Text = "Контейнеры";
            contButton.UseVisualStyleBackColor = true;
            contButton.Click += contButton_Click;
            // 
            // materialButton
            // 
            materialButton.Location = new Point(6, 61);
            materialButton.Name = "materialButton";
            materialButton.Size = new Size(238, 29);
            materialButton.TabIndex = 1;
            materialButton.Text = "Материалы";
            materialButton.UseVisualStyleBackColor = true;
            materialButton.Click += materialButton_Click;
            // 
            // zbmBuildPlaceButton
            // 
            zbmBuildPlaceButton.Location = new Point(0, 26);
            zbmBuildPlaceButton.Name = "zbmBuildPlaceButton";
            zbmBuildPlaceButton.Size = new Size(244, 29);
            zbmBuildPlaceButton.TabIndex = 0;
            zbmBuildPlaceButton.Text = "ЗБМ / Здание / Помещение";
            zbmBuildPlaceButton.UseVisualStyleBackColor = true;
            zbmBuildPlaceButton.Click += zbmBuildPlaceButton_Click;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel1);
            Name = "Form1";
            Text = "1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private Button zbmBuildPlaceButton;
        private Button materialButton;
        private Button contButton;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button scalesButton;
        private Button button1;
    }
}
