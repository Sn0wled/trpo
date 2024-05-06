namespace trpoTest.editorForms
{
    partial class BuildingEditorForm
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
            buildingEditor1 = new editors.BuildingEditor();
            label1 = new Label();
            SuspendLayout();
            // 
            // buildingEditor1
            // 
            buildingEditor1.DataSource = null;
            buildingEditor1.Location = new Point(12, 12);
            buildingEditor1.Name = "buildingEditor1";
            buildingEditor1.Size = new Size(317, 285);
            buildingEditor1.TabIndex = 0;
            buildingEditor1.Saved += buildingEditor1_Saved;
            buildingEditor1.Canceled += buildingEditor1_Canceled;
            buildingEditor1.Changed += buildingEditor1_Changed;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 127);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // BuildingEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 450);
            Controls.Add(label1);
            Controls.Add(buildingEditor1);
            Name = "BuildingEditorForm";
            Text = "BuildingEditorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private editors.BuildingEditor buildingEditor1;
        private Label label1;
    }
}