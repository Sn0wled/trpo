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

namespace trpoTest.editors
{
    public partial class ZbmEditor : UserControl
    {
        string startZbmName;
        public int CurZbmId { get; private set; }
        public string CurZbmName { get; private set; }
        public bool IsEditor { get; private set; } = false;
        public NpgsqlDataSource DataSource { get; set; }
        public event EventHandler Saved;
        public event EventHandler Canceled;

        public ZbmEditor()
        {
            InitializeComponent();
        }

        // общее

        public void SetEditor(int? zbmId = null, string? zbmName = null)
        {
            Init(zbmId, zbmName);
            SetZbmName();
            CheckButtons();
        }

        // задает начальные значения
        void Init(int? zbmId = null, string? zbmName = null)
        {
            if (zbmId == null || zbmName == null)
            {
                CurZbmId = 0;
                CurZbmName = "";
                startZbmName = "";
                label1.Text = "Добавление ЗБМ";
                IsEditor = false;
            }
            else
            {
                CurZbmId = zbmId.Value;
                CurZbmName = zbmName;
                startZbmName = zbmName;
                label1.Text = "Изменение ЗБМ";
                IsEditor = true;
            }
        }

        // свойства

        void SetZbmName()
        {
            zbmNameText.Text = CurZbmName;
        }

        private void zbmNameText_TextChanged(object sender, EventArgs e)
        {
            CurZbmName = zbmNameText.Text;
            CheckButtons();
        }

        // кнопки

        void CheckButtons()
        {
            if (CurZbmName.Length == 0 || startZbmName.Equals(CurZbmName)) saveButton.Enabled = false;
            else saveButton.Enabled = true;
        }

        void Save()
        {
            if (DataSource == null) return;

            if (IsEditor)
            {
                using var cmd = DataSource.CreateCommand("update ЗБМ set название = $1 where id_ЗБМ = $2");
                cmd.Parameters.Add(new() { Value = CurZbmName });
                cmd.Parameters.Add(new() { Value = CurZbmId });
                cmd.ExecuteNonQuery();
            }
            else
            {
                using var cmd = DataSource.CreateCommand("insert into ЗБМ (название) values ($1)");
                cmd.Parameters.Add(new() { Value = CurZbmName });
                cmd.ExecuteNonQuery();
            }
        }

        void Cancel()
        {
            Canceled?.Invoke(this, EventArgs.Empty);
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
                        MessageBox.Show("ЗБМ с таким названием уже существует");
                        break;
                    case "22001":
                        MessageBox.Show("Название не может иметь более 20 символов");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
