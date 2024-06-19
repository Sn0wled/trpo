using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trpo.zbmBuildingPlace.editors;
using trpo_test_2.colections;
using trpo_test_2.models;

namespace trpo
{
    public partial class ZbmBuildingPlace : Form
    {
        public ZbmBuildingPlace()
        {
            InitializeComponent();
        }


        private void ZbmBuildingPlace_Load(object sender, EventArgs e)
        {
            zbmBindingSource.DataSource = new SortableList<Zbm>(ZbmDatasource.GetAll());
            placeCombo.SelectedIndex = 0;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (zbmDataGrid.SelectedRows.Count == 0)
            {
                buildingBindingSource.DataSource = null;
            }
            else
            {
                Zbm selected = zbmDataGrid.SelectedRows[0].DataBoundItem as Zbm;
                buildingBindingSource.DataSource = new SortableList<Building>(BuildingDataSource.GetByZbm(selected));
            }
        }

        private void buildingDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (buildingDataGrid.SelectedRows.Count == 0)
            {
                placeBindingSource.DataSource = null;
            }
            else
            {
                Building selected = buildingDataGrid.SelectedRows[0].DataBoundItem as Building;
                placeBindingSource.DataSource = new SortableList<Place>(PlaceDataSource.GetByBuilding(selected));
            }
        }

        private void placeDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (placeDataGrid.SelectedRows.Count == 0)
            {
                placeDelButton.Enabled = false;
                placeChangeButton.Enabled = false;
            }
            else
            {
                placeDelButton.Enabled = true;
                placeChangeButton.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in zbmDataGrid.Rows)
            {
                if ((row.Cells[1].Value as string).StartsWith((sender as TextBox).Text))
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void buildingSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in buildingDataGrid.Rows)
            {
                if ((row.Cells[1].Value as string).StartsWith((sender as TextBox).Text))
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void placeSearch_TextChanged(object sender, EventArgs e)
        {
            int index = placeCombo.SelectedIndex + 2;
            foreach (DataGridViewRow row in placeDataGrid.Rows)
            {
                if ((row.Cells[index].Value as string).StartsWith((sender as TextBox).Text))
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void zbmDelButton_Click(object sender, EventArgs e)
        {
            if (zbmDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Збм не выбран");
            }
            else
            {
                bool confirm = MessageBox.Show("Подтвердите удаление", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes;
                Zbm deleted = zbmDataGrid.SelectedRows[0].DataBoundItem as Zbm;
                if (confirm)
                {
                    try
                    {
                        ZbmDatasource.Delete(deleted);
                        zbmBindingSource.Remove(deleted);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void zbmChangeButton_Click(object sender, EventArgs e)
        {
            if (zbmDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Збм не выбран");
            }
            else
            {
                ZbmEditor editor = new ZbmEditor();
                Zbm edited = zbmDataGrid.SelectedRows[0].DataBoundItem as Zbm;
                editor.Edited = edited;
                editor.ShowDialog();
                if (editor.Saved)
                {
                    zbmBindingSource.Remove(edited);
                    int index = zbmBindingSource.Add(editor.Edited);
                    zbmDataGrid.Rows[index].Selected = true;
                }
            }
        }

        private void zbmAddButton_Click(object sender, EventArgs e)
        {
            ZbmEditor editor = new ZbmEditor();
            editor.ShowDialog();
            if (editor.Saved)
            {
                int index = zbmBindingSource.Add(editor.Edited);
                zbmDataGrid.Rows[index].Selected = true;
            }
        }

        private void buildAddButton_Click(object sender, EventArgs e)
        {
            if (zbmDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("ЗБМ не выбран");
                return;
            }
            Zbm zbm = zbmDataGrid.SelectedRows[0].DataBoundItem as Zbm;
            BuildingEditor editor = new BuildingEditor() { zbm = zbm };
            editor.ShowDialog();
            if (editor.Saved)
            {
                int index = buildingBindingSource.Add(editor.Edited);
                buildingDataGrid.Rows[index].Selected = true;
            }
        }

        private void buildChangeButton_Click(object sender, EventArgs e)
        {

            if (buildingDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Здание не выбрано");
            }
            else
            {
                BuildingEditor editor = new BuildingEditor();
                Building edited = buildingDataGrid.SelectedRows[0].DataBoundItem as Building;
                editor.Edited = edited;
                editor.ShowDialog();
                if (editor.Saved)
                {
                    buildingBindingSource.Remove(edited);
                    int index = buildingBindingSource.Add(editor.Edited);
                    buildingDataGrid.Rows[index].Selected = true;
                }
            }
        }

        private void buildDelButton_Click(object sender, EventArgs e)
        {
            if (buildingDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Здание не выбрано");
            }
            else
            {
                bool confirm = MessageBox.Show("Подтвердите удаление", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes;
                Building deleted = buildingDataGrid.SelectedRows[0].DataBoundItem as Building;
                if (confirm)
                {
                    try
                    {
                        BuildingDataSource.Delete(deleted);
                        buildingBindingSource.Remove(deleted);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void placeChangeButton_Click(object sender, EventArgs e)
        {
            if (placeDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Помещение не выбрано");
            }
            else
            {
                PlaceEditor editor = new();
                Place edited = placeDataGrid.SelectedRows[0].DataBoundItem as Place;
                editor.Edited = edited;
                editor.ShowDialog();
                if (editor.Saved)
                {
                    placeBindingSource.Remove(edited);
                    int index = placeBindingSource.Add(editor.Edited);
                    placeDataGrid.Rows[index].Selected = true;
                }
            }
        }

        private void placeDelButton_Click(object sender, EventArgs e)
        {
            if (placeDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Здание не выбрано");
            }
            else
            {
                bool confirm = MessageBox.Show("Подтвердите удаление", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes;
                Place deleted = placeDataGrid.SelectedRows[0].DataBoundItem as Place;
                if (confirm)
                {
                    try
                    {
                        PlaceDataSource.Delete(deleted);
                        placeBindingSource.Remove(deleted);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void placeAddButton_Click(object sender, EventArgs e)
        {
            if (buildingDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Здания не выбрано");
                return;
            }
            Building b = buildingDataGrid.SelectedRows[0].DataBoundItem as Building;
            PlaceEditor editor = new PlaceEditor() { building = b };
            editor.ShowDialog();
            if (editor.Saved)
            {
                int index = placeBindingSource.Add(editor.Edited);
                placeDataGrid.Rows[index].Selected = true;
            }
        }
    }
}
