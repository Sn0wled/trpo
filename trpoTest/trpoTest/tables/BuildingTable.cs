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

namespace trpoTest.tables
{
    public partial class BuildingTable : UserControl
    {
        public NpgsqlDataSource DataSource { get; set; }
        public BuildingTable()
        {
            InitializeComponent();
        }

        // поиск

        public void Search(string sub)
        {
            if (sub.Length == 0) { return; }
            foreach (DataGridViewRow row in buildingDataGrid.Rows)
            {
                string? value = row.Cells[1].Value as string;
                if (value.ToLower().StartsWith(sub.ToLower()))
                {
                    row.Selected = true;
                    buildingDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                }
            }
        }

        private void searchPropText_TextChanged(object sender, EventArgs e)
        {
            Search(searchPropText.Text);
        }

        // таблица
        public event EventHandler TableRefilled;

        public event EventHandler SelectionChanged
        {
            add
            {
                buildingDataGrid.SelectionChanged += value;
            }
            remove
            {
                buildingDataGrid.SelectionChanged -= value;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return buildingDataGrid.Rows.Count == 0;
            }
        }

        public int? SelectedZbmId
        {
            get
            {
                if (buildingDataGrid.SelectedRows.Count == 0) return null;
                return buildingDataGrid.SelectedRows[0].Cells[0].Value as int?;
            }
        }

        public string? SelectedNumber
        {
            get
            {
                if (buildingDataGrid.SelectedRows.Count == 0) return null;
                return buildingDataGrid.SelectedRows[0].Cells[1].Value as string;
            }
        }
        public bool ShowId
        {
            set
            {
                if (value == true)
                {
                    buildingDataGrid.Columns[0].Visible = true;
                }
                else
                {
                    buildingDataGrid.Columns[0].Visible = true;
                }
            }
        }

        public void FillTable(int zbmId)
        {
            if (DataSource == null)
            {
                MessageBox.Show("Не задан DataSource");
                return;
            }
            try
            {
                using var cmd = DataSource.CreateCommand("select * from Здание where id_ЗБМ = $1");
                cmd.Parameters.Add(new() { Value = zbmId });
                using var reader = cmd.ExecuteReader();
                buildingDataGrid.Rows.Clear();
                while (reader.Read())
                {
                    buildingDataGrid.Rows.Add(reader.GetInt32(1), reader.GetString(0));
                }

                TableRefilled?.Invoke(this, EventArgs.Empty);

                if (buildingDataGrid.SortOrder.HasFlag(SortOrder.Ascending))
                {
                    buildingDataGrid.Sort(buildingDataGrid.SortedColumn, ListSortDirection.Ascending);
                }
                else if (buildingDataGrid.SortOrder.HasFlag(SortOrder.Descending))
                {
                    buildingDataGrid.Sort(buildingDataGrid.SortedColumn, ListSortDirection.Descending);
                }
            }
            catch (PostgresException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Select(string number)
        {
            foreach (DataGridViewRow row in buildingDataGrid.Rows)
            {
                if (row.Cells[1].Value.Equals(number))
                {
                    row.Selected = true;
                    buildingDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }
    }
}
