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

namespace trpo.containers
{
    public partial class ContainersForm : Form
    {
        public ContainersForm()
        {
            InitializeComponent();
        }

        private void cubeContainerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ContainersForm_Load(object sender, EventArgs e)
        {
            cubeContainerBindingSource.DataSource = new SortableList<CubeContainer>(ContainerDataSource.GetAllCube());
            cylindricalContainerBindingSource.DataSource = new SortableList<CylindricalContainer>(ContainerDataSource.GetAllCyl());
        }

        private void delButton_Click(object sender, EventArgs e)
        {

            if (containersTab.SelectedTab?.Name == "cubeContainers")
            {
                if (cubeDataGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Контейнер не выбран");
                    return;
                }
                else
                {
                    bool confirm = MessageBox.Show("Подтвердите удаление", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes;
                    if (confirm)
                    {
                        try
                        {
                            CubeContainer cube = cubeDataGrid.SelectedRows[0].DataBoundItem as CubeContainer;
                            ContainerDataSource.Delete(cube);
                            cubeContainerBindingSource.Remove(cube);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                if (cylDataGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Контейнер не выбран");
                    return;
                }
                else
                {
                    bool confirm = MessageBox.Show("Подтвердите удаление", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes;
                    if (confirm)
                    {
                        try
                        {
                            CylindricalContainer cube = cylDataGrid.SelectedRows[0].DataBoundItem as CylindricalContainer;
                            ContainerDataSource.Delete(cube);
                            cylindricalContainerBindingSource.Remove(cube);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (containersTab.SelectedTab?.Name == "cubeContainers")
            {
                var editor = new CubeContainerEditor();
                editor.ShowDialog();
                if (editor.Saved)
                {
                    CubeContainer saved = editor.Edited;
                    cubeContainerBindingSource.Add(editor.Edited);
                    foreach (DataGridViewRow row in cubeDataGrid.Rows)
                    {
                        if (row.DataBoundItem == saved)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                var editor = new CylContainerEditor();
                editor.ShowDialog();
                if (editor.Saved)
                {
                    CylindricalContainer saved = editor.Edited;
                    cylindricalContainerBindingSource.Add(editor.Edited);
                    foreach (DataGridViewRow row in cylDataGrid.Rows)
                    {
                        if (row.DataBoundItem == saved)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (containersTab.SelectedTab?.Name == "cubeContainers")
            {
                if (cubeDataGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Контейнер не выбран");
                }
                else
                {
                    CubeContainer cube = cubeDataGrid.SelectedRows[0].DataBoundItem as CubeContainer;
                    var editor = new CubeContainerEditor() { Edited = cube };
                    editor.ShowDialog();
                    if (editor.Saved)
                    {
                        CubeContainer saved = editor.Edited;
                        cubeContainerBindingSource.Remove(cube);
                        cubeContainerBindingSource.Add(editor.Edited);
                        foreach (DataGridViewRow row in cubeDataGrid.Rows)
                        {
                            if (row.DataBoundItem == saved)
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                if (cylDataGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Контейнер не выбран");
                } else
                {
                    CylindricalContainer cyl = cylDataGrid.SelectedRows[0].DataBoundItem as CylindricalContainer;
                    var editor = new CylContainerEditor() { Edited = cyl };
                    editor.ShowDialog();
                    if (editor.Saved)
                    {
                        CylindricalContainer saved = editor.Edited;
                        cylindricalContainerBindingSource.Remove(cyl);
                        cylindricalContainerBindingSource.Add(editor.Edited);
                        foreach (DataGridViewRow row in cylDataGrid.Rows)
                        {
                            if (row.DataBoundItem == saved)
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
