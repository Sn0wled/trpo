using Npgsql;

namespace trpoTest.editors
{
    public partial class BuildingEditor : UserControl
    {
        int startZbmId;
        string startBuildingNumber;
        public int CurZbmId { get; private set; }
        public string CurBuildingNumber { get; private set; }
        public bool IsEditor { get; private set; } = false;
        NpgsqlDataSource _dataSource;
        public NpgsqlDataSource DataSource { get { return _dataSource; } set { _dataSource = value; zbmTable1.DataSource = value; } }
        public event EventHandler Saved;
        public event EventHandler Canceled;
        public event EventHandler Changed;

        public BuildingEditor()
        {
            InitializeComponent();
            zbmTable1.ShowId = true;
        }

        // инициализация редактора

        public void InitEditor(int startZbmId, string? startBuildingNumber = null)
        {
            InitValues(startZbmId, startBuildingNumber);
            InitNumber();
            InitTable();
            CheckButton();
            zbmTable1.Select(startZbmId);
        }

        void InitValues(int startZbmId, string? startBuildingNumber)
        {
            this.startZbmId = startZbmId;
            if (startBuildingNumber == null)
            {
                this.startBuildingNumber = "";
                IsEditor = false;
                label1.Text = "Добавление здания";
            }
            else
            {
                this.startBuildingNumber = startBuildingNumber;
                IsEditor = true;
                label1.Text = "Редактирование здания";
            }
            CurBuildingNumber = this.startBuildingNumber;
            CurZbmId = this.startZbmId;
        }

        // инициализация таблицы

        void InitTable()
        {
            zbmTable1.FillTable();
            zbmTable1.Select(startZbmId);
        }

        // инициализация номера здания
        void InitNumber()
        {
            buildingNumberText.Text = startBuildingNumber;
        }


        private void zbmTable1_SelectionChanged(object sender, EventArgs e)
        {
            if (zbmTable1.SelectedId is int id) CurZbmId = id;
            Changed?.Invoke(this, EventArgs.Empty);
            PropChanged();
        }

        // проверка кнопок
        void CheckButton()
        {
            if (CurBuildingNumber.Length == 0 || startBuildingNumber.Equals(CurBuildingNumber) && startZbmId.Equals(CurZbmId))
            {
                saveButton.Enabled = false;
            }
            else
            {
                saveButton.Enabled = true;
            }
        }

        private void buildingNumberText_TextChanged(object sender, EventArgs e)
        {
            CurBuildingNumber = buildingNumberText.Text;
            PropChanged();
        }

        // действия при изменении свойства

        void PropChanged()
        {
            CheckButton();
        }

        // сохранение результата

        void Save()
        {
            if (IsEditor)
            {
                using var cmd = DataSource.CreateCommand("update Здание set(id_ЗБМ, номер_здания) = ($1, $2) where id_ЗБМ = $3 and номер_здания = $4");
                cmd.Parameters.Add(new() { Value = CurZbmId });
                cmd.Parameters.Add(new() { Value = CurBuildingNumber });
                cmd.Parameters.Add(new() { Value = startZbmId });
                cmd.Parameters.Add(new() { Value = startBuildingNumber });
                cmd.ExecuteNonQuery();
            }
            else
            {
                using var cmd = DataSource.CreateCommand("insert into Здание values($1, $2)");
                cmd.Parameters.Add(new() { Value = CurBuildingNumber });
                cmd.Parameters.Add(new() { Value = CurZbmId });
                cmd.ExecuteNonQuery();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                Saved?.Invoke(this, EventArgs.Empty);
            }
            catch (PostgresException ex)
            {
                switch (ex.SqlState)
                {
                    case "23505":
                        MessageBox.Show("В данном ЗБМ уже есть здание с таким номером.");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Canceled?.Invoke(this, EventArgs.Empty);
        }

        // test

    }
}
