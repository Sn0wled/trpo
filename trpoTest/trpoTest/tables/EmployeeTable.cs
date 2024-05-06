using Npgsql;
using System.ComponentModel;
using System.Data;

namespace trpoTest.tables
{

    public partial class EmployeeTable : UserControl
    {
        public NpgsqlDataSource DataSource { get; set; } = null!;
        public EmployeeTable()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            TableRefilled += handleFilled;
        }

        // возвращает true если таблица пустая
        public bool IsEmpty { get { return employeeDataGrid.Rows.Count == 0; } }

        // возвращает true если выбрана строка
        public bool HasSelected { get { return employeeDataGrid.SelectedRows.Count != 0; } }

        // элементы таблицы
        public string SelectedTabNum { get { return (string)employeeDataGrid.SelectedRows[0].Cells[0].Value; } }
        public string SelectedLName { get { return (string)employeeDataGrid.SelectedRows[0].Cells[1].Value; } }
        public string SelectedFName { get { return (string)employeeDataGrid.SelectedRows[0].Cells[2].Value; } }
        public string? SelectedPName { get { return (string?)employeeDataGrid.SelectedRows[0].Cells[3].Value; } }
        public string? SelectedPhoneNumber { get { return (string?)employeeDataGrid.SelectedRows[0].Cells[4].Value; } }
        public DateTime SelectedBirthDay { get { return ((DateTime)employeeDataGrid.SelectedRows[0].Cells[5].Value); } }
        public string SelectedINN { get { return (string)employeeDataGrid.SelectedRows[0].Cells[6].Value; } }
        public string? SelectedAddress { get { return (string?)employeeDataGrid.SelectedRows[0].Cells[7].Value; } }
        public string SelectedPassportData { get { return (string)employeeDataGrid.SelectedRows[0].Cells[8].Value; } }
        public string SelectedSNILS { get { return (string)employeeDataGrid.SelectedRows[0].Cells[9].Value; } }
        public int SelectedPostId { get { return (int)employeeDataGrid.SelectedRows[0].Cells[10].Value; } }

        // управление скрытыми столбцами

        public bool ShowHidden
        {
            set
            {
                if (value == true) employeeDataGrid.Columns[10].Visible = true;
                else employeeDataGrid.Columns[10].Visible = true;
            }
        }

        // выбрана строка (автоматически выбирается при заполнении)

        public event EventHandler SelectionChanged
        {
            add { employeeDataGrid.SelectionChanged += value; }
            remove { employeeDataGrid.SelectionChanged -= value; }
        }

        // заполнение таблицы
        public event EventHandler TableRefilled;

        public void FillTable()
        {
            if (DataSource == null)
            {
                MessageBox.Show("Не задан DataSource");
                return;
            }
            employeeDataGrid.Rows.Clear();
            using var cmd = DataSource.CreateCommand("select Сотрудник.*, название_должности from Сотрудник join Должность using (id_должности)");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AddRow(reader);
            }
            TableRefilled?.Invoke(this, EventArgs.Empty);
        }

        void AddRow(NpgsqlDataReader reader)
        {
            employeeDataGrid.Rows.Add(
                    reader.GetString(10),
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.IsDBNull(2) ? null : reader.GetString(2),
                    reader.IsDBNull(3) ? null : reader.GetString(3),
                    reader.GetDateTime(4),
                    reader.GetString(5),
                    reader.IsDBNull(6) ? null : reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8),
                    reader.GetString(11),
                    reader.GetInt32(9)
            );
        }

        // когда таблица заполнилась
        void handleFilled(object? sender, EventArgs e)
        {
            Sort();
        }

        // sorting

        void Sort()
        {
            if (employeeDataGrid.SortOrder.HasFlag(SortOrder.Ascending))
            {
                employeeDataGrid.Sort(employeeDataGrid.SortedColumn, ListSortDirection.Ascending);
            }
            else if (employeeDataGrid.SortOrder.HasFlag(SortOrder.Descending))
            {
                employeeDataGrid.Sort(employeeDataGrid.SortedColumn, ListSortDirection.Descending);
            }
        }

        // поиск

        public void Search(string sub, int index)
        {
            if (sub.Length == 0) { return; }
            foreach (DataGridViewRow row in employeeDataGrid.Rows)
            {
                string value;
                if (row.Cells[index].Value is DateTime dt)
                {
                    value = dt.ToShortDateString();
                } else
                {
                    value = (string)row.Cells[index].Value;
                }
                if (value == null) { continue; }
                if (value.ToLower().StartsWith(sub.ToLower()))
                {
                    row.Selected = true;
                    employeeDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(textBox1.Text, comboBox1.SelectedIndex);
        }
    }
}
