using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trpo_test_2.colections;
using trpo_test_2.models;

namespace trpo.zbmBuildingPlace.editors
{
    public partial class ZbmEditor : Form
    {
        public ZbmEditor()
        {
            InitializeComponent();
        }
        public bool IsEditor { get; private set; } = false;
        Zbm edited = new Zbm();
        public Zbm Edited
        {
            get { return edited; }
            set
            {
                IsEditor = true;
                edited = value;
                zbmName.Text = edited.Name;
                windowLabel.Text = "Редактирование ЗБМ";
            }
        }

        public bool Saved { get; private set; } = false;

        private void ZbmEditor_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (zbmName.Text.Length == 0)
            {
                MessageBox.Show("Поле названия не может быть пустым");
                return;
            }
            try
            {
                if (IsEditor)
                {
                    ZbmDatasource.UpdateZbm(ref edited);
                }
                else
                {
                    ZbmDatasource.AddZbm(ref edited);
                }
                Saved = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void zbmName_TextChanged(object sender, EventArgs e)
        {
            edited.Name = zbmName.Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
