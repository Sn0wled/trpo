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
using trpoTest.editorForms;
using trpoTest.editors;

namespace trpoTest.tableForms
{
    public partial class ZBRForm : Form
    {
        NpgsqlDataSource dataSource = Program.dataSource;
        ZbmEditorForm zbmEditor = new();
        BuildingEditorForm buildingEditor = new();
        public ZBRForm()
        {
            InitializeComponent();
            zbmTable1.DataSource = Program.dataSource;
            buildingTable1.DataSource = Program.dataSource;
            roomTable1.DataSource = Program.dataSource;
            zbmButtons.CheckEditDel(null);
            buildingButtons.CheckEditDel(null);
            roomButtons.CheckEditDel(null);
            buildingButtons.CheckAdd(true);
            roomButtons.CheckAdd(true);
            zbmEditor.Saved += zbmEditorSaved!;
            buildingEditor.Saved += buildingEditorSaved!;
        }

        private void ZBRForm_Load(object sender, EventArgs e)
        {
            zbmTable1.Init();
        }

        private void zbmTable1_SelectionChanged(object sender, EventArgs e)
        {
            if (zbmTable1.SelectedId is int id)
            {
                buildingTable1.FillTable(id);
            }
        }

        private void buildingTable1_SelectionChanged(object sender, EventArgs e)
        {
            if (buildingTable1.SelectedNumber is string buildingNumber && buildingTable1.SelectedZbmId is int zbmId)
            {
                roomTable1.FillTable(zbmId, buildingNumber);
            }
            else
            {
                roomTable1.Clear();
            }
        }

        // zbm

        void DeleteZbm(int id)
        {
            using var cmd = dataSource.CreateCommand("delete from ЗБМ where id_ЗБМ = $1");
            cmd.Parameters.Add(new() { Value = id });
            cmd.ExecuteNonQuery();
        }

        private void zbmButtons_DeleteClicked(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Подтвердите удаление", "Подтвердите удаление", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DeleteZbm(zbmTable1.SelectedId!.Value);
                    zbmTable1.FillTable();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void zbmTable1_TableRefilled(object sender, EventArgs e)
        {
            buildingButtons.CheckAdd(zbmTable1.IsEmpty);
            zbmButtons.CheckEditDel(zbmTable1.SelectedId);
        }

        private void zbmButtons_CreateClicked(object sender, EventArgs e)
        {
            zbmEditor.SetEditor();
            zbmEditor.ShowDialog();
        }

        private void zbmButtons_EditClicked(object sender, EventArgs e)
        {
            zbmEditor.SetEditor(zbmTable1.SelectedId, zbmTable1.SelectedName);
            zbmEditor.ShowDialog();
        }

        public void zbmEditorSaved(object sender, EventArgs e)
        {
            string name = zbmEditor.CurZbmName;
            zbmTable1.FillTable();
            zbmTable1.Select(name);
        }


        // building

        private void buildingTable1_TableRefilled(object sender, EventArgs e)
        {
            roomButtons.CheckAdd(buildingTable1.IsEmpty);
            buildingButtons.CheckEditDel(buildingTable1.SelectedNumber);
        }

        private void DeleteBuilding(int zbmId, string buildingNumber)
        {
            using var cmd = dataSource.CreateCommand("delete from Здание where id_ЗБМ = $1 and номер_здания = $2");
            cmd.Parameters.Add(new() { Value = zbmId });
            cmd.Parameters.Add(new() { Value = buildingNumber });
            cmd.ExecuteNonQuery();
        }

        private void buildingButtons_DeleteClicked(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Подтвердите удаление", "Подтвердите удаление", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DeleteBuilding(buildingTable1.SelectedZbmId!.Value, buildingTable1.SelectedNumber!);
                    buildingTable1.FillTable(zbmTable1.SelectedId!.Value);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        public void buildingEditorSaved(object sender, EventArgs e)
        {
            string number = buildingEditor.CurBuildingNumber;
            buildingTable1.FillTable(zbmTable1.SelectedId!.Value);
            buildingTable1.Select(number);
        }

        private void buildingButtons_EditClicked(object sender, EventArgs e)
        {
            buildingEditor.InitEditor(buildingTable1.SelectedZbmId!.Value, buildingTable1.SelectedNumber!);
            buildingEditor.ShowDialog();
        }

        private void buildingButtons_CreateClicked(object sender, EventArgs e)
        {
            buildingEditor.InitEditor(zbmTable1.SelectedId!.Value);
            buildingEditor.ShowDialog();
        }


        // room

        private void roomTable1_TableRefilled(object sender, EventArgs e)
        {
            roomButtons.CheckEditDel(roomTable1.SelectedBuildingNumber);
        }
    }
}
