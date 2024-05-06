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
    public partial class RoomTable : UserControl
    {
        public NpgsqlDataSource DataSource { get; set; }

        public RoomTable()
        {
            InitializeComponent();
        }

        // поиск

        public void Search(string sub)
        {
            if (sub.Length == 0) { return; }
            foreach (DataGridViewRow row in roomDataGrid.Rows)
            {
                string? value = row.Cells[2].Value as string;
                if (value.ToLower().StartsWith(sub.ToLower()))
                {
                    row.Selected = true;
                    roomDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            Search(searchText.Text);
        }

        // таблица
        public event EventHandler TableRefilled;

        public event EventHandler SelectionChanged
        {
            add { roomDataGrid.SelectionChanged += value; }
            remove { roomDataGrid.SelectionChanged -= value; }
        }

        public bool IsEmpty
        {
            get { return roomDataGrid.Rows.Count == 0; }
        }

        public int? SelectedZbmId
        {
            get
            {
                if (roomDataGrid.SelectedRows.Count == 0) return null;
                return roomDataGrid.SelectedRows[0].Cells[0].Value as int?;
            }
        }

        public string? SelectedBuildingNumber
        {
            get
            {
                if (roomDataGrid.SelectedRows.Count == 0) return null;
                return roomDataGrid.SelectedRows[0].Cells[1].Value as string;
            }
        }

        public string? SelectedNumber
        {
            get
            {
                if (roomDataGrid.SelectedRows.Count == 0) return null;
                return roomDataGrid.SelectedRows[0].Cells[2].Value as string;
            }
        }
        public string? SelectedRespTabNum
        {
            get
            {
                if (roomDataGrid.SelectedRows.Count == 0) return null;
                return roomDataGrid.SelectedRows[0].Cells[3].Value as string;
            }
        }
        public bool ShowHidden
        {
            set
            {
                if (value == true)
                {
                    roomDataGrid.Columns[0].Visible = true;
                    roomDataGrid.Columns[1].Visible = true;
                }
                else
                {
                    roomDataGrid.Columns[0].Visible = true;
                    roomDataGrid.Columns[1].Visible = true;
                }
            }
        }

        public void FillTable(int? zbmId, string? buildingNumber)
        {
            if (DataSource == null)
            {
                MessageBox.Show("Не задан DataSource");
                return;
            }
            /*if (zbmId == null || buildingNumber == null)
            {
                roomDataGrid.Rows.Clear();
                TableRefilled?.Invoke(this, EventArgs.Empty);
                return;
            }*/
            try
            {
                using var cmd = DataSource.CreateCommand("select * from Помещение where id_ЗБМ = $1 and номер_здания = $2");
                cmd.Parameters.Add(new() { Value = zbmId });
                cmd.Parameters.Add(new() { Value = buildingNumber });
                using var reader = cmd.ExecuteReader();
                roomDataGrid.Rows.Clear();
                while (reader.Read())
                {
                    roomDataGrid.Rows.Add(reader.GetInt32(0), reader.GetString(2), reader.GetString(3), reader.GetString(1));
                }

                TableRefilled?.Invoke(this, EventArgs.Empty);

                if (roomDataGrid.SortOrder.HasFlag(SortOrder.Ascending))
                {
                    roomDataGrid.Sort(roomDataGrid.SortedColumn, ListSortDirection.Ascending);
                }
                else if (roomDataGrid.SortOrder.HasFlag(SortOrder.Descending))
                {
                    roomDataGrid.Sort(roomDataGrid.SortedColumn, ListSortDirection.Descending);
                }
            }
            catch (PostgresException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            roomDataGrid.Rows.Clear();
            TableRefilled?.Invoke(this, EventArgs.Empty);
        }

        public void Select(string number)
        {
            foreach (DataGridViewRow row in roomDataGrid.Rows)
            {
                if (row.Cells[2].Value.Equals(number))
                {
                    row.Selected = true;
                    roomDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }
    }
}
