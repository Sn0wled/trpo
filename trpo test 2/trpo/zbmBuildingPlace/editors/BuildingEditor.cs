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
    public partial class BuildingEditor : Form
    {
        public BuildingEditor()
        {
            InitializeComponent();
        }
        public bool IsEditor { get; private set; } = false;
        Building edited = new Building();
        string oldBNum;
        public Zbm zbm { init { edited.ZbmId = value.Id; } }

        public Building Edited
        {
            get { return edited; }
            set
            {
                IsEditor = true;
                edited = value;
                bNum.Text = edited.Number;
                windowLabel.Text = "Редактирование здания";
                oldBNum = value.Number;
            }
        }

        private void bNum_TextChanged(object sender, EventArgs e)
        {
            edited.Number = bNum.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bNum.Text.Length == 0)
            {
                MessageBox.Show("Поле номер не может быть пустым");
                return;
            }
            try
            {
                if (IsEditor)
                {
                    BuildingDataSource.Update(ref edited, oldBNum);
                }
                else
                {
                    BuildingDataSource.AddBuilding(ref edited);
                }
                Saved = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuildingEditor_Load(object sender, EventArgs e)
        {
        }

        public bool Saved { get; private set; } = false;
    }
}
