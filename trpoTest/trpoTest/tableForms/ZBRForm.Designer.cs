namespace trpoTest.tableForms
{
    partial class ZBRForm
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
            panel1 = new Panel();
            zbmButtons = new buttons.ButtonsForTable();
            zbmTable1 = new tables.ZbmTable();
            panel2 = new Panel();
            buildingButtons = new buttons.ButtonsForTable();
            buildingTable1 = new tables.BuildingTable();
            panel3 = new Panel();
            roomButtons = new buttons.ButtonsForTable();
            roomTable1 = new tables.RoomTable();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(zbmButtons);
            panel1.Controls.Add(zbmTable1);
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 483);
            panel1.TabIndex = 0;
            // 
            // zbmButtons
            // 
            zbmButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zbmButtons.Location = new Point(-1, 439);
            zbmButtons.MaximumSize = new Size(0, 42);
            zbmButtons.MinimumSize = new Size(294, 42);
            zbmButtons.Name = "zbmButtons";
            zbmButtons.Size = new Size(294, 42);
            zbmButtons.TabIndex = 1;
            zbmButtons.CreateClicked += zbmButtons_CreateClicked;
            zbmButtons.DeleteClicked += zbmButtons_DeleteClicked;
            zbmButtons.EditClicked += zbmButtons_EditClicked;
            // 
            // zbmTable1
            // 
            zbmTable1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zbmTable1.DataSource = null;
            zbmTable1.Location = new Point(-1, -1);
            zbmTable1.MinimumSize = new Size(294, 160);
            zbmTable1.Name = "zbmTable1";
            zbmTable1.Size = new Size(294, 434);
            zbmTable1.TabIndex = 0;
            zbmTable1.TableRefilled += zbmTable1_TableRefilled;
            zbmTable1.SelectionChanged += zbmTable1_SelectionChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(buildingButtons);
            panel2.Controls.Add(buildingTable1);
            panel2.Location = new Point(309, 9);
            panel2.MinimumSize = new Size(294, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 482);
            panel2.TabIndex = 1;
            // 
            // buildingButtons
            // 
            buildingButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buildingButtons.Location = new Point(0, 438);
            buildingButtons.Margin = new Padding(0, 3, 0, 0);
            buildingButtons.MaximumSize = new Size(0, 42);
            buildingButtons.MinimumSize = new Size(294, 42);
            buildingButtons.Name = "buildingButtons";
            buildingButtons.Size = new Size(294, 42);
            buildingButtons.TabIndex = 2;
            buildingButtons.CreateClicked += buildingButtons_CreateClicked;
            buildingButtons.DeleteClicked += buildingButtons_DeleteClicked;
            buildingButtons.EditClicked += buildingButtons_EditClicked;
            // 
            // buildingTable1
            // 
            buildingTable1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buildingTable1.DataSource = null;
            buildingTable1.Location = new Point(0, 0);
            buildingTable1.Margin = new Padding(0, 0, 0, 3);
            buildingTable1.MinimumSize = new Size(294, 160);
            buildingTable1.Name = "buildingTable1";
            buildingTable1.Size = new Size(294, 432);
            buildingTable1.TabIndex = 0;
            buildingTable1.TableRefilled += buildingTable1_TableRefilled;
            buildingTable1.SelectionChanged += buildingTable1_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(roomButtons);
            panel3.Controls.Add(roomTable1);
            panel3.Location = new Point(609, 10);
            panel3.MinimumSize = new Size(294, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 481);
            panel3.TabIndex = 1;
            // 
            // roomButtons
            // 
            roomButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roomButtons.Location = new Point(0, 437);
            roomButtons.Margin = new Padding(0, 3, 0, 0);
            roomButtons.MaximumSize = new Size(0, 42);
            roomButtons.MinimumSize = new Size(294, 42);
            roomButtons.Name = "roomButtons";
            roomButtons.Size = new Size(311, 42);
            roomButtons.TabIndex = 3;
            // 
            // roomTable1
            // 
            roomTable1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            roomTable1.DataSource = null;
            roomTable1.Location = new Point(0, 0);
            roomTable1.Margin = new Padding(0, 0, 0, 3);
            roomTable1.MinimumSize = new Size(294, 160);
            roomTable1.Name = "roomTable1";
            roomTable1.Size = new Size(311, 431);
            roomTable1.TabIndex = 0;
            roomTable1.TableRefilled += roomTable1_TableRefilled;
            // 
            // ZBRForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 499);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(946, 2000);
            MinimumSize = new Size(946, 400);
            Name = "ZBRForm";
            Padding = new Padding(5);
            Text = "ZBRForm";
            Load += ZBRForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private tables.ZbmTable zbmTable1;
        private buttons.ButtonsForTable zbmButtons;
        private buttons.ButtonsForTable buildingButtons;
        private tables.BuildingTable buildingTable1;
        private tables.RoomTable roomTable1;
        private buttons.ButtonsForTable roomButtons;
    }
}