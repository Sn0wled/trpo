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
    public partial class PlaceEditor : Form
    {
        public PlaceEditor()
        {
            InitializeComponent();
        }
        public bool IsEditor { get; private set; } = false;
        Place edited = new Place();
        string oldPNum;
        public bool Saved { get; private set; } = false;
        public Place Edited
        {
            get { return edited; }
            set
            {
                IsEditor = true;
                edited = value;
                pNum.Text = edited.Number;
                windowLabel.Text = "Редактирование помещения";
                oldPNum = value.Number;
            }
        }
        public Building building { init { edited.ZbmId = value.ZbmId; edited.BuildingNumber = value.Number; } }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pNum.Text.Length == 0)
            {
                MessageBox.Show("Поле \"Номер помещения\" не может быть пустым");
            }
            else if (empDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите ответственного сотрудника");
            }
            else
            {
                edited.Number = pNum.Text;
                edited.EmpTabNum = (empDataGrid.SelectedRows[0].DataBoundItem as Employee).TabNum;
                try
                {
                    if (IsEditor)
                    {
                        PlaceDataSource.Update(ref edited, oldPNum);
                    }
                    else
                    {
                        PlaceDataSource.AddPlace(ref edited);
                    }
                    Saved = true;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PlaceEditor_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = new SortableList<Employee>(EmployeeDatasource.GetAll());
            if (IsEditor)
            {
                foreach (DataGridViewRow row in empDataGrid.Rows)
                {
                    if (row.Cells[0].Value.Equals(edited.EmpTabNum))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
