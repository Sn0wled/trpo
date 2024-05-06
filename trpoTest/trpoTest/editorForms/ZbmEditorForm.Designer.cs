namespace trpoTest.editorForms
{
    partial class ZbmEditorForm
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
            zbmEditor1 = new editors.ZbmEditor();
            SuspendLayout();
            // 
            // zbmEditor1
            // 
            zbmEditor1.DataSource = null;
            zbmEditor1.Location = new Point(15, 15);
            zbmEditor1.Margin = new Padding(5);
            zbmEditor1.MaximumSize = new Size(0, 124);
            zbmEditor1.MinimumSize = new Size(200, 124);
            zbmEditor1.Name = "zbmEditor1";
            zbmEditor1.Size = new Size(200, 124);
            zbmEditor1.TabIndex = 0;
            zbmEditor1.Saved += zbmEditor1_Saved;
            zbmEditor1.Canceled += zbmEditor1_Canceled;
            // 
            // ZbmEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(234, 150);
            Controls.Add(zbmEditor1);
            Name = "ZbmEditorForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактор ЗБМ";
            ResumeLayout(false);
        }

        #endregion

        private editors.ZbmEditor zbmEditor1;
    }
}