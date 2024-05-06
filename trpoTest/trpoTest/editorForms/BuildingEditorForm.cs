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
using trpoTest.editors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trpoTest.editorForms
{
    public partial class BuildingEditorForm : Form
    {
        public event EventHandler Saved { add { buildingEditor1.Saved += value; } remove { buildingEditor1.Saved -= value; } }
        public event EventHandler Canceled { add { buildingEditor1.Canceled += value; } remove { buildingEditor1.Canceled -= value; } }
        public int CurZbmId { get { return buildingEditor1.CurZbmId; } }
        public string CurBuildingNumber { get { return buildingEditor1.CurBuildingNumber; } }
        public BuildingEditorForm()
        {
            InitializeComponent();
            buildingEditor1.DataSource = Program.dataSource;
        }

        public void InitEditor(int zbmid, string? buildingNumber = null)
        {
            buildingEditor1.InitEditor(zbmid, buildingNumber);
        }

        private void buildingEditor1_Canceled(object sender, EventArgs e)
        {
            Close();
        }

        private void buildingEditor1_Saved(object sender, EventArgs e)
        {
            Close();
        }

        private void buildingEditor1_Changed(object sender, EventArgs e)
        {
            label1.Text = buildingEditor1.CurZbmId.ToString();
        }
    }
}
