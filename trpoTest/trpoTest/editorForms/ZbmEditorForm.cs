using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trpoTest.tables;

namespace trpoTest.editorForms
{
    public partial class ZbmEditorForm : Form
    {
        public event EventHandler Saved { add { zbmEditor1.Saved += value; } remove { zbmEditor1.Saved -= value; } }
        public event EventHandler Canceled { add { zbmEditor1.Canceled += value; } remove { zbmEditor1.Canceled -= value; } }
        public int CurZbmId { get { return zbmEditor1.CurZbmId; }  }
        public string CurZbmName { get { return zbmEditor1.CurZbmName; } }
        public ZbmEditorForm()
        {
            InitializeComponent();
            zbmEditor1.DataSource = Program.dataSource;
        }

        public void SetEditor(int? SelectedId = null, string? SelectedName = null)
        {
            int? zbmId = SelectedId;
            string? zbmName = SelectedName;
            zbmEditor1.SetEditor(zbmId, zbmName);
        }

        private void zbmEditor1_Canceled(object sender, EventArgs e)
        {
            Close();
        }

        private void zbmEditor1_Saved(object sender, EventArgs e)
        {
            Close();
        }
    }
}
