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

namespace trpoTest.tables
{
    public partial class ZbmTable : UserControl
    {
        public NpgsqlDataSource DataSource { get; set; }

        public ZbmTable()
        {
            InitializeComponent();
        }

        // общее

        public void Init()
        {
            FillTable();
        }


        // поиск

        public void Search(string sub)
        {
            if (sub.Length == 0) { return; }
            foreach (DataGridViewRow row in zbmDataGrid.Rows)
            {
                string? value = row.Cells[1].Value as string;
                if (value.ToLower().StartsWith(sub.ToLower()))
                {
                    row.Selected = true;
                    zbmDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
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
            add
            {
                zbmDataGrid.SelectionChanged += value;
            }
            remove
            {
                zbmDataGrid.SelectionChanged -= value;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return zbmDataGrid.Rows.Count == 0;
            }
        }

        public int? SelectedId
        {
            get
            {
                if (zbmDataGrid.SelectedRows.Count == 0) return null;
                return zbmDataGrid.SelectedRows[0].Cells[0].Value as int?;
            }
        }

        public string? SelectedName
        {
            get
            {
                if (zbmDataGrid.SelectedRows.Count == 0) return null;
                return zbmDataGrid.SelectedRows[0].Cells[1].Value as string;
            }
        }

        public bool ShowId
        {
            set
            {
                if (value == true)
                {
                    zbmDataGrid.Columns[0].Visible = true;
                }
                else
                {
                    zbmDataGrid.Columns[0].Visible = true;
                }
            }
        }

        public void FillTable()
        {
            if (DataSource == null)
            {
                MessageBox.Show("Не задан DataSource");
                return;
            }
            try
            {
                using var cmd = DataSource.CreateCommand("select * from ЗБМ");
                using var reader = cmd.ExecuteReader();
                zbmDataGrid.Rows.Clear();
                while (reader.Read())
                {
                    zbmDataGrid.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }

                TableRefilled?.Invoke(this, EventArgs.Empty);

                if (zbmDataGrid.SortOrder.HasFlag(SortOrder.Ascending))
                {
                    zbmDataGrid.Sort(zbmDataGrid.SortedColumn, ListSortDirection.Ascending);
                }
                else if (zbmDataGrid.SortOrder.HasFlag(SortOrder.Descending))
                {
                    zbmDataGrid.Sort(zbmDataGrid.SortedColumn, ListSortDirection.Descending);
                }
            }
            catch (PostgresException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Select(string zbmName)
        {
            foreach (DataGridViewRow row in zbmDataGrid.Rows)
            {
                if (row.Cells[1].Value.Equals(zbmName))
                {
                    row.Selected = true;
                    zbmDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }

        public void Select(int zbmId)
        {
            foreach (DataGridViewRow row in zbmDataGrid.Rows)
            {
                if (row.Cells[0].Value.Equals(zbmId))
                {
                    row.Selected = true;
                    zbmDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }
    }
}
